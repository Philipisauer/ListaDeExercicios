namespace exercicio05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("digite o valor do salario: ");
            double salario = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("digite o quantas vendas o funcionario fez: ");
            double vendas = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("quanto o funcionaro recebe de comissao por venda: ");
            double comissao = Convert.ToDouble(Console.ReadLine());

            double salarioFinal = salario + comissao * vendas;
            Console.WriteLine($"o funcionario deverá receber: {salarioFinal}");


            Console.ReadLine();
        }
    }
}
