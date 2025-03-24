using System.Drawing;
using System.Runtime.ConstrainedExecution;

namespace exercicio10
{
    internal class Program
    {
        //Ler quantidade_pães
        // - Ler quantidade_broas
        //3. Cálculo do total arrecadado
        //// - Calcular total_pães = quantidade_pães * 0,12
        //- Calcular total_broas = quantidade_broas * 1,50
        // - Calcular total_arrecadado = total_pães + total_broas
        //4. Cálculo do valor a guardar na poupança
        //  - Calcular valor_poupança = total_arrecadado * 0,10
        //    - Exibir "Total arrecadado: R$ ", total_arrecadado
        // - Exibir "Valor a guardar na poupança: R$ ", valor_poupança

        static void Main(string[] args)
        {


            Console.WriteLine("Insira o total de paes:  ");
            double paes = Convert.ToDouble(Console.ReadLine());

            paes = 0,12;

            Console.WriteLine("Insira o total de broas:  ");
            double broas = Convert.ToDouble(Console.ReadLine());

            broas = 1,50;

            resultado = paes * 0,12 + broas * 1,50;
        }
    }
}
