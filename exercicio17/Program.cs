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

            if (valorA == valorB)
                resultado = valorA + valorB;

            Console.ReadLine();
        }
    }
}
