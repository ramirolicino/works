using BibliotecaDeClases;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ProjectoTestUnitarios
{
    [TestClass]
    public class ClaseTesteo
    {
        [TestMethod]
        [ExpectedException(typeof(DatosNoValidosException), "Error, unos de los parametros no es valido")]
        public void TestIndicarSiSeLanzaExcepcionAlInsertarUnAlumno_RecibeLosDatos_DevuelveLaExcepcion()
        {
            SqlManejador sql = new();
            Alumno alumno = new Alumno(11111111111111, "Ramiro", 2, 5);

            sql.Insertar(alumno);
        }


        [TestMethod]
        public void TestIndicarSiInsertaAlumno_RecibeLosDatos_DevuelveUnoSiLoInserta()
        {
            SqlManejador sql = new();
            Alumno alumno = new Alumno(41235224, "Ramiro", 2, 5);
            int expected = 1;

            int numComprobacion = sql.Insertar(alumno);

            Assert.AreEqual(expected, numComprobacion);
        }
    }
}
