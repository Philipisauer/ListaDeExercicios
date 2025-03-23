namespace exercicio09
{
    internal class Program
    {
        // Solicitar ao utilizador que insira o comprimento e a largura do terreno.
        // 2.Calcular a área do terreno (área = comprimento * largura).
        // 3. Exibir a área do terreno ao utilizador. 
        static void Main(string[] args)
        {
            Console.WriteLine("digite o comprimento do terreno: ");
            double comprimento = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("digite a largura do terreno: ");
            double largura = Convert.ToDouble(Console.ReadLine());

            double resultado = comprimento * largura;

            Console.WriteLine($"a area do terreno é {resultado}");
            Console.ReadLine();
        }
    }
}
