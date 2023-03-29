using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Atv6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numero = new int[7];
            Console.WriteLine("Digite 7 valores");
            for (int count = 0; count < numero.Length; count++)
            {
                numero[count] = int.Parse(Console.ReadLine());
                 
            }
            Array.Reverse(numero);

            int[] n2 = numero.Distinct().ToArray();
            for (int count = 0; count < numero.Length; count++)
            {


                if (n2[count] % 2 !=0)
                {
                    Console.WriteLine($"Os numeros impares são: {n2[count]}");
                }
            }
        }
    }
}
