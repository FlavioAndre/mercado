using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace Mercado.classesIO.UnidadeMedidas
{
    class UnidadeMedida
    {
        private int codigo;

        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
        private string abreviatura;

        public string Abreviatura
        {
            get { return abreviatura; }
            set { abreviatura = value; }
        }
        private string descricao;

        public string Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }

        [DisplayName("Código")]
        public String CodigoFormatado
        {
            get { return String.Format("{0:0000}", this.codigo); }
        }
    }
}
