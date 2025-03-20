namespace Exercicio02
{
    internal class Program
    {
        //calcular o volume de um cilindro
        static void Main(string[] args)
        {

            double raio = 3.1;
            double altura = 10;

            double volume = Math.PI * Math.Pow(raio, 2) * altura;

            Console.WriteLine($"O volume é igual {volume} cm²");

            Console.ReadLine();
        }
    }
}
