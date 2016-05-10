using System;
using System.Collections.Generic;
using System.Text;

namespace Mercado.classesIO.Compras
{
    class PersisteCompras
    {

        /// <summary>
        /// ID
        /// </summary>
        private int codigo;

        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        /// <summary>
        /// data
        /// </summary>
        private DateTime data;

        public DateTime Data
        {
            get { return data; }
            set { data = value; }
        }

        /// <summary>
        /// cod_mercado
        /// </summary>
        private int cod_mercado;

        public int Cod_mercado
        {
            get { return cod_mercado; }
            set { cod_mercado = value; }
        }

        
        /// <summary>
        /// cod_produto
        /// </summary>
        private int cod_produto;

        public int Cod_produto
        {
            get { return cod_produto; }
            set { cod_produto = value; }
        }
        
        /// <summary>
        /// valor
        /// </summary>
        private decimal valor;

        public decimal Valor
        {
            get { return valor; }
            set { valor = value; }
        }

        /// <summary>
        /// cod_unidade
        /// </summary>
        private int cod_unidade;

        public int Cod_unidade
        {
            get { return cod_unidade; }
            set { cod_unidade = value; }
        }

        /// <summary>
        /// qtd
        /// </summary>
        private decimal qtd;

        public decimal Qtd
        {
            get { return qtd; }
            set { qtd = value; }
        }
    }
}
