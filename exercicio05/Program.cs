namespace exercicio05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("digite o valor do salario: ");
            double salario = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("digite o total de vendas do funcionario: ");
            double vendas = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("quantos % o funcionaro recebe de comissao por venda: ");
            double porcentagem = Convert.ToDouble(Console.ReadLine());

            double salarioFinal = salario + (porcentagem / 100.0 * vendas);
            Console.WriteLine($"o funcionario deverá receber: {salarioFinal}");


            Console.ReadLine();
        }
    }
}
