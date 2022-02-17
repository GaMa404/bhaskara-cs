using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        // Calculando o Delta
        static double contaDelta(int a, int b, int c)
        {
            double delta = (b * b) - (4 * a * c);
            return delta;
        }

        // ====================================================================================

        // Bháskara
        static void contaBhaskara(int b, double delta, int a)
        {        
            if (delta > 0)
            {
                double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                Console.WriteLine("x1 = " + x1);
                Console.WriteLine("x2 = " + x2);
            } 
            else if (delta == 0)
            {
                double x1 = b / (2 * a);
                Console.Write("Possui apenas uma raíz: " + x1);
            }

            else
            {
                Console.Write("Não possui raízes reais");
            }
        }


        // ====================================================================================

        static void Main(string[] args)
        {

            Console.Title = "Calculadora de Equação de Segundo Grau";

            Console.Write("Digite o valor de 'a': ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o valor de 'b': ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o valor de 'c': ");
            int c = Convert.ToInt32(Console.ReadLine());



            double valorDelta = contaDelta(a, b, c);

            contaBhaskara(b, valorDelta, a);



            Console.ReadKey();
        }
    }
}
