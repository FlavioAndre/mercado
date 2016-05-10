using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using Mercado.classesIO;
using Mercado.Resources;
using Mercado.classesIO.Grupos;
using Mercado.classesIO.Produtos;
using Mercado.ExceptionUI;

namespace Mercado.Telas.Cadastros
{
    public partial class CadProdutosUC : UserControl
    {
        private ListaGrupos listaGrupos = new ListaGrupos();
        private ListaProdutos lista = new ListaProdutos();

        private EventHandler envento;
        private bool isProdutoSelecionado = false;
        private Produto produtoSelecionado = null;
        private Grupo grupoSugerido = null;

        public EventHandler Envento
        {
            get { return envento; }
            set { envento = value; }
        }

        public CadProdutosUC()
        {
            InitializeComponent();
            this.inicializaListView();
            this.populaLista();
            this.btnAlterar.Click += new EventHandler(habilitaDesabilitaBotoes);
            this.btnExcluir.Click += new EventHandler(habilitaDesabilitaBotoes);
            this.lstProdutos.Click += new EventHandler(habilitaDesabilitaBotoes);
            this.btnIncluir.Click += new EventHandler(habilitaDesabilitaBotoes);
            this.btnLimpar.Click += new EventHandler(habilitaDesabilitaBotoes);
        }


        private void inicializaListView()
        {
            this.lstProdutos.Items.Clear();
            this.lstProdutos.Columns.Clear();

            int percColumn = (int)Math.Round((this.lstProdutos.ClientSize.Width - 2) / 100.0, 1);
            int diferenca = ((percColumn * 100) - this.lstProdutos.ClientSize.Width);

            this.lstProdutos.Columns.Add(ResourceString.CODIGO, percColumn * 20, HorizontalAlignment.Left);
            this.lstProdutos.Columns.Add(ResourceString.DESCRICAO,percColumn * 60, HorizontalAlignment.Left);
            this.lstProdutos.Columns.Add(ResourceString.GRUPO, (percColumn * 20) - diferenca, HorizontalAlignment.Left);
        }

        private void populaCombo()
        {
            this.listaGrupos = PersisteGrupo.loadGrupos();
            this.cboGrupos.Items.Clear();
            foreach (Grupo c in listaGrupos.getAllGrupos())
            {
                this.cboGrupos.Items.Add(c);
            }
            if (this.grupoSugerido != null)
            {
                this.cboGrupos.SelectedIndex = this.cboGrupos.Items.IndexOf(this.grupoSugerido);
            }
            else
            {
                this.cboGrupos.Text = null;
            }
        }

        private void populaLista()
        {
            try
            {
                lista = PersisteProduto.loadProdutos();
                this.lstProdutos.Items.Clear();
                bool colorGreen = true;
                foreach (Produto c in lista.getAllProdutos())
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
                    li.SubItems.Add(c.Grupo.Descricao);
                    this.lstProdutos.Items.Add(li);
                }
                this.populaCombo();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ResourceString.ERROR_BANCO, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void habilitaDesabilitaBotoes(object sender, EventArgs e)
        {
            this.btnIncluir.Enabled = !this.isProdutoSelecionado;
            this.btnAlterar.Enabled = this.isProdutoSelecionado;
            this.btnExcluir.Enabled = this.isProdutoSelecionado;

            this.btnIncluir.Invalidate();
            this.btnAlterar.Invalidate();
            this.btnExcluir.Invalidate();
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            try
            {
                this.validaCampos();

                this.isProdutoSelecionado = false;
                Produto produto = new Produto();
                produto.Descricao = this.txtDescricao.Text;
                produto.Grupo = (Grupo)this.cboGrupos.SelectedItem;
                this.txtDescricao.Clear();

                PersisteProduto.inserirProduto(produto);
                if (this.grupoSugerido == null || this.grupoSugerido != produto.Grupo)
                {
                    string messageSugestao = String.Format("Deseja deixar o grupo {0} como sugestão", produto.Grupo.Descricao);
                    if (MessageBox.Show(messageSugestao, ResourceString.ATENCAO, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        this.grupoSugerido = produto.Grupo;
                    }
                }
                this.produtoSelecionado = null;
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
            string messageInfo = String.Format(ResourceString.QUESTION_ATUALIZAR, this.produtoSelecionado.CodigoFormatado);
            if (MessageBox.Show(messageInfo, ResourceString.ATENCAO, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    this.validaCampos();

                    this.isProdutoSelecionado = false;
                    this.produtoSelecionado.Descricao = this.txtDescricao.Text;
                    this.produtoSelecionado.Grupo = (Grupo)this.cboGrupos.SelectedItem;
                    this.txtDescricao.Clear();
                    this.txtCodigo.Clear();

                    PersisteProduto.updateProduto(this.produtoSelecionado);

                    this.produtoSelecionado = null;
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
            string messageInfo = String.Format(ResourceString.QUESTION_EXCLUIR, this.produtoSelecionado.CodigoFormatado);
            if (MessageBox.Show(messageInfo, ResourceString.ATENCAO, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.isProdutoSelecionado = false;
                this.txtDescricao.Clear();
                this.txtCodigo.Clear();

                try
                {
                    PersisteProduto.deleteProduto(this.produtoSelecionado);

                    this.produtoSelecionado = null;
                    this.populaLista();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ResourceString.ERROR_BANCO, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            envento.Invoke(sender, e);
        }

        private void lstProdutos_Click(object sender, EventArgs e)
        {
            this.produtoSelecionado = lista.getProduto(this.lstProdutos.FocusedItem.Index);
            this.txtCodigo.Text = this.produtoSelecionado.CodigoFormatado;
            this.txtDescricao.Text = this.produtoSelecionado.Descricao;
            this.cboGrupos.SelectedIndex = this.cboGrupos.Items.IndexOf(this.produtoSelecionado.Grupo);
            this.isProdutoSelecionado = true;
        }

        private void lstProdutos_SizeChanged(object sender, EventArgs e)
        {
            int percColumn = (int)Math.Round((this.lstProdutos.ClientSize.Width) / 100.0, 1);

            int tamanhoOriginal = this.lstProdutos.ClientSize.Width;
            int acumlaTamanho = 0;
            int index = 0;
            foreach (ColumnHeader he in this.lstProdutos.Columns)
            {
                switch (index)
                {
                    case 0:
                        he.Width = percColumn * 20;
                        acumlaTamanho += he.Width;
                        break;
                    case 1:
                        he.Width = percColumn * 60; 
                        acumlaTamanho += he.Width;
                        break;
                    case 2:
                        he.Width = tamanhoOriginal - acumlaTamanho;
                        break;
                }

                index++;
            }
            this.lstProdutos.Update();
            Update();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            this.grupoSugerido = null;
            this.isProdutoSelecionado = false;
            this.txtDescricao.Clear();
            this.txtCodigo.Clear();
            this.produtoSelecionado = null;
            this.populaLista();
        }

        private void validaCampos()
        {
            if (this.txtDescricao.Text == String.Empty || this.txtDescricao.Text.Length == 0)
            {
                this.txtDescricao.Focus();
                throw new ExcecaoCampos(ResourceString.VALIDA_DESCRICAO);
            }

            if (this.cboGrupos.SelectedIndex == -1)
            {
                this.cboGrupos.Focus();
                throw new ExcecaoCampos(ResourceString.VALIDA_COMBO_GRUPOS);
            }
        }
  

        
    }
}
