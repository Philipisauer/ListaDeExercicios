namespace Exercicio01
{
    internal class Program
    {
        //calcular o volume de uma caixa retangular
        static void Main(string[] args)
        {
            Console.WriteLine("digite o comprimento da caixa");
            decimal comprimento = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("digite a largura da caixa");
            decimal largura = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("digite a altura da caixa");
            decimal altura = Convert.ToDecimal(Console.ReadLine());

            decimal resultado = comprimento * largura * altura;

            Console.WriteLine($"O volume da caixa retangular é: {resultado} cm ");

            Console.ReadLine();
        }
    }
}
