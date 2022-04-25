using System;
using System.IO;

namespace Entidades
{
    public static class Logger
    {
        private static string rutaArchivo;

        static Logger()
        {
            string rutaEscritorio = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            rutaArchivo = Path.Combine(rutaEscritorio, "log.txt");
        }


        //Guarda el texto mas Fecha y Hora de ese momento
        public static void Log(string msj)
        {
            try
            {
                using (StreamWriter streamWriter = new StreamWriter(rutaArchivo))
                {
                    streamWriter.WriteLine(msj, DateTime.Now);
                }
            }
            catch (BacklogException ex)
            {
                throw new BacklogException("Error al guaradr el archivo .txt", ex);
            }
        }
    }
}
