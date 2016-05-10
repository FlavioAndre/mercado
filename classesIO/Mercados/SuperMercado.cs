using System;
using System.Collections.Generic;
using System.Text;

namespace Mercado.classesIO.Mercados
{
    /// <summary>
    /// Classe SuperMercado
    /// </summary>
    class SuperMercado
    {
        /// <summary>
        /// Código do mercado
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
        /// Descrição do mercado
        /// </summary>
        private string descricao;

        public string Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }

        public override string ToString()
        {
            return Descricao;
        }

        public override bool Equals(object obj)
        {
            return codigo.Equals(((SuperMercado)obj).codigo);
        }

        public override int GetHashCode()
        {
            return this.Codigo;
        }

    }
}
