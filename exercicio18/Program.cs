namespace exercicio18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("digite ENTER para inicializar o programa: ");

            Console.ReadLine();

            for (int i = 100; i < 200; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }

                Console.ReadLine();
            }
        }
    }
}
