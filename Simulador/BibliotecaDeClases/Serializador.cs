using System;
using System.IO;
using System.Text.Json;

namespace BibliotecaDeClases
{
    public static class Serializador<T> where T : class
    {
        public static T Leer(string archivo, Action<string> mostrarElementos)
        {
            try
            {
                using (StreamReader streamReader = new StreamReader(archivo))
                {
                    mostrarElementos.Invoke("Documento Deserializado con éxito");
                    return JsonSerializer.Deserialize<T>(streamReader.ReadToEnd());
                }
            }
            catch (DirectoryNotFoundException e)
            {
                throw new DirectoryNotFoundException("Directorio no encontrado", e);
            }
            catch (FileNotFoundException e)
            {
                throw new FileNotFoundException("Archivo no encontrado", e);
            }
            catch (Exception e)
            {
                throw new Exception("Ha ocurrido un error", e);
            }
        }
    }
}
