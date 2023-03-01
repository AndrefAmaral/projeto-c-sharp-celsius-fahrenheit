using System;
using System.Globalization;

namespace Teste
{
    class Program
    {
        static void Main(string[] args)
        {
           CultureInfo CI = CultureInfo.InvariantCulture;

            char resp;
            double C, F;

          Console.Write("Voce vai digitar a temperatura em qual escala (C/F)?");
          resp = char.Parse(Console.ReadLine());

          if (resp == 'F' )
          {
            Console.Write("Digite a temperatura em Fahrenheit: ");
            F = double.Parse(Console.ReadLine(), CI);
            C = 5.0 / 9.0 * (F - 32.0);
            Console.WriteLine($"Temperatura equivalente em Celsius: {C}");
          }
          else
          {
            Console.Write("Digite a temperatura em Celsius: ");
            C = double.Parse(Console.ReadLine(), CI);
            F = 9.0 / 5.0 * C + 32.0;
            Console.WriteLine($"Temperatura equivalente em Fahrenheit: {F}");
          }          
         
        }
    }
}
