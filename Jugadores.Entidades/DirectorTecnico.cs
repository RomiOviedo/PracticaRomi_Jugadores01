using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jugadores.Entidades
{
    public class DirectorTecnico : Persona
    {
        private static Tipo tipo;

        public DirectorTecnico()
        {
                
        }
        static DirectorTecnico()
        {
            tipo = Tipo.DirectorTecnico;
        }
        public DirectorTecnico(string apellido, string nombre) : base(apellido, nombre)
        {
        }

        public /*override*/ string FichaTecnica()
        {
            return $"{NombreCompleto()} Director Tecnico";
        }
    }
}
