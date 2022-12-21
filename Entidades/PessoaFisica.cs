using ImpostoRenda.Entidades;

namespace ImpostoRenda.Entidades
{
    internal class PessoaFisica : Contribuinte
    {
        public double GastosComSaude { get; set; }

        public PessoaFisica()
        {
        }
        public PessoaFisica(string nome, double rendimentoAnual, double gastosComSaude)
            : base(nome, rendimentoAnual)
        {
            GastosComSaude = gastosComSaude;
        }
        public override double Taxa()
        {
            if (RendimentoAnual < 20000.00)
            {
                return (RendimentoAnual * 0.15) - (GastosComSaude * 0.50);
            }
            else
            {
                return (RendimentoAnual *  0.25) - (GastosComSaude * 0.50);
            }
        }
    }
}
