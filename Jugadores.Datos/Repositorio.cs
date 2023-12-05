using Jugadores.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jugadores.Datos
{
    public class Repositorio : IRepositorio<Persona>
    {
        public List<Persona> Personas { get ; set ; }

        public Repositorio()
        {
            Personas= new List<Persona>();
            Personas = ManejadorDeArchivoSecuencial.LeerDatos("Personas.txt");

           
        }
        public int GetCantidad()
        {
            return Personas.Count;
        }

        public List<Persona> GetLista()
        {
            return Personas;
        }
    }
}
