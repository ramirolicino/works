using System;
using System.IO;
using System.Text.Json;
using System.Xml.Serialization;

namespace Biblioteca
{
    public class Archivo : IFile<Empleado>
    {
        public Empleado CargarDatosJson(string ruta)
        {
            try
            {
                using (StreamReader streamReader = new StreamReader(ruta))
                {
                    return JsonSerializer.Deserialize<Empleado>(streamReader.ReadToEnd());
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

        public Empleado CargarDatosXML(string ruta)
        {
            try
            {
                using (StreamReader streamReader = new StreamReader(ruta))
                {
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(Empleado));
                    Empleado objeto = xmlSerializer.Deserialize(streamReader) as Empleado;
                    return objeto;
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

        public void GuardarDatosJson(string ruta, Empleado datos)
        {
            try
            {
                using (StreamWriter streamWriter = new StreamWriter(ruta))
                {
                    JsonSerializerOptions jsonOptions = new JsonSerializerOptions();
                    jsonOptions.WriteIndented = true;

                    string contenidoJson = JsonSerializer.Serialize(datos, jsonOptions);
                    streamWriter.Write(contenidoJson);
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

        public void GuardarDatosTxt(string ruta, string datos)
        {
            try
            {
                using (StreamWriter streamWriter = new StreamWriter(ruta))
                {
                    streamWriter.Write(datos);
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

        public void GuardarDatosXml(string ruta, Empleado datos)
        {
            try
            {
                using (StreamWriter streamWriter = new StreamWriter(ruta))
                {
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(Empleado));
                    xmlSerializer.Serialize(streamWriter, datos);
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
                throw e.InnerException;
            }

        }

        public bool ValidarSiExisteElArchivo(string ruta)
        {
            if (File.Exists(ruta))
            {
                return true;
            }

            throw new FileNotFoundException();
        }
    }
}
