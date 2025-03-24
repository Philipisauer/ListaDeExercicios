namespace exercicio12
{
    internal class Program
    {
        //Faça um algoritmo para ler o salário de um funcionário e aumentá-lo em 15%. Após o aumento, desconte 8% de
        //impostos.Imprima o salário inicial, o salário com o aumento e o salário final.
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o salario inicial do funcionario: ");
            double salario = Convert.ToDouble(Console.ReadLine());

            double porcentagemDeAumento = salario * 0.15;

            double salarioComAumento = salario + porcentagemDeAumento;

            double porcentagemDeDesconto = salarioComAumento * 0.08;

            double totalSalario = salarioComAumento - porcentagemDeDesconto;

            Console.WriteLine($"salario inicial: {salario}");

            Console.WriteLine($"salario com o aumento: {salarioComAumento}");

            Console.WriteLine($"salario final: {totalSalario} (FAÇA O L)");

            Console.ReadLine();

            
        }
    }
}
