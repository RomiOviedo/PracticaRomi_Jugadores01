using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jugadores.Entidades
{
    public class Jugador : Persona
    {
        private bool esCapitan;
        private int numero;
        private static Tipo tipo;


        public bool EsCapitan { get=>esCapitan;  }
        public int Numero { get=>numero;  }


        public override bool Equals(object obj)
        {

            if (obj is Jugador j)
            {
                return this.Nombre == j.Nombre && this.Apellido == j.Apellido && this.Numero == j.Numero;
            }
            return false;
        }


        public static explicit operator int(Jugador j1)
        {
            return j1.Numero;
        }

        public Jugador()
        {
                
        }


        static Jugador()
        {
            tipo = Tipo.Jugador;
        }



        public Jugador(string apellido, string nombre) : base(apellido, nombre)
        {

            numero = 0;
            esCapitan = false;
        }
        public Jugador(string apellido, string nombre, bool EsCapitan, int Numero) : this (apellido, nombre)
        {
            esCapitan = EsCapitan;
            numero = Numero;
        }


        public override string NombreCompleto()
        {
            return base.NombreCompleto();
        }
        public /*override*/ string FichaTecnica()
        {
            if (this.EsCapitan==true)
            {
            return $"{Apellido} {Nombre}, Es Capitan, Numero: {Numero} ";

            }
            return $"{Apellido} {Nombre} , Numero: {Numero} ";

        }


        public static bool operator ==(Jugador j1, Jugador j2)
        {
            return j1.Equals(j2);    
        }

        public static bool operator !=(Jugador j1, Jugador j2)
        {
            return !(j1 == j2);
        }









    }
}
