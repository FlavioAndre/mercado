using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Mercado.classesIO.ProdutosLista;
using Mercado.classesIO.Produtos;
using Mercado.Resources;
using Mercado.classesIO.ItensListaProdutos;

namespace Mercado.Telas.Cadastros
{
    public partial class CadItensListaProdutos : Form
    {
        private ProdutoLista produtoListaSelecionado = null;
        
        internal ProdutoLista ProdutoListaSelecionado
        {
            get { return produtoListaSelecionado; }
            set { produtoListaSelecionado = value; }
        }


        private ListaProdutos lista = new ListaProdutos();
        public CadItensListaProdutos()
        {
            InitializeComponent();
        }

        private ListaProdutos listaItensJaCadastrados = new ListaProdutos();

        internal ListaProdutos ListaItensJaCadastrados
        {
            get { return listaItensJaCadastrados; }
            set { listaItensJaCadastrados = value; }
        }

        private void CadItensListaProdutos_Load(object sender, EventArgs e)
        {
            if (produtoListaSelecionado != null)
            {
                this.txtCodigo.Text = ProdutoListaSelecionado.CodigoFormatado;
                this.txtDescricao.Text = ProdutoListaSelecionado.Descricao;
                defineLayoutDataGridView();
                loadProdutos();
            }
        }

        private void defineLayoutDataGridView()
        {
          //  this.dtGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.dtGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            this.dtGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            this.dtGridView.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            this.dtGridView.GridColor = Color.Black;
            this.dtGridView.RowHeadersVisible = false;
            this.dtGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dtGridView.MultiSelect = false;

            int percColumn = (int)Math.Round((this.dtGridView.ClientSize.Width-2) / 100.0, 1);
            int diferenca = ((percColumn * 100) - this.dtGridView.ClientSize.Width);

            //define colunas
            this.dtGridView.ColumnCount = 4;

            this.dtGridView.Columns.Insert(0, new DataGridViewCheckBoxColumn());
            this.dtGridView.Columns[0].Name = "Sel.";
            this.dtGridView.Columns[0].Width = percColumn * 5;


            this.dtGridView.Columns[1].Name = "Código";
            this.dtGridView.Columns[1].Width = percColumn * 10;

            this.dtGridView.Columns[2].Name = "Descrição";
            this.dtGridView.Columns[2].Width = percColumn * 65;

            this.dtGridView.Columns[3].Name = "Grupo";
            this.dtGridView.Columns[3].Width = (percColumn * 20)-diferenca;
        }

        private void dtGridView_SizeChanged(object sender, EventArgs e)
        {
            int percColumn = (int)Math.Round((this.dtGridView.ClientSize.Width - 2) / 100.0, 1);
            int diferenca = ((percColumn * 100) - this.dtGridView.ClientSize.Width);
            this.dtGridView.Columns[0].Width = percColumn * 5;
            this.dtGridView.Columns[1].Width = percColumn * 10;
            this.dtGridView.Columns[2].Width = percColumn * 65;
            this.dtGridView.Columns[3].Width = (percColumn * 20) - diferenca;
        }

        private bool isParOuImpar(int numero)
        {
            return ((numero % 2)==0);
        }

        private void loadProdutos()
        {
            try
            {
                lista = PersisteProduto.loadProdutosOrdenadosGrupoProduto();
                Dictionary<int, Produto> dicProdutosJaCadastrados = new Dictionary<int, Produto>();
                foreach (Produto produto in this.ListaItensJaCadastrados.getAllProdutos())
                {
                    dicProdutosJaCadastrados.Add(produto.Codigo, produto);
                }

               
                this.dtGridView.Rows.Clear();
                foreach (Produto c in lista.getAllProdutos())
                {
                    Color backLine = Color.White;
                    if (dicProdutosJaCadastrados.ContainsKey(c.Codigo))
                    {
                        c.Selecionado = true;
                    }
                    
                    int index = this.dtGridView.Rows.Add(c.ToString().Split(','));
                    if (c.Selecionado)
                    {
                        backLine = Color.PowderBlue;
                    }
                    else
                    {
                        if (isParOuImpar(index))
                        {
                            backLine = Color.Honeydew;
                        }
                    }

                    this.dtGridView.Rows[index].DefaultCellStyle.BackColor = backLine;
                    this.dtGridView.Rows[index].Height = 25;
                    this.dtGridView.Rows[index].Tag = c;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ResourceString.ERROR_BANCO, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            if (MessageBox.Show("Confirma a inclusão dos itens selecionado(s)", ResourceString.ATENCAO, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                PersisteIntesProdutosLista.deleteAllItensProdutosLista(this.produtoListaSelecionado.Codigo);
                foreach (Produto produto in this.lista.getAllProdutos())
                {
                    if (produto.Selecionado)
                    {
                        ItensProdutosLista itens = new ItensProdutosLista();
                        itens.Cod_produto = produto.Codigo;
                        itens.Cod_lista = this.produtoListaSelecionado.Codigo;
                        try
                        {
                            PersisteIntesProdutosLista.inserirItensProdutosLista(itens);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, ResourceString.ERROR_BANCO, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }

            }

            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void dtGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Produto produto = (Produto)this.dtGridView.Rows[e.RowIndex].Tag;
            produto.Selecionado = !produto.Selecionado;
            this.dtGridView.Rows[e.RowIndex].Cells[0].Value = produto.Selecionado;

            if (produto.Selecionado)
            {
                this.dtGridView.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.PowderBlue;
            }
            else
            {
                if (isParOuImpar(e.RowIndex))
                {
                    this.dtGridView.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Honeydew;
                }
                else
                {
                    this.dtGridView.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
                }
            }

        }

      

        
    }
}