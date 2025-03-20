namespace Exercicio03
{
    internal class Program
    {
        //calcular o consumo de gasolina
        static void Main(string[] args)
        {
            double KmInicial = 500;
            double KmFinal = 1000;

            double ConsumoCombustivel = Convert.ToDouble(Console.ReadLine());

            double distantiaPercorrida = KmFinal - KmInicial;

            double ConsumoPorKm = distantiaPercorrida / ConsumoCombustivel;

            Console.WriteLine($"O consumo aproximado foi de: {ConsumoPorKm} Km/L");

            Console.ReadLine();
        }
    }
}
