namespace exercicio13
{
    internal class Program
    {
        //13. Faça um algoritmo que leia os valores A, B, C e imprima na tela se a soma de A + B é menor que C.
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o valor do lado A: ");
            double ladoA = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe o valor do lado B: ");
            double ladoB = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe o valor do lado C: ");
            double ladoC= Convert.ToDouble(Console.ReadLine());

            double soma = ladoA + ladoB;

            if (soma < ladoC)

                Console.WriteLine("A soma dos lados A e b é menor que o lado C.");

            else

                Console.WriteLine("a soma do lado A e lado B é maior que o lado C");
            
                Console.ReadLine();

        }
    }
}
