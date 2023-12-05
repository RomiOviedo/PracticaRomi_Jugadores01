using Jugadores.Entidades;
using System.Collections.Generic;
using System.IO;

namespace Jugadores.Datos
{
    public class ManejadorDeArchivoSecuencial
    {





        public static void Guardar(string archivo, List<Persona> lista) 
        {
            using (var escritor = new StreamWriter(archivo, true))
            {

                foreach (var persona in lista)
                {
                    var linea = ConstruirLinea(persona);

                    escritor.WriteLine(linea);

                }

            }

        }
        private static string ConstruirLinea(Persona persona)
        {
            if (persona.GetType()==typeof(Jugador))
            {

                return $"{persona.Nombre}|{persona.Apellido}|{((Jugador)persona).Numero}|{((Jugador)persona).EsCapitan}|{Tipo.Jugador} ";

            }
            else
            {
                return $"{persona.Nombre}| {persona.Apellido}|{Tipo.DirectorTecnico}";
            }


        }







        public static List<Persona> LeerDatos(string archivo)
        {

            List<Persona> lista = new List<Persona>();


            if (!File.Exists(archivo))
            {
                return lista;
            }


            using (var lector= new StreamReader(archivo))
            {
                while (!lector.EndOfStream)
                {
                    var linea = lector.ReadLine();

                    Persona p = ConstruirPersona(linea);


                    lista.Add(p);


                }

                return lista;

            }


        }

        private static Persona ConstruirPersona(string linea)
        {
            Persona p;

            var campos = linea.Split('|');


            if (campos.Length == 5)
            {
                var nombre = campos[0];

                var apellido = campos[1];

                var numero = int.Parse(campos[2]);

                var esCapitan = bool.Parse(campos[3]);

                var tipo = (Tipo)int.Parse(campos[4]);

                p = new Jugador(apellido, nombre, esCapitan, numero);

            }
            else
            {
                var nombre = campos[0];

                var apellido = campos[1];
                var tipo = (Tipo)int.Parse(campos[2]);

                p = new DirectorTecnico(apellido, nombre);


            }

            return p;



        }





    }
}
