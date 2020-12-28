using System;
using System.Collections.Generic;

namespace ConsoleApp3
{
    public class Calculadora
    {
        public double Soma(List<double> nums)
        {
            double total = 0;
            foreach (double num in nums)
            {
                total += num;
                Console.WriteLine($"Valores durante execução: {total}");
            }

            return total;
        }

        public double Subtracao(double total, List<double> nums)
        {
            foreach (double num in nums)
            {
                total -= num;
                Console.WriteLine($"Valores durante execução: {total}");
            }
            return total;
        }

        public double Multiplicacao(List<double> nums)
        {
            double total = 1;
            foreach (double num in nums)
            {
                total *= num;
                Console.WriteLine($"Valores durante execução: {total}");
            }
            return total;
        }

        public decimal Divisao(decimal total, List<decimal> nums)
        {
            try
            {
                foreach (decimal num in nums)
                {
                    total /= num;
                    Console.WriteLine($"Valores durante execução: {total}");
                }
                return total;
            }
            catch (DivideByZeroException err)
            {
                throw err;
            }
            
        }
    }
}