using System;
using System.Collections.Generic;
using ConsoleApp3;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculadoraTeste
{
    [TestClass]
    public class CalculadoraT
    {
        [TestMethod]
        public void Calculadora_SomarListaNumeros_DoubleTotal_Success()
        {
            List<double> nums = new List<double> { 5, 5 };
            Calculadora calc = new Calculadora();

            double result = calc.Soma(nums);
            double esperado = 10;

            Assert.AreEqual(result, esperado);
        }

        [TestMethod]
        public void Calculadora_SomarListaNumeros_DoubleTotal_Fail()
        {
            List<double> nums = new List<double> { 5, 5 };
            Calculadora calc = new Calculadora();

            double result = calc.Soma(nums);
            double esperado = 15;

            Assert.AreNotEqual(result, esperado);
        }

        [TestMethod]
        public void Calculadora_SubtrairListaNumeros_DoubleTotal_Success()
        {
            List<double> nums = new List<double> { 3, 2 };
            Calculadora calc = new Calculadora();
            double total = 10;

            double result = calc.Subtracao(total, nums);
            double esperado = 5;

            Assert.AreEqual(result, esperado);
        }
        [TestMethod]
        public void Calculadora_SubtrairListaNumeros_DoubleTotal_Fail()
        {
            List<double> nums = new List<double> { 3, 2 };
            Calculadora calc = new Calculadora();
            double total = 10;

            double result = calc.Subtracao(total, nums);
            double esperado = 2;

            Assert.AreNotEqual(result, esperado);
        }

        [TestMethod]
        public void Calculadora_MultiplicarListaNumeros_DoubleTotal_Success()
        {
            List<double> nums = new List<double> { 3, 2 };
            Calculadora calc = new Calculadora();

            double result = calc.Multiplicacao(nums);
            double esperado = 6;

            Assert.AreEqual(result, esperado);
        }
        [TestMethod]
        public void Calculadora_MultiplicarListaNumeros_DoubleTotal_Fail()
        {
            List<double> nums = new List<double> { 3, 2 };
            Calculadora calc = new Calculadora();

            double result = calc.Multiplicacao(nums);
            double esperado = 9;

            Assert.AreNotEqual(result, esperado);
        }

        [TestMethod]
        public void Calculadora_DividirListaNumeros_DecimalTotal_Success()
        {
            List<decimal> nums = new List<decimal> { 10, 2 };
            decimal total = 100;
            Calculadora calc = new Calculadora();

            decimal result = calc.Divisao(total, nums);
            decimal esperado = 5;

            Assert.AreEqual(result, esperado);
        }

        [TestMethod]
        public void Calculadora_DividirListaNumeros_DecimalTotal_Fail()
        {
            List<decimal> nums = new List<decimal> { 10, 2 };
            decimal total = 100;
            Calculadora calc = new Calculadora();

            decimal result = calc.Divisao(total, nums);
            decimal esperado = 9;

            Assert.AreNotEqual(result, esperado);
        }

        [TestMethod]
        public void Calculadora_DividirListaNumerosPorZero_DecimalTotal_Success()
        {
            List<decimal> nums = new List<decimal> { 10, 0 };
            decimal total = 100;
            Calculadora calc = new Calculadora();

            Assert.ThrowsException<DivideByZeroException>(() => calc.Divisao(total, nums));
        }
    }
}
