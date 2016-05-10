using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using Mercado.classesIO.ProdutosLista;
using Mercado.Resources;
using ListaMercados.classesIO.ProdutosLista;
using Mercado.ExceptionUI;
using Mercado.classesIO.ItensListaProdutos;
using Mercado.classesIO.Produtos;
using System.Drawing.Printing;
using System.Collections;

namespace Mercado.Telas.Cadastros
{
    public partial class CadListaProdutosUC : UserControl
    {
        private ListaProdutosLista lista = new ListaProdutosLista();
        private ListaProdutos listaItens = new ListaProdutos();
        private EventHandler envento;
        private bool isProdutosListaSelecionado = false;
        private ProdutoLista produtosListaSelecionado = null;
        private Produto produtoSelecionado = null;
        private Font printFont;
        private int paginaAtual = 1;
        private IEnumerator listaProdutos;

        public EventHandler Envento
        {
            get { return envento; }
            set { envento = value; }
        }


        public CadListaProdutosUC()
        {
            InitializeComponent();
            this.inicializaListView();
            this.populaLista();
            this.btnAlterar.Click += new EventHandler(habilitaDesabilitaBotoes);
            this.btnExcluir.Click += new EventHandler(habilitaDesabilitaBotoes);
            this.lstListaCriadas.Click += new EventHandler(habilitaDesabilitaBotoes);
            this.btnIncluir.Click += new EventHandler(habilitaDesabilitaBotoes);
            this.btnLimpar.Click += new EventHandler(habilitaDesabilitaBotoes);
        }

        private void configuraLayoutListaCriada()
        {
            this.lstListaCriadas.Items.Clear();
            this.lstListaCriadas.Columns.Clear();

            int percColumn = (int)Math.Round((this.lstListaCriadas.ClientSize.Width - 2) / 100.0, 1);
            int diferenca = ((percColumn * 100) - this.lstListaCriadas.ClientSize.Width);

            this.lstListaCriadas.Columns.Add(ResourceString.CODIGO, percColumn * 20, HorizontalAlignment.Left);
            this.lstListaCriadas.Columns.Add(ResourceString.DATA, (percColumn * 20), HorizontalAlignment.Left);
            this.lstListaCriadas.Columns.Add(ResourceString.DESCRICAO, (percColumn * 60) - diferenca, HorizontalAlignment.Left);
        }

        private void configuraLayoutItensProdutos()
        {
            this.lstProdutos.Items.Clear();
            this.lstProdutos.Columns.Clear();

            int percColumn = (int)Math.Round((this.lstProdutos.ClientSize.Width - 2) / 100.0, 1);
            int diferenca = ((percColumn * 100) - this.lstProdutos.ClientSize.Width);

            this.lstProdutos.Columns.Add(ResourceString.CODIGO, percColumn * 20, HorizontalAlignment.Left);
            this.lstProdutos.Columns.Add(ResourceString.DESCRICAO, percColumn * 60, HorizontalAlignment.Left);
            this.lstProdutos.Columns.Add(ResourceString.GRUPO, (percColumn * 20) - diferenca, HorizontalAlignment.Left);

        }

        private void inicializaListView()
        {
            this.configuraLayoutListaCriada();
            this.configuraLayoutItensProdutos();
        }


        private void populaListaItensProdutos()
        {
            try
            {
                this.listaItens = PersisteIntesProdutosLista.loadProdutosSelecionados(this.produtosListaSelecionado.Codigo);
                this.lstProdutos.Items.Clear();
                bool colorGreen = true;
                foreach (Produto c in listaItens.getAllProdutos())
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
                    li.Tag = c;
                    this.lstProdutos.Items.Add(li);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ResourceString.ERROR_BANCO, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void populaLista()
        {
            try
            {
                lista = PersisteProdutosLista.loadProdutosLista();
                this.lstListaCriadas.Items.Clear();
                bool colorGreen = true;
                ListViewItem primeiroItem = null;
                foreach (ProdutoLista c in lista.getAllProdutosListas())
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

                    li.SubItems.Add(c.Data.ToShortDateString());
                    li.SubItems.Add(c.Descricao);
                    
                   
                    if (primeiroItem == null)
                    {
                        li.Selected = true;
                        primeiroItem = li;
                    }
                    this.lstListaCriadas.Items.Add(li);
                }
                if (primeiroItem != null)
                {
                    selecionaListaCriada(0);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ResourceString.ERROR_BANCO, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void habilitaDesabilitaBotoes(object sender, EventArgs e)
        {
            this.btnIncluir.Enabled = !this.isProdutosListaSelecionado;
            this.btnAlterar.Enabled = this.isProdutosListaSelecionado;
            this.btnExcluir.Enabled = this.isProdutosListaSelecionado;

            this.btnIncluir.Invalidate();
            this.btnAlterar.Invalidate();
            this.btnExcluir.Invalidate();

            this.btnExcluirItens.Enabled = false;
            this.btnIncluirItens.Enabled = this.isProdutosListaSelecionado;

        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            try
            {
                this.validaCampos();

                this.isProdutosListaSelecionado = false;
                ProdutoLista produto = new ProdutoLista();
                produto.Descricao = this.txtDescLista.Text;
                this.txtDescLista.Clear();

                PersisteProdutosLista.inserirProdutoLista(produto);

                this.produtosListaSelecionado = null;
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

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            string messageInfo = String.Format(ResourceString.QUESTION_EXCLUIR, this.produtosListaSelecionado.CodigoFormatado);
            if (MessageBox.Show(messageInfo, ResourceString.ATENCAO, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.isProdutosListaSelecionado = false;
                this.txtDescLista.Clear();
                this.txtCodigo.Clear();

                try
                {
                    PersisteProdutosLista.deleteProdutoLista(this.produtosListaSelecionado);

                    this.produtosListaSelecionado = null;
                    this.populaLista();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ResourceString.ERROR_BANCO, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

       

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            string messageInfo = String.Format(ResourceString.QUESTION_ATUALIZAR, this.produtosListaSelecionado.CodigoFormatado);
            if (MessageBox.Show(messageInfo, ResourceString.ATENCAO, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    this.validaCampos();

                    this.isProdutosListaSelecionado = false;
                    this.produtosListaSelecionado.Descricao = this.txtDescLista.Text;
                    this.txtDescLista.Clear();
                    this.txtCodigo.Clear();

                    PersisteProdutosLista.updateProdutoLista(this.produtosListaSelecionado);

                    this.produtosListaSelecionado = null;
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

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            this.isProdutosListaSelecionado = false;
            this.txtDescLista.Clear();
            this.txtCodigo.Clear();
            this.produtosListaSelecionado = null;
            this.populaLista();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            envento.Invoke(sender, e);
        }

       

        private void lstListaCriadas_SizeChanged(object sender, EventArgs e)
        {
            int percColumn = (int)Math.Round((this.lstProdutos.ClientSize.Width) / 100.0, 1);

            int tamanhoOriginal = this.lstListaCriadas.ClientSize.Width;
            int acumlaTamanho = 0;
            int index = 0;
            foreach (ColumnHeader he in this.lstListaCriadas.Columns)
            {
                switch (index)
                {
                    case 0:
                        he.Width = percColumn * 20;
                        acumlaTamanho += he.Width;
                        break;
                    case 1:
                        he.Width = percColumn * 20;
                        acumlaTamanho += he.Width;
                        break;
                    case 2:
                        he.Width = tamanhoOriginal - acumlaTamanho;
                        break;
                }

                index++;
            }
            this.lstListaCriadas.Update();
            Update();
        }

        private void selecionaListaCriada(int index)
        {
            this.produtosListaSelecionado = lista.getListaMercados(index);
            this.txtCodigo.Text = this.produtosListaSelecionado.CodigoFormatado;
            this.txtDescLista.Text = this.produtosListaSelecionado.Descricao;
            this.isProdutosListaSelecionado = true;
            this.btnIncluirItens.Enabled = this.isProdutosListaSelecionado;
            this.populaListaItensProdutos();
        }

        private void lstListaCriadas_Click(object sender, EventArgs e)
        {
            selecionaListaCriada(this.lstListaCriadas.FocusedItem.Index);
        }

      

        private void validaCampos()
        {
            if (this.txtDescLista.Text == String.Empty || this.txtDescLista.Text.Length == 0)
            {
                this.txtDescLista.Focus();
                throw new ExcecaoCampos(ResourceString.VALIDA_DESCRICAO);
            }
        }

        private void btnIncluirItens_Click(object sender, EventArgs e)
        {
            CadItensListaProdutos frm = new CadItensListaProdutos();
            frm.ProdutoListaSelecionado = this.produtosListaSelecionado;
            frm.ListaItensJaCadastrados = this.listaItens;
            if (frm.ShowDialog() == DialogResult.OK)
            {
                populaLista();
            }
        }

        private void btnExcluirItens_Click(object sender, EventArgs e)
        {
            if (this.lstProdutos.FocusedItem != null && this.lstProdutos.FocusedItem.Index > -1)
            {
                if (MessageBox.Show("Confirma a exclusão do produto selecionado", ResourceString.ATENCAO, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    PersisteIntesProdutosLista.deleteProdutoItensProdutosLista(this.produtosListaSelecionado.Codigo, produtoSelecionado.Codigo);
                    produtoSelecionado = null;
                    this.btnExcluirItens.Enabled = false;
                    this.populaListaItensProdutos();
                }
            }
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

        private void lstProdutos_Click(object sender, EventArgs e)
        {
            if (this.lstProdutos.FocusedItem.Index > -1)
            {
                this.btnExcluirItens.Enabled = true;
                produtoSelecionado = (Produto)this.lstProdutos.Items[this.lstProdutos.FocusedItem.Index].Tag;
            }
        }

        private void lstProdutos_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.btnExcluirItens.Enabled = false;
        }

        private void btnItensImprir_Click(object sender, EventArgs e)
        {
            printFont = new Font("Arial", 10);
            PrintDocument pd = new PrintDocument();
            pd.PrintPage += new PrintPageEventHandler
               (this.pd_PrintPage);

            pd.DefaultPageSettings.Landscape = false;

            listaProdutos = listaItens.getAllProdutos().GetEnumerator();
            PrintPreviewDialog objView = new PrintPreviewDialog();
            
            objView.Document = pd;
            objView.WindowState = FormWindowState.Maximized;
                
                objView.PrintPreviewControl.Zoom = 1;   //maxima a visualização
                objView.Text = "Lista de Compras"; 
                ///exibe a janela de visualização para o usuário
                objView.ShowDialog();
                


        }


        // The PrintPage event is raised for each page to be printed.
        private void pd_PrintPage(object sender, PrintPageEventArgs relatorio)
        {
            int margemEsq = relatorio.MarginBounds.Left;
            int margemSup = relatorio.MarginBounds.Top;
            int margemDir = relatorio.MarginBounds.Right;
            int margemInf = relatorio.MarginBounds.Bottom;


            Font fonteTitulo =new Font("Verdana", 15, FontStyle.Bold);
            Font fonteRodape =new Font("Verdana", 8);
            Font fonteNormal = new Font("Verdana", 10);
            Font fonteColuna = new Font("Verdana", 10, FontStyle.Bold);

           

            float linesPerPage = 0;
            float yPos = 0;
            int count = 0;
            float leftMargin = relatorio.MarginBounds.Left;
            float topMargin = relatorio.MarginBounds.Top;
            string line = null;

            string sPath = String.Format(@"{0}\img\{1}", Application.StartupPath,"carinho.jpg");
            Pen caneta = new Pen(Color.Black);
            relatorio.Graphics.DrawLine(caneta, margemEsq, 60, margemDir, 60);
            relatorio.Graphics.DrawImage(Image.FromFile(sPath), 100, 38);
            relatorio.Graphics.DrawLine(caneta, margemEsq, 160, margemDir, 160);
            relatorio.Graphics.DrawString("Lista de Compras", fonteTitulo, Brushes.Black, margemEsq + 275, 80, new StringFormat());

            int margemAcumTitulo = margemEsq;
            //impressão do titulo das colunas
            relatorio.Graphics.DrawString("Check", fonteColuna, Brushes.Black, margemAcumTitulo, 140, new StringFormat());
            margemAcumTitulo = margemAcumTitulo + (5 * (int)fonteRodape.GetHeight());
            relatorio.Graphics.DrawString("Produto", fonteColuna, Brushes.Black, margemAcumTitulo, 140, new StringFormat());
            margemAcumTitulo = margemAcumTitulo + (30 * (int)fonteRodape.GetHeight()) + 10;
            relatorio.Graphics.DrawString("Grupo", fonteColuna, Brushes.Black, margemAcumTitulo, 140, new StringFormat());
            //relatorio.Graphics.DrawLine(caneta, margemEsq, 160 + fonteTitulo.Size + 10, margemDir, 160 + fonteTitulo.Size + 10);


            // Calculate the number of lines per page.
            linesPerPage = relatorio.MarginBounds.Height /
               fonteNormal.GetHeight(relatorio.Graphics) - 6;

           //linhasPorPagina = Relatorio.MarginBounds.Height / fonteNormal.GetHeight(Relatorio.Graphics) - 10

            // Print each line of the file.
            margemSup = 180;
            while (count < linesPerPage && listaProdutos.MoveNext())
            {
                Produto produto = (Produto)listaProdutos.Current;
                line = produto.ToString();
                yPos = margemSup + (count *
                   fonteNormal.GetHeight(relatorio.Graphics));

               // posicaoDaLinha = margemSup + (linhaAtual * fonteNormal.GetHeight(Relatorio.Graphics));
             /*   relatorio.Graphics.DrawString(line, printFont, Brushes.Black,
                   leftMargin, yPos, new StringFormat());*/
                int margemAcum = margemEsq;
               /* relatorio.Graphics.DrawString(produto.CodigoFormatado, fonteNormal, Brushes.Black, margemAcum, yPos, new StringFormat());
                margemAcum = margemAcum + (5 * (int) fonteRodape.GetHeight() )+ 10;*/
                relatorio.Graphics.DrawRectangle(caneta,new Rectangle(margemAcum,(int)yPos,17,13));
                margemAcum = margemAcum + (5 * (int) fonteRodape.GetHeight() );

                relatorio.Graphics.DrawString(String.Format("{0} - {1}",produto.CodigoFormatado,produto.Descricao), fonteNormal, Brushes.Black, margemAcum, yPos, new StringFormat());
                margemAcum = margemAcum + (30 * (int) fonteRodape.GetHeight() ) + 10;
                relatorio.Graphics.DrawString(produto.DescricaoGrupo, fonteNormal, Brushes.Black, margemAcum, yPos, new StringFormat());
                count++;
            }
            //imprime o rodape no relatorio
            relatorio.Graphics.DrawLine(caneta, margemEsq, margemInf, margemDir, margemInf);
            relatorio.Graphics.DrawString(System.DateTime.Now.ToString(), fonteRodape, Brushes.Black, margemEsq, margemInf, new StringFormat());
            relatorio.Graphics.DrawString("Página: " + paginaAtual.ToString(), fonteRodape, Brushes.Black, margemDir - 50, margemInf, new StringFormat());
            //incrementa a página atual
            paginaAtual += 1;

            try
            {
                // If more lines exist, print another page.
                Produto produto = (Produto)listaProdutos.Current;
                relatorio.HasMorePages = true;
            }
            catch(InvalidOperationException)
            {
                relatorio.HasMorePages = false;
            }
            
        }

    }
}
