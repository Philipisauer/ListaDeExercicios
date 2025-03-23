namespace exercicio08
{
    internal class Program
    {
        //numero é primo?
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("digite o numero desejado: ");
                int numero = Convert.ToInt32(Console.ReadLine());

                bool numeroPrimo = true;

                if (numero < 2)
                    numeroPrimo = false;

                if (numero == 2)
                    numeroPrimo = true;

                if (numero % 2 == 0)
                    numeroPrimo = false;

                for (int i = 3; i * i <= numero; i += 2)
                {
                    if (numero % i == 0)
                        numeroPrimo = false;
                }
                    Console.WriteLine(numeroPrimo ? "numero primo" : "não é primo");
                    Console.ReadLine();
                
            }
        }
    }
}
    