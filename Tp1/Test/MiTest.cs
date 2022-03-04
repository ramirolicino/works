using Entidades;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Test
{
    [TestClass]
    public class MiTest
    {
        [TestMethod]
        public void EsBinario_RecibeStringBinario_RetornaTrue()
        {
            //A
            Operando operando = new Operando();

            //A
            bool expected = operando.EsBinario("1111");

            //A
            Assert.IsTrue(expected);
        }

        [TestMethod]
        public void BinarioDecimal_RecibeStringBinario_RetornaNumeroDecimalString()
        {
            //A
            Operando operando = new Operando();
            string expected = "10";

            //A
            string numero = operando.BinarioDecimal("1010");

            //A
            Assert.AreEqual(expected, numero);
        }


        [TestMethod]
        public void DecimalBinario_RecibeNumeroDecimal_RetornaNumeroBinario()
        {
            //A
            Operando operando = new Operando();
            string expected = "1010";

            //A
            string numero = operando.DecimalBinario(10);

            //A
            Assert.AreEqual(expected, numero);
        }

        [TestMethod]
        public void DecimalBinarioString_RecibeNumeroString_RetornaNumeroBinario()
        {
            //A
            Operando operando = new Operando();
            string expected = "1010";

            //A
            string numero = operando.DecimalBinario("10");

            //A
            Assert.AreEqual(expected, numero);
        }
    }
}
