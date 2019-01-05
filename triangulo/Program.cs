using System;

namespace triangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite 3 valores para triângulo");

            var ladoA = int.Parse(Console.ReadLine());
            var ladoB = int.Parse(Console.ReadLine());
            var ladoC = int.Parse(Console.ReadLine());

            var somaAB = ladoA + ladoB > ladoC;
            var somaBC = ladoB + ladoC > ladoA;
            var somaAC = ladoA + ladoC > ladoB;

            if (somaAB && somaAC && somaBC)
            {
                Console.WriteLine("Os valores passados correspondem a um triângulo");
                if (ladoA == ladoB && ladoC == ladoA)
                {
                    Console.WriteLine("É um triângulo Equilátero");
                }
                else if (ladoA == ladoB || ladoB == ladoC || ladoA == ladoC)
                {
                    Console.WriteLine("É um triângulo Isósceles");
                }
                else
                {
                    Console.WriteLine("É um triângulo Escaleno");

                }
            }
            else
            {
                Console.WriteLine("Os valores não correspondem a um triângulo");

            }
        }
    }
}
