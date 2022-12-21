using System;
using System.Globalization;
using ImpostoRenda.Entidades;
namespace ImpostoRenda
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o número de contribuintes: ");
            int contribuintes = int.Parse(Console.ReadLine());

            List<Contribuinte> list = new List<Contribuinte>();

            for (int i = 1; i <= contribuintes; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Dados do contribuinte #{i}");
                Console.Write("Pessoa Fisica ou Pessoa Juridica (F/J): ");
                char ch  =  char.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Rendimento Anual: ");
                double rendimentoAnual = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (ch  == 'f')
                {
                    Console.Write("Quantos foi gasto com saúde?: ");
                    double gastoComSaude = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    list.Add(new PessoaFisica(nome, rendimentoAnual, gastoComSaude));
                }
                else
                {
                    Console.Write("Quantos Colaboradores trabalham na empresa?: ");
                    int quantidadeColaboradores = int.Parse(Console.ReadLine());

                    list.Add(new PessoaJuridica(nome, rendimentoAnual, quantidadeColaboradores));
                }
 
            }

            Console.WriteLine();
            Console.WriteLine("Imposto pago: ");

            double somaTaxa = 0.0;

            foreach(Contribuinte contribuinte in list)
            {
                Console.WriteLine($"{contribuinte.Nome} $ {contribuinte.Taxa().ToString("F2",CultureInfo.InvariantCulture)}");
                somaTaxa += contribuinte.Taxa();
            }
            Console.WriteLine();
            Console.WriteLine($"TOTAL DE IMPOSTO: {somaTaxa.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
