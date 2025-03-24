namespace exercicio15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("informe o peso da pessoa a ser analisada: ");
            double peso = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("informe a altura da pessoa a ser analisada: ");
            double altura = Convert.ToDouble(Console.ReadLine());

            double IMC = peso / altura;

            if (IMC < 18.5)

                Console.WriteLine("a pessoa está abaixo do peso.");

            else if (IMC >= 18.5 || IMC < 25)

                Console.WriteLine("pessoa esta no peso ideal.");

            else if (IMC >= 25 || IMC < 30)

                Console.WriteLine("pessoa acima do peso ou obesa.");

                Console.ReadLine();
        }
    }
}
