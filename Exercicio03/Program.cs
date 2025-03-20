namespace Exercicio03
{
    internal class Program
    {
        //calcular o consumo de gasolina
        static void Main(string[] args)
        {
            Console.WriteLine("quilometragem inicial: ");
            double KmInicial = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("quilometragem Final: ");
            double KmFinal = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("consumo de gasolina: ");
            double ConsumoCombustivel = Convert.ToDouble(Console.ReadLine());

            double distantiaPercorrida = KmFinal - KmInicial;

            double ConsumoPorKm = distantiaPercorrida / ConsumoCombustivel;

            Console.WriteLine($"O consumo aproximado foi de: {ConsumoPorKm} Km/L");

            Console.ReadLine();
        }
    }
}
