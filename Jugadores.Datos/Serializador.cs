using System.IO;
using System.Text.Json;

namespace Jugadores.Datos
{
    public static class Serializador<T> where T : class
    {
        public static void GuardarJson(string archivo, T objeto)
        {
            using (var escritor = new StreamWriter(archivo))
            {
                JsonSerializerOptions options = new JsonSerializerOptions();
                options.WriteIndented = true;

                var stringJson = JsonSerializer.Serialize(objeto, options);

                escritor.WriteLine(stringJson);

            }


        }





        public static T LeerJson(string archivo)
        {
            using (var lector = new StreamReader(archivo))
            {
                string linea = lector.ReadToEnd();

                return JsonSerializer.Deserialize<T>(linea);
            }

        }

    }
}
