using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using Mercado.classesIO;
using Mercado.Resources;
using Mercado.classesIO.Mercados;
using Mercado.ExceptionUI;

namespace Mercado.Telas.Cadastros
{
    public partial class CadMercadosUC : UserControl
    {
        private ListaSuperMercado lista = new ListaSuperMercado();
        private EventHandler envento;
        private bool isMercadoSelecionado = false;
        private SuperMercado mercadoSelecionado = null;

        public EventHandler Envento
        {
            get { return envento; }
            set { envento = value; }
        }

        public CadMercadosUC()
        {
            InitializeComponent();
            this.inicializaListView();
            this.populaLista();
            this.btnAlterar.Click += new EventHandler(habilitaDesabilitaBotoes);
            this.btnExcluir.Click += new EventHandler(habilitaDesabilitaBotoes);
            this.lstMercados.Click += new EventHandler(habilitaDesabilitaBotoes);
            this.btnIncluir.Click += new EventHandler(habilitaDesabilitaBotoes);
            this.btnLimpar.Click += new EventHandler(habilitaDesabilitaBotoes);
            
        }

        private void inicializaListView()
        {
            this.lstMercados.Items.Clear();
            this.lstMercados.Columns.Clear();

            int percColumn = (int)Math.Round((this.lstMercados.ClientSize.Width - 2) / 100.0, 1);
            int diferenca = ((percColumn * 100) - this.lstMercados.ClientSize.Width);

            this.lstMercados.Columns.Add(ResourceString.CODIGO, percColumn * 20, HorizontalAlignment.Left);
            this.lstMercados.Columns.Add(ResourceString.DESCRICAO, (percColumn * 80) - diferenca, HorizontalAlignment.Left);
        }

        private void populaLista()
        {
            try
            {
                lista = PersisteMercado.loadMercados();
                this.lstMercados.Items.Clear();
                bool colorGreen = true;
                foreach (SuperMercado c in lista.getAllMercados())
                {
                    ListViewItem li = new ListViewItem(c.CodigoFormatado);
                    Color backLine = Color.White;
                    if (colorGreen)
                    {
                        colorGreen = false;
                        backLine = Color.Honeydew;
                    }
                    else
                    {
                        colorGreen = true;
                    }

                    li.BackColor = backLine;

                    li.SubItems.Add(c.Descricao);
                    this.lstMercados.Items.Add(li);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ResourceString.ERROR_BANCO, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void habilitaDesabilitaBotoes(object sender, EventArgs e)
        {
            this.btnIncluir.Enabled = ! this.isMercadoSelecionado;
            this.btnAlterar.Enabled = this.isMercadoSelecionado;
            this.btnExcluir.Enabled = this.isMercadoSelecionado;

            this.btnIncluir.Invalidate();
            this.btnAlterar.Invalidate();
            this.btnExcluir.Invalidate();
        }

        private void lstMercados_Click(object sender, EventArgs e)
        {
            this.mercadoSelecionado = lista.getMercado(this.lstMercados.FocusedItem.Index);
            this.txtCodigo.Text = mercadoSelecionado.CodigoFormatado;
            this.txtDescricao.Text = mercadoSelecionado.Descricao;
            this.isMercadoSelecionado = true;
        }

        private void lstMercados_SizeChanged(object sender, EventArgs e)
        {
            int percColumn = (int)Math.Round((this.lstMercados.ClientSize.Width) / 100.0, 1);

            int tamanhoOriginal = this.lstMercados.ClientSize.Width;
            int acumlaTamanho = 0;
            int index = 0;
            foreach (ColumnHeader he in this.lstMercados.Columns)
            {
                switch (index)
                {
                    case 0:
                        he.Width = percColumn * 20;
                        acumlaTamanho += he.Width;
                        break;
                    case 1:
                        he.Width = tamanhoOriginal - acumlaTamanho;
                        break;
                }

                index++;
            }
            this.lstMercados.Update();
            Update();
        }

        public void btnFechar_Click(object sender, EventArgs e)
        {
            envento.Invoke(sender, e);
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            string messageInfo = String.Format(ResourceString.QUESTION_ATUALIZAR, this.mercadoSelecionado.CodigoFormatado);
            if (MessageBox.Show(messageInfo, ResourceString.ATENCAO, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                try
                {
                    this.validaCampos();

                    this.isMercadoSelecionado = false;
                    this.mercadoSelecionado.Descricao = this.txtDescricao.Text;

                    this.txtDescricao.Clear();
                    this.txtCodigo.Clear();

                    PersisteMercado.updateMercado(this.mercadoSelecionado);

                    this.mercadoSelecionado = null;
                    this.populaLista();
                }
                catch (ExcecaoCampos ex)
                {
                    MessageBox.Show(ex.Message, ResourceString.ATENCAO, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ResourceString.ERROR_BANCO, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
              
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            string messageInfo = String.Format(ResourceString.QUESTION_EXCLUIR, this.mercadoSelecionado.CodigoFormatado);
            if (MessageBox.Show(messageInfo, ResourceString.ATENCAO, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.isMercadoSelecionado = false;
                this.txtDescricao.Clear();
                this.txtCodigo.Clear();

                try
                {
                    PersisteMercado.deleteMercado(this.mercadoSelecionado);

                    this.mercadoSelecionado = null;
                    this.populaLista();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ResourceString.ERROR_BANCO, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            try
            {
                this.validaCampos();

                this.isMercadoSelecionado = false;
                SuperMercado mercado = new SuperMercado();
                mercado.Descricao = this.txtDescricao.Text;
                this.txtDescricao.Clear();

                PersisteMercado.inserirMercado(mercado);

                this.mercadoSelecionado = null;
                this.populaLista();
            }
            catch (ExcecaoCampos ex)
            {
                MessageBox.Show(ex.Message, ResourceString.ATENCAO, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,ResourceString.ERROR_BANCO, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void validaCampos()
        {
            if (this.txtDescricao.Text == String.Empty || this.txtDescricao.Text.Length == 0)
            {
                this.txtDescricao.Focus();
                throw new ExcecaoCampos(ResourceString.VALIDA_DESCRICAO);
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            this.isMercadoSelecionado = false;
            this.txtDescricao.Clear();
            this.txtCodigo.Clear();
            this.mercadoSelecionado = null;
            this.populaLista();
        }

    }
}
