namespace Entidades
{
    public interface IGuardar<T>
    {
        public void Guardar(T item, string ruta);
    }
}
