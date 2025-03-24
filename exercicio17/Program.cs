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

            double resultado;

            if (valorA == valorB)
                resultado = valorA + valorB;

            else 
                  resultado = valorA * valorB;

            Console.WriteLine($"resultado {resultado}");

                Console.ReadLine();
        }
    }
}
