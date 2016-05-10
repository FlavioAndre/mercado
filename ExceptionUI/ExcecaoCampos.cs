using System;
using System.Collections.Generic;
using System.Text;

namespace Mercado.ExceptionUI
{
    class ExcecaoCampos : Exception
    {
        private string mensagem;
        public override string Message
        {
            get
            {
                return this.mensagem;
            }
        }
        public ExcecaoCampos(string mensagem)
        {
            this.mensagem = mensagem;
        }
    }
}
