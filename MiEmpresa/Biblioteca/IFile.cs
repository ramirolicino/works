namespace Biblioteca
{
    public interface IFile<T> where T : class
    {
        public bool ValidarSiExisteElArchivo(string ruta);

        //.TXT
        public void GuardarDatosTxt(string ruta, string datos);


        //.XML
        public T CargarDatosXML(string ruta);
        public void GuardarDatosXml(string ruta, T datos);

        //.JSON
        public T CargarDatosJson(string ruta);
        public void GuardarDatosJson(string ruta, T datos);
    }
}
