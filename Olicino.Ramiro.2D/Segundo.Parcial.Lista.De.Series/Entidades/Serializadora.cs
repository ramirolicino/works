using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Xml.Serialization;

namespace Entidades
{
    public class Serializadora : IGuardar<List<Serie>>
    {

        //XML
        public void Guardar(List<Serie> item, string ruta)
        {
            try
            {
                using (StreamWriter streamWriter = new StreamWriter(ruta))
                {
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Serie>));
                    xmlSerializer.Serialize(streamWriter, item);
                }

            }
            catch (BacklogException ex)
            {
                throw new BacklogException("Erorr al guardar", ex);
            }
        }


        //JSON
        void IGuardar<List<Serie>>.Guardar(List<Serie> item, string ruta)
        {
            try
            {
                using (StreamWriter streamWriter = new StreamWriter(ruta))
                {
                    string json = JsonSerializer.Serialize(item);
                    streamWriter.Write(json);
                }
            }
            catch (BacklogException ex)
            {
                throw new BacklogException("Erorr al guardar", ex);
            }
        }
    }
}
