using System;
using System.Collections.Generic;
using System.Text;

namespace Mercado.classesIO.ItensListaProdutos
{
    /// <summary>
    /// Classe IntesProdutosLista
    /// </summary>
    class ItensProdutosLista
    {
        /// <summary>
        /// código de sequencia
        /// </summary>
        private int codigo;

        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        /// <summary>
        /// código do produto
        /// </summary>
        private int cod_produto;

        public int Cod_produto
        {
            get { return cod_produto; }
            set { cod_produto = value; }
        }

        /// <summary>
        /// código da lista
        /// </summary>
        private int cod_lista;

        public int Cod_lista
        {
            get { return cod_lista; }
            set { cod_lista = value; }
        }


        public override string ToString()
        {
            return this.codigo.ToString();
        }

        public override bool Equals(object obj)
        {
            return codigo.Equals(((ItensProdutosLista)obj).codigo);
        }

        public override int GetHashCode()
        {
            return this.Codigo;
        }
    }
}
