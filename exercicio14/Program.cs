using System.ComponentModel.Design;

namespace exercicio14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("digite o primeiro valor: ");
            double valorUm = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("digite o segundo valor: ");
            double valorDois = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("digite o terceiro valor: ");
            double valorTres = Convert.ToDouble(Console.ReadLine());

            if (valorUm > valorDois && valorUm > valorTres && valorDois > valorTres)

                Console.WriteLine($"primeiro valor: {valorUm} segundo valor: {valorDois} terceiro valor: {valorTres}");

            else if (valorUm < valorDois && valorUm < valorTres && valorDois < valorTres)

                Console.WriteLine($"primeiro valor: {valorTres} segundo valor: {valorDois} terceiro valor: {valorUm}");

            Console.ReadLine();
        }
    }
}
