using Jugadores.Entidades;
using System.Collections.Generic;
using System.Text;

namespace Jugadores.Datos
{
    public class Equipo
    {
        private static Deporte deporte;
        private DirectorTecnico directorTecnico;
        private string nombre;

        private List<Jugador> jugadores;


        public Deporte Deporte { get => deporte; set => deporte = value; }

        public string NomnbreEquipo { get => nombre; }


        static Equipo()
        {
            deporte = Deporte.Futbol;
        }
        private Equipo()
        {
            jugadores = new List<Jugador>();
        }

        public Equipo(DirectorTecnico directorTecnico, string nombre) : this()
        {
            this.directorTecnico = directorTecnico;
            this.nombre = nombre;
        }
        public Equipo(Deporte deporte, DirectorTecnico directorTecnico, string nombre) : this(directorTecnico, nombre)
        {
        }



        public bool ExisteCapitan()
        {
            foreach (var item in this.jugadores)
            {
                if (item.EsCapitan == true)
                {
                    return true;
                }
            }
            return false;
        }

        public List<Persona> GetPersonas()
        {
            List<Persona> personas = new List<Persona>();

            foreach (var item in this.jugadores)
            {
                personas.Add(item);
            }
            personas.Add(directorTecnico);

            return personas;

        }
        public static implicit operator string(Equipo e)
        {


            StringBuilder sb = new StringBuilder();

            sb.AppendLine($" Equipo: {e.nombre}");

            sb.AppendLine($"Nomina:");

            foreach (var item in e.jugadores)
            {
                sb.AppendLine($"{item.FichaTecnica()}");
            }
            sb.AppendLine($"{e.directorTecnico}");

            return sb.ToString();
        }

        public static bool operator ==(Equipo e, Jugador j)
        {
            if (!(e is null) || !(j is null))
            {
                foreach (var item in e.jugadores)
                {
                    if (item.Apellido == j.Apellido && item.Nombre == j.Nombre && item.Numero == j.Numero)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public static bool operator !=(Equipo e, Jugador j)
        {
            return !(e == j);
        }

        public static bool operator +(Equipo e, Jugador j)
        {
            if (e != j)
            {
                if (e.ExisteCapitan() == true)
                {
                    if (j.EsCapitan == true)
                    {
                        return false;
                    }
                }
                e.jugadores.Add(j);
                return true;
            }
            return false;

        }

        public static bool operator -(Equipo e, Jugador j)
        {
            if (e == j)
            {
                e.jugadores.Remove(j);
                return true;
            }
            return false;
        }










    }
}
