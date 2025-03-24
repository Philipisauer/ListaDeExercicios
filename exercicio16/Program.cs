namespace exercicio16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("digite o numero para descobrir se é par ou impar: ");
            double numero = Convert.ToDouble(Console.ReadLine());

            if (numero % 2 == 0)
                Console.WriteLine("o numero é par.");

            else
                Console.WriteLine("numero é impar.");

            Console.ReadLine();
        }
    }
}
