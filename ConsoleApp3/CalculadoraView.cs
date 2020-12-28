using System;
using System.Collections.Generic;
using System.Threading;

namespace ConsoleApp3
{
    class CalculadoraView
    {
        public Calculadora Calculadora { get; set; }
        public void MainMenu()
        {
            Calculadora = new Calculadora();
            Boolean flag = true;
            while (flag)
            {
                Console.Clear();
                Console.WriteLine("DIGITE A OPERAÇÃO QUE DESEJA FAZER:");
                Console.WriteLine("SOMA                            [1]");
                Console.WriteLine("SUBTRACAO                       [2]");
                Console.WriteLine("MULTIPLICACAO                   [3]");
                Console.WriteLine("DIVISAO                         [4]");
                Console.WriteLine("SAIR DA CALCULADORA             [0]");
                int operacao = int.Parse(Console.ReadLine());

                switch (operacao)
                {
                    case 1:
                        MenuSoma();
                        break;

                    case 2:
                        MenuSubtracao();
                        break;

                    case 3:
                        MenuMultiplicacao();
                        break;

                    case 4:
                        MenuDivisao();
                        break;

                    case 0:
                        flag = false;
                        Console.WriteLine("OBRIGADO PELA PREFERÊNCIA E VOLTE SEMPRE!");
                        break;

                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }
            }
        }

        public void MenuSoma()
        {
            Console.Clear();
            Console.WriteLine("BEM VINDO AO MENU DE SOMA!");
            Console.WriteLine("Quanto números irá somar?");
            int qntNums = int.Parse(Console.ReadLine());
            List<double> nums = new List<double>();
            for (int i = 1; i <= qntNums; i++)
            {
                Console.WriteLine($"Digite o {i}º número a ser somado:");
                nums.Add(double.Parse(Console.ReadLine()));
                Console.WriteLine();
            }
            double total = Calculadora.Soma(nums);
            Console.WriteLine(total);
            Console.WriteLine("Pressione enter para continuar...");
            Console.ReadLine();
        }

        public void MenuSubtracao()
        {
            Console.Clear();
            Console.WriteLine("BEM VINDO AO MENU DE SUBTRAÇÃO!");
            Console.WriteLine("Qual será o seu minuendo (número total a ser subtraído)?");
            int minuendo = int.Parse(Console.ReadLine());
            Console.WriteLine("Quantos subtraendos (número retirado do minuendo)?");
            int qntNums = int.Parse(Console.ReadLine());
            List<double> nums = new List<double>();
            for (int i = 1; i <= qntNums; i++)
            {
                Console.WriteLine($"Digite o {i}º número usado para subtrair:");
                nums.Add(double.Parse(Console.ReadLine()));
                Console.WriteLine();
            }
            double total = Calculadora.Subtracao(minuendo, nums);
            Console.WriteLine(total);
            Console.WriteLine("Pressione enter para continuar...");
            Console.ReadLine();
        }

        public void MenuMultiplicacao()
        {
            Console.Clear();
            Console.WriteLine("BEM VINDO AO MENU DE MULTIPLICAÇÃO!");
            Console.WriteLine("Quantos multiplicadores você quer?");
            int qntNums = int.Parse(Console.ReadLine());
            List<double> nums = new List<double>();
            for (int i = 1; i <= qntNums; i++)
            {
                Console.WriteLine($"Digite o {i}º número usado para multiplicar:");
                nums.Add(double.Parse(Console.ReadLine()));
                Console.WriteLine();
            }
            double total = Calculadora.Multiplicacao(nums);
            Console.WriteLine(total);
            Console.WriteLine("Pressione enter para continuar...");
            Console.ReadLine();
        }

        public void MenuDivisao()
        {
            Console.Clear();
            Console.WriteLine("BEM VINDO AO MENU DE DIVISÃO!");
            Console.WriteLine("Qual será o seu dividendo (número total a ser dividido)?");
            int dividendo = int.Parse(Console.ReadLine());
            if (dividendo == 0)
            {
                Console.WriteLine("Não é possível dividir por 0! PRESSIONE VOLTANDO A TELA PRINCIPAL");
                Console.ReadLine();
                return;
            }
            Console.WriteLine("Quantos divisores (número retirado do dividendo)?");
            int qntNums = int.Parse(Console.ReadLine());
            List<decimal> nums = new List<decimal>();
            for (int i = 1; i <= qntNums; i++)
            {
                Console.WriteLine($"Digite o {i}º número usado para dividir:");
                decimal num = decimal.Parse(Console.ReadLine());
                if (num == 0)
                {
                    Console.WriteLine("Não é possível dividir por 0! PRESSIONE VOLTANDO A TELA PRINCIPAL");
                    Console.ReadLine();
                    return;
                }
                nums.Add(num);
                Console.WriteLine();
            }
            decimal total = Calculadora.Divisao(dividendo, nums);
            Console.WriteLine(total);
            Console.WriteLine("Pressione enter para continuar...");
            Console.ReadLine();

        }
    }
}
