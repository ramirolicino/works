using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /// <summary>
    /// No podrá tener clases heredadas.
    /// </summary>
    public class Taller
    {
        public enum ETipo
        {
            Ciclomotor, Sedan, SUV, Todos
        }

        private int espacioDisponible;
        private List<Vehiculo> ListaVehiculos;

        #region "Constructores"
        /// <summary>
        /// Constructor de la clase Taller
        /// </summary>
        private Taller()
        {
            this.ListaVehiculos = new List<Vehiculo>();
        }

        /// <summary>
        /// Sobrecarga del constructor de la clase Taller
        /// </summary>
        /// <param name="espacioDisponible"></param>
        public Taller(int espacioDisponible)
            : this()
        {
            this.espacioDisponible = espacioDisponible;
        }
        #endregion

        #region "Sobrecargas"
        /// <summary>
        /// Muestro el estacionamiento y TODOS los vehículos
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return Taller.Listar(this, ETipo.Todos);
        }
        #endregion

        #region "Métodos"

        /// <summary>
        /// Expone los datos del elemento y su lista (incluidas sus herencias)
        /// SOLO del tipo requerido
        /// </summary>
        /// <param name="taller">Elemento a exponer</param>
        /// <param name="ETipo">Tipos de ítems de la lista a mostrar</param>
        /// <returns></returns>
        public static string Listar(Taller taller, ETipo tipo)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Tenemos {taller.ListaVehiculos.Count} lugares ocupados de un total de {taller.espacioDisponible} disponibles");

            foreach (Vehiculo v in taller.ListaVehiculos)
            {
                switch (tipo)
                {
                    case ETipo.SUV:
                        if (v is Suv)
                        {
                            sb.AppendLine(v.Mostrar());
                        }
                        break;
                    case ETipo.Sedan:
                        if (v is Sedan)
                        {
                            sb.AppendLine(v.Mostrar());
                        }
                        break;
                    case ETipo.Ciclomotor:
                        if (v is Ciclomotor)
                        {
                            sb.AppendLine(v.Mostrar());
                        }
                        break;
                    case ETipo.Todos:
                        sb.AppendLine(v.Mostrar());
                        break;
                }
            }
            return sb.ToString();
        }
        #endregion

        #region "Operadores"
        /// <summary>
        /// Agregará un elemento a la lista
        /// </summary>
        /// <param name="taller">Objeto donde se agregará el elemento</param>
        /// <param name="vehiculo">Objeto a agregar</param>
        /// <returns></returns>
        public static Taller operator +(Taller taller, Vehiculo vehiculo)
        {
            if (taller.ListaVehiculos.Count < taller.espacioDisponible)
            {
                foreach (Vehiculo v in taller.ListaVehiculos)
                {
                    if (v == vehiculo)
                    {
                        return taller;
                    }
                }
                taller.ListaVehiculos.Add(vehiculo);
            }
            return taller;
        }

        /// <summary>
        /// Quitará un elemento de la lista
        /// </summary>
        /// <param name="taller">Objeto donde se quitará el elemento</param>
        /// <param name="vehiculo">Objeto a quitar</param>
        /// <returns>taller</returns>
        public static Taller operator -(Taller taller, Vehiculo vehiculo)
        {
            if (taller.ListaVehiculos.Count < 0)
            {
                foreach (Vehiculo v in taller.ListaVehiculos)
                {
                    if (v == vehiculo)
                    {
                        taller.ListaVehiculos.Remove(v);
                        break;
                    }
                }
            }
            return taller;
        }
        #endregion
    }
}
