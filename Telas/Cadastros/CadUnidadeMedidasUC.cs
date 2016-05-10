using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using Mercado.classesIO.UnidadeMedidas;
using Mercado.Resources;
using Mercado.ExceptionUI;

namespace Mercado.Telas.Cadastros
{
    public partial class CadUnidadeMedidasUC : UserControl
    {
        private ListaUnidadeMedida lista = new ListaUnidadeMedida();

        private EventHandler envento;
        private bool isUnidadeMedidaSelecionado = false;
        private UnidadeMedida unidadeMedidaSelecionado = null;

        public EventHandler Envento
        {
            get { return envento; }
            set { envento = value; }
        }

        public CadUnidadeMedidasUC()
        {
            InitializeComponent();
            this.inicializaListView();
            this.populaLista();
            this.btnAlterar.Click += new EventHandler(habilitaDesabilitaBotoes);
            this.btnExcluir.Click += new EventHandler(habilitaDesabilitaBotoes);
            this.lstUnidadeMedida.Click += new EventHandler(habilitaDesabilitaBotoes);
            this.btnIncluir.Click += new EventHandler(habilitaDesabilitaBotoes);
            this.btnLimpar.Click += new EventHandler(habilitaDesabilitaBotoes);
        }

        private void inicializaListView()
        {
            this.lstUnidadeMedida.Items.Clear();
            this.lstUnidadeMedida.Columns.Clear();

            int percColumn = (int)Math.Round((this.lstUnidadeMedida.ClientSize.Width - 2) / 100.0, 1);
            int diferenca = ((percColumn * 100) - this.lstUnidadeMedida.ClientSize.Width);

            this.lstUnidadeMedida.Columns.Add(ResourceString.CODIGO, percColumn * 10, HorizontalAlignment.Left);
            this.lstUnidadeMedida.Columns.Add(ResourceString.ABREVIATURA, percColumn * 15, HorizontalAlignment.Left);
            this.lstUnidadeMedida.Columns.Add(ResourceString.DESCRICAO, (percColumn * 75) - diferenca, HorizontalAlignment.Left);
        }

        private void populaLista()
        {
            try
            {
                lista = PersisteUnidadeMedida.loadUnidadeMedidas();
                this.lstUnidadeMedida.Items.Clear();
                bool colorGreen = true;
                foreach (UnidadeMedida c in lista.getAllUnidadeMedidas())
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
                    li.SubItems.Add(c.Abreviatura);
                    li.SubItems.Add(c.Descricao);
                    this.lstUnidadeMedida.Items.Add(li);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ResourceString.ERROR_BANCO, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void habilitaDesabilitaBotoes(object sender, EventArgs e)
        {
            this.btnIncluir.Enabled = !this.isUnidadeMedidaSelecionado;
            this.btnAlterar.Enabled = this.isUnidadeMedidaSelecionado;
            this.btnExcluir.Enabled = this.isUnidadeMedidaSelecionado;

            this.btnIncluir.Invalidate();
            this.btnAlterar.Invalidate();
            this.btnExcluir.Invalidate();
        }


        private void btnIncluir_Click(object sender, EventArgs e)
        {
            try
            {
                this.validaCampos();

                this.isUnidadeMedidaSelecionado = false;
                UnidadeMedida unidade = new UnidadeMedida();
                unidade.Descricao = this.txtDescricao.Text;
                unidade.Abreviatura = this.txtAbreviatura.Text;
                this.txtDescricao.Clear();
                this.txtAbreviatura.Clear();

                PersisteUnidadeMedida.inserirUnidadeMedida(unidade);

                this.unidadeMedidaSelecionado = null;
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

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            string messageInfo = String.Format(ResourceString.QUESTION_ATUALIZAR, this.unidadeMedidaSelecionado.CodigoFormatado);
            if (MessageBox.Show(messageInfo, ResourceString.ATENCAO, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    this.validaCampos();

                    this.isUnidadeMedidaSelecionado = false;
                    this.unidadeMedidaSelecionado.Descricao = this.txtDescricao.Text;
                    this.unidadeMedidaSelecionado.Abreviatura = this.txtAbreviatura.Text;
                    this.txtDescricao.Clear();
                    this.txtCodigo.Clear();
                    this.txtAbreviatura.Clear();

                    PersisteUnidadeMedida.updateUnidadeMedida(this.unidadeMedidaSelecionado);

                    this.unidadeMedidaSelecionado = null;
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
            string messageInfo = String.Format(ResourceString.QUESTION_EXCLUIR, this.unidadeMedidaSelecionado.CodigoFormatado);
            if (MessageBox.Show(messageInfo, ResourceString.ATENCAO, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.isUnidadeMedidaSelecionado = false;
                this.txtDescricao.Clear();
                this.txtCodigo.Clear();
                this.txtAbreviatura.Clear();

                try
                {
                    PersisteUnidadeMedida.deleteUnidadeMedida(this.unidadeMedidaSelecionado);

                    this.unidadeMedidaSelecionado = null;
                    this.populaLista();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ResourceString.ERROR_BANCO, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            this.isUnidadeMedidaSelecionado = false;
            this.txtDescricao.Clear();
            this.txtCodigo.Clear();
            this.txtAbreviatura.Clear();
            this.unidadeMedidaSelecionado = null;
            this.populaLista();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            envento.Invoke(sender, e);
        }

        private void lstUnidadeMedida_Click(object sender, EventArgs e)
        {

            this.unidadeMedidaSelecionado = lista.getUnidadeMedida(this.lstUnidadeMedida.FocusedItem.Index);
            this.txtCodigo.Text = this.unidadeMedidaSelecionado.CodigoFormatado;
            this.txtAbreviatura.Text = this.unidadeMedidaSelecionado.Abreviatura;
            this.txtDescricao.Text = this.unidadeMedidaSelecionado.Descricao;
            this.isUnidadeMedidaSelecionado = true;
        }

        private void lstUnidadeMedida_SizeChanged(object sender, EventArgs e)
        {
            int percColumn = (int)Math.Round((this.lstUnidadeMedida.ClientSize.Width) / 100.0, 1);

            int tamanhoOriginal = this.lstUnidadeMedida.ClientSize.Width;
            int acumlaTamanho = 0;
            int index = 0;
            foreach (ColumnHeader he in this.lstUnidadeMedida.Columns)
            {
                switch (index)
                {
                    case 0:
                        he.Width = percColumn * 10;
                        acumlaTamanho += he.Width;
                        break;
                    case 1:
                        he.Width = percColumn * 15;
                        acumlaTamanho += he.Width;
                        break;
                    case 2:
                        he.Width = tamanhoOriginal - acumlaTamanho;
                        break;
                }

                index++;
            }
            this.lstUnidadeMedida.Update();
            Update();
        }

        private void validaCampos()
        {
            if (this.txtDescricao.Text == String.Empty || this.txtDescricao.Text.Length == 0)
            {
                this.txtDescricao.Focus();
                throw new ExcecaoCampos(ResourceString.VALIDA_DESCRICAO);
            }

            if (this.txtAbreviatura.Text == String.Empty || this.txtAbreviatura.Text.Length == 0)
            {
                this.txtAbreviatura.Focus();
                throw new ExcecaoCampos(ResourceString.VALIDA_ABREVIATURA);
            }
            
        }
    }
}
