namespace exercicio06
{
    internal class Program
    //calcula-se dividindo o número total de elementos (n) pela soma dos inversos de cada elemento
    //H = n / (1/x1 + 1/x2 + 1/x3 + ... + 1/xn) 
    {
        static void Main(string[] args)
        {

            Console.WriteLine("digite a primeira nota: ");
            double nota1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("digite a segunda nota: ");
            double nota2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("digite a terceira nota: ");
            double nota3 = Convert.ToDouble(Console.ReadLine());

            double resultado = 3.0 / ((1.0 / nota1) + (1.0 / nota2) + (1.0 / nota3));

            Console.WriteLine($"media {Math.Round(resultado)}");
            Console.ReadLine();
        }
    }
}
