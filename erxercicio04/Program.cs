using System.Text.RegularExpressions;

namespace erxercicio04
{
    internal class Program
    {
        // FORMULA (F = C x 1,8 + 32)
        //F=Fahrenheit
        //C=Celsius
        static void Main(string[] args)
        {
            Console.WriteLine("digite os Graus Celsius para transformar em fahreinheit: ");
            double valor = Convert.ToDouble(Console.ReadLine());

            double resultado = valor * 1.8 + 32;

            Console.WriteLine($"fahreinheit é igual a: {resultado}");

            Console.ReadLine();

        }
    }
}