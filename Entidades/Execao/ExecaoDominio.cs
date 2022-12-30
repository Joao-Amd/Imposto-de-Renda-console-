using System;

namespace ImpostoRenda.Entidades.Execao
{
    internal class ExecaoDominio : ApplicationException
    {
        public ExecaoDominio(string message) : base(message)
        {

        }
    }
}
