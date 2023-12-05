using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jugadores.Datos
{
    public interface IRepositorio<Persona>
    {

         List<Persona> Personas { get; set; }

        int GetCantidad();


        List<Persona> GetLista();
    }
}
