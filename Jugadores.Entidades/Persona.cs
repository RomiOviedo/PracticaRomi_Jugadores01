using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Jugadores.Entidades
{
    //[XmlInclude(typeof(Jugador))]
    //[XmlInclude(typeof(DirectorTecnico))]

    public /*abstract*/ class Persona
    {

        private string apellido;
        private string nombre;

        public Persona()
        {

        }

        //[JsonConstructor]
        protected Persona(string apellido, string nombre) :this()
        {
            this.apellido = apellido;
            this.nombre = nombre;
        }

        public string Apellido { get => apellido; }
        public string Nombre { get => nombre; }


        //public /*abstract*/ string FichaTecnica();
        public virtual string NombreCompleto()
        {
            return $"{nombre} {Apellido}";
        }

        public override string ToString()
        {
            return $"{NombreCompleto()}";
        }










    }
}
