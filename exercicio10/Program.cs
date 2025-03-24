using System.Drawing;
using System.Runtime.ConstrainedExecution;

namespace exercicio10
{
    internal class Program
    {
        //Ler quantidade_pães xx
        // - Ler quantidade_broas xx
        //3. Cálculo do total arrecadado xx
        //// - Calcular total_pães = quantidade_pães * 0,12 xx
        //- Calcular total_broas = quantidade_broas * 1,50 xx
        // - Calcular total_arrecadado = total_pães + total_broas
        //4. Cálculo do valor a guardar na poupança
        //  - Calcular valor_poupança = total_arrecadado * 0,10
        //    - Exibir "Total arrecadado: R$ ", total_arrecadado
        // - Exibir "Valor a guardar na poupança: R$ ", valor_poupança

        static void Main(string[] args)
        {


            Console.WriteLine("Insira o total de pães:  ");
            double paes = Convert.ToDouble(Console.ReadLine());

            paes = paes * 0.12;

            Console.WriteLine("Insira o total de broas:  ");
            double broas = Convert.ToDouble(Console.ReadLine());

            broas = broas * 1.50;

            double resultado = paes + broas;

            Console.WriteLine($"valor total de lucro é: {resultado}");
            
            double poupanca = resultado * 0.10;

            Console.WriteLine($"o valor arrecadado para a poupança será de: {poupanca}");

            Console.ReadLine();


        }
    }
}
