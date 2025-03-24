namespace exercicio11
{
    internal class Program
    {
        static void Main(string[] args)
            //365 dias * anos = total de dias
        {
            Console.WriteLine("Digite seu nome ou o nome da pessoas a ser analisada:  ");
            string nome = Console.ReadLine();

            Console.WriteLine("Agora digite a idade: ");
            double idade = Convert.ToDouble(Console.ReadLine());

            double resultado = idade * 365;

            Console.WriteLine($"{nome} tem aproximadamente {resultado} dias de vida.");
            Console.ReadLine();
        }
    }
}
