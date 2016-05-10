using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using Mercado.Telas.Cadastros;

namespace Mercado.Telas.Menus
{
    public partial class MenuCadastrosUC : UserControl
    {
        private SplitterPanel panel;

        public SplitterPanel Panel
        {
            get { return panel; }
            set { panel = value; }
        }

        public MenuCadastrosUC()
        {
            InitializeComponent();
        }

        private void lnkCadGrupos_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CadGruposUC frm = new CadGruposUC();
            
            frm.Dock = DockStyle.Fill;
            frm.Envento += new EventHandler(btnFechar_Click);
            panel.Controls.Clear();
            panel.Controls.Add(frm);
        }

        public void btnFechar_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
        }

        private void lnkCadProdutos_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CadProdutosUC frm = new CadProdutosUC();

            frm.Dock = DockStyle.Fill;
            frm.Envento += new EventHandler(btnFechar_Click);
            panel.Controls.Clear();
            panel.Controls.Add(frm);
        }

        private void lnkCadMercados_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CadMercadosUC frm = new CadMercadosUC();

            frm.Dock = DockStyle.Fill;
            frm.Envento += new EventHandler(btnFechar_Click);
            panel.Controls.Clear();
            panel.Controls.Add(frm);
        }

        private void lnkCadLista_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            CadListaProdutosUC frm = new CadListaProdutosUC();

            frm.Dock = DockStyle.Fill;
            frm.Envento += new EventHandler(btnFechar_Click);
            panel.Controls.Clear();
            panel.Controls.Add(frm);
        }

        private void lnkCadUnidadeMedida_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CadUnidadeMedidasUC frm = new CadUnidadeMedidasUC();

            frm.Dock = DockStyle.Fill;
            frm.Envento += new EventHandler(btnFechar_Click);
            panel.Controls.Clear();
            panel.Controls.Add(frm);
        }

      
        

        
    }
}
