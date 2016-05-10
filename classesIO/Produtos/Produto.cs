using System;
using System.Collections.Generic;
using System.Text;
using Mercado.classesIO.Grupos;
using System.ComponentModel;

namespace Mercado.classesIO.Produtos
{
    /// <summary>
    /// Classe de produtos
    /// </summary>
    [Serializable]
    class Produto
    {
        /// <summary>
        /// Código do produto
        /// </summary>
        private int codigo;
        [BrowsableAttribute(false)]
        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
        
        [DisplayName("Código")]
        public String CodigoFormatado
        {
            get { return String.Format("{0:0000}", this.codigo); }
        }
        /// <summary>
        /// Descrição do produto
        /// </summary>
        private string descricao;
        [DisplayName("Descrição")]
        public string Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }
        [DisplayName("Grupo do produto")]
        public string DescricaoGrupo
        {
            get { return Grupo.Descricao; }
        }
        /// <summary>
        /// Grupo a qual pertence o produto
        /// </summary>
        private Grupo grupo;

        internal Grupo Grupo
        {
            get { return grupo; }
            set { grupo = value; }
        }

        private bool selecionado = false;

        public bool Selecionado
        {
            get { return selecionado; }
            set { selecionado = value; }
        }

        public override string ToString()
        {
            return String.Format("{0},{1},{2},{3}",this.Selecionado, this.CodigoFormatado, this.Descricao, this.Grupo.Descricao);
        }


    }
}
