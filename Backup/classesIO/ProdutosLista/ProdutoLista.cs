using System;
using System.Collections.Generic;
using System.Text;

namespace Mercado.classesIO.ProdutosLista
{
    class ProdutoLista
    {
        /// <summary>
        /// Código do produtoLista
        /// </summary>
        private int codigo;

        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        public String CodigoFormatado
        {
            get { return String.Format("{0:000}", this.codigo); }
        }

        /// <summary>
        /// Descrição do produtoLista
        /// </summary>
        private string descricao;

        public string Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }

        /// <summary>
        /// Data de criação
        /// </summary>
        private DateTime data;

        public DateTime Data
        {
            get { return data; }
            set { data = value; }
        }

        public override string ToString()
        {
            return Descricao;
        }

        public override bool Equals(object obj)
        {
            return codigo.Equals(((ProdutoLista)obj).codigo);
        }

        public override int GetHashCode()
        {
            return this.Codigo;
        }

    }
}
