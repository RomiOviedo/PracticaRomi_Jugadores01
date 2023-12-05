using Jugadores.Datos;
using Jugadores.Entidades;
using System;
using System.Collections.Generic;
using System.Text.Json;

namespace Practica_Jugadores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DirectorTecnico dt = new DirectorTecnico("Nievas", "Lucho");

            Equipo e = new Equipo(dt, "Equipo01");


            Jugador j1 = new Jugador("Polo", "Lucas");
            Jugador j2 = new Jugador("Pollo", "Jose");
            Jugador j3 = new Jugador("Palo", "Dalmiro");
            Jugador j4 = new Jugador("Pelo", "Pancho");

            Jugador j5 = new Jugador("Capi", "America", true, 10);

            Jugador j6 = new Jugador("Capi", "Numero2", true, 10);


            if (e + j1)
            {
                Console.WriteLine($"Se ingreso el juagdor: {j1.NombreCompleto()} al equipo: {e.NomnbreEquipo}");
            }
            else
            {
                Console.WriteLine($" el juagdor: {j1.NombreCompleto()} ya pertenecia al equipo: {e.NomnbreEquipo}");

            }

            if (e + j2)
            {
                Console.WriteLine($"Se ingreso el juagdor:{j2.NombreCompleto()} al equipo: {e.NomnbreEquipo}");

            }
            else
            {
                Console.WriteLine($" el juagdor: {j2.NombreCompleto()} ya pertenecia al equipo: {e.NomnbreEquipo}");

            }
            if (e + j3)
            {
                Console.WriteLine($"Se ingreso el juagdor: {j3.NombreCompleto()} al equipo: {e.NomnbreEquipo}");

            }
            else
            {
                Console.WriteLine($" el juagdor: {j3.NombreCompleto()} ya pertenecia al equipo: {e.NomnbreEquipo}");

            }
            if (e + j4)
            {
                Console.WriteLine($"Se ingreso el juagdor: {j4.NombreCompleto()} al equipo: {e.NomnbreEquipo}");

            }
            else
            {
                Console.WriteLine($" el juagdor: {j4.NombreCompleto()} ya pertenecia al equipo: {e.NomnbreEquipo}");

            }
            if (e + j5)
            {
                Console.WriteLine($"Se ingreso el Capitan :{j5.NombreCompleto()} al equipo: {e.NomnbreEquipo}");

            }
            else
            {
                Console.WriteLine($" el Capitan :{j5.NombreCompleto()} ya pertenecia al equipo: {e.NomnbreEquipo}");

            }
            if (e + j6)
            {
                Console.WriteLine($"Se ingreso el CApitan: {j6.NombreCompleto()} al equipo: {e.NomnbreEquipo}");

            }
            else
            {
                Console.WriteLine($" El equipo: {e.NomnbreEquipo} ya tiene un capitan");

            }

            //Console.WriteLine(e.GetPersonas());

            //Console.WriteLine("Datos de las personas en el equipo:");

            //List<Persona> datosPersonas = e.GetPersonas();

            //// Mostrar cada persona individualmente
            //foreach (Persona persona in datosPersonas)
            //{
            //    Console.WriteLine(persona.ToString());
            //}


            string equipo = e;

            Serializador<List<Persona>>.GuardarJson("Personas.json", e.GetPersonas());

            Console.WriteLine(equipo);

            Console.WriteLine("Leyendo json");
            Console.WriteLine();



            string rutaArchivo = "Personas.json";


            List<Persona> personasDesdeArchivo = Serializador<List<Persona>>.LeerJson(rutaArchivo);




            foreach (var persona in personasDesdeArchivo)
            {
                //if (persona.GetType() == typeof(Jugador))
                //{

                //    Console.WriteLine($"{persona.Nombre}|{persona.Apellido}|{((Jugador)persona).Numero}|{((Jugador)persona).EsCapitan}|{Tipo.Jugador} ");

                //}
                //else
                //{
                //    Console.WriteLine($"{persona.Nombre}| {persona.Apellido}|{Tipo.DirectorTecnico}"); 
                //}
                    Console.WriteLine( $"{persona.Nombre} {persona.Apellido}");
            }


            //Console.WriteLine($"{Serializador<List<Persona>>.LeerJson("Personas.json")}");


            //Persona persona = Serializador<Persona>.LeerJson("Personas.json");

            //Console.WriteLine(persona);

            //string NombreArchivo = "Personas.json";

            //Persona p = JsonSerializer.Deserialize<Persona>(NombreArchivo);
            //Console.WriteLine($"{p.Apellido}");
            //Console.WriteLine($"{p.Nombre}");





            Console.ReadLine();

        }
    }
}
