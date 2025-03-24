using System.Runtime.Serialization;

namespace exercicio17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("informe valor A: ");
            int valorA = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("informe valor B: ");
            int valorB = Convert.ToInt32(Console.ReadLine());

            double resultado1;

            double resultado2;

            if (valorA == valorB)
                resultado1 = valorA + valorB;

            else 
                  resultado2 = valorA * valorB;

            Console.WriteLine($"resultado {}");




                Console.ReadLine();
        }
    }
}
