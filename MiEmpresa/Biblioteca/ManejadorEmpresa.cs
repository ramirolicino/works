using System.Collections.Generic;

namespace Biblioteca
{
    public static class ManejadorEmpresa
    {
        private static List<Empleado> empleadosActivo;
        private static List<Empleado> empleadosInactivos;
        private static List<Puesto> puestos;

        static ManejadorEmpresa()
        {
            puestos = PuestoSQL.CargarPuestos();
            empleadosActivo = EmpleadoSQL.CargarEmpleados(1);
            empleadosInactivos = EmpleadoSQL.CargarEmpleados(0);
        }

        public static List<Empleado> EmpleadosActivo { get => empleadosActivo; set => empleadosActivo = value; }
        public static List<Empleado> EmpleadosInactivos { get => empleadosInactivos; set => empleadosInactivos = value; }
        public static List<Puesto> ListaPuestos { get => puestos; set => puestos = value; }



        private static bool EmpleadoActivo(Empleado emp)
        {
            if (emp is not null)
            {
                foreach (Empleado item in empleadosActivo)
                {
                    if (item == emp)
                    {
                        return true;
                    }
                }
            }

            return false;
        }


        public static bool AgregarEmpleado(Empleado emp)
        {
            if (emp is not null)
            {
                if (!EmpleadoActivo(emp))
                {
                    if (EmpleadoSQL.Agregar(emp))
                    {
                        EmpleadosActivo = EmpleadoSQL.CargarEmpleados(1);
                    }
                    return true;
                }
                else
                {
                    throw new EmpleadoExcepcion("Error! Empleado ya existente");
                }
            }
            return false;
        }


        public static bool ModificarEmpleado(Empleado emp)
        {
            if (emp is not null)
            {
                if (EmpleadoActivo(emp))
                {
                    if (EmpleadoSQL.Modificar(emp))
                    {
                        ActualizarEmpleados(1);
                    }
                }

                return true;
            }
            return false;
        }

        public static bool AltaEmpleado(Empleado emp)
        {
            if (emp is not null)
            {

                emp.Estado = true;
                if (EmpleadoSQL.Estado(emp))
                {
                    ActualizarEmpleados(1);
                    ActualizarEmpleados(0);
                }

                return true;
            }
            return false;
        }

        public static bool BajaEmpleado(Empleado emp)
        {
            if (emp is not null)
            {
                if (EmpleadoActivo(emp))
                {
                    emp.Estado = false;
                    if (EmpleadoSQL.Estado(emp))
                    {
                        ActualizarEmpleados(1);
                        ActualizarEmpleados(0);
                    }

                    return true;
                }
            }
            return false;
        }





        private static void ActualizarEmpleados(int indicar)
        {
            if (indicar == 1)
            {
                EmpleadosActivo = EmpleadoSQL.CargarEmpleados(1);
            }
            else
            {
                EmpleadosInactivos = EmpleadoSQL.CargarEmpleados(0);
            }
        }
    }
}
