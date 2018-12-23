using System;
using System.Text.RegularExpressions;

namespace hello_world
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o primeiro valor:");

            var inputValor = Console.ReadLine();

            if(NaoEhNumerico(inputValor)) return;

            var valor1 = int.Parse(inputValor);

            Console.Write("Digite o segundo valor:");

            inputValor = Console.ReadLine();

            if(NaoEhNumerico(inputValor)) return;
            
            var valor2 = int.Parse(inputValor);          

            var total = valor1 + valor2;

            // string valorString1 = "5";
            // string valorString2 = "10";

            // string totalString = valorString1 + valorString2;

            // string resultado = "valor1 (" + valor1 + ") + valor2 (" + valor2 +") = " + total;
            //concatenação com interpolate

            Console.WriteLine($"{valor1} + {valor2} = {total}");
            // Console.WriteLine($"Soma {total}");
            // Console.WriteLine($"Concatenação {totalString}");
            
        }

        public static bool NaoEhNumerico(string input) {
            var resultado = Regex.IsMatch(input, @"^\d+$");

            if(resultado) return false;

            Console.WriteLine("Digite um valor númerico válido.");
            return true;
        }
    }
}
