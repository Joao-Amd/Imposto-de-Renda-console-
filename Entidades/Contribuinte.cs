using ImpostoRenda.Entidades.Execao;
namespace ImpostoRenda.Entidades
{
    abstract class Contribuinte
    {
        public string Nome { get; set; }
        public double RendimentoAnual { get; set; }
        public char TipoPessoa { get; set; }
      
        public Contribuinte(char tipoPessoa) 
        {
            if (tipoPessoa == 'f' || tipoPessoa == 'j')
            {
                TipoPessoa = tipoPessoa;
            }
            else { throw new ExecaoDominio("O tipo de pessoa só pode ser F ou J"); }
            
        }
        protected Contribuinte(string nome, double rendimentoAnual)
        {
            Nome = nome;
            RendimentoAnual = rendimentoAnual;
           
        }

        public abstract double Taxa();
        
    }
}
