namespace Biblioteca
{
    public static class Extencion
    {
        public static string UpperFirstChar(this string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return null;
            }

            return char.ToUpper(input[0]) + input.Substring(1);
        }


        //Convertidor
        public static Puesto ConvertirPuesto(int id)
        {
            Puesto auxPuesto = null;

            if (id > 0)
            {
                foreach (Puesto item in ManejadorEmpresa.ListaPuestos)
                {
                    if (item.Id == id)
                    {
                        auxPuesto = item;
                    }
                }
            }

            return auxPuesto;
        }

    }


}
