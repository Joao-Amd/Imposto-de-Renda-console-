namespace ImpostoRenda.Entidades
{
    internal class PessoaJuridica : Contribuinte
    {
        public int QuantidadeColaboradores { get; set; }

        public PessoaJuridica()
        {
        }
        public PessoaJuridica(string nome, double rendimentoAnual, int quantidadeColaboradores) 
            : base(nome, rendimentoAnual)
        {
            QuantidadeColaboradores = quantidadeColaboradores;
        }

        public override double Taxa()
        {
            if(QuantidadeColaboradores > 10)
            {
                return RendimentoAnual * 0.14;
            }
            else
            {
                return RendimentoAnual * 0.16;
            }
        }
    }
}
