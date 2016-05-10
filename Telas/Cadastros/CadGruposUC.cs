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
using Mercado.ExceptionUI;

namespace Mercado.Telas.Cadastros
{
    public partial class CadGruposUC : UserControl
    {
        private ListaGrupos lista = new ListaGrupos();
        private EventHandler envento;
        private bool isGrupoSelecionado = false;
        private Grupo grupoSelecionado = null;

        public EventHandler Envento
        {
            get { return envento; }
            set { envento = value; }
        }

        public CadGruposUC()
        {
            InitializeComponent();
            this.inicializaListView();
            this.populaLista();
            this.btnAlterar.Click += new EventHandler(habilitaDesabilitaBotoes);
            this.btnExcluir.Click += new EventHandler(habilitaDesabilitaBotoes);
            this.lstGrupos.Click += new EventHandler(habilitaDesabilitaBotoes);
            this.btnIncluir.Click += new EventHandler(habilitaDesabilitaBotoes);
            this.btnLimpar.Click += new EventHandler(habilitaDesabilitaBotoes);
            
        }

        private void inicializaListView()
        {
            this.lstGrupos.Items.Clear();
            this.lstGrupos.Columns.Clear();

            int percColumn = (int)Math.Round((this.lstGrupos.ClientSize.Width - 2) / 100.0, 1);
            int diferenca = ((percColumn * 100) - this.lstGrupos.ClientSize.Width);

            this.lstGrupos.Columns.Add(ResourceString.CODIGO, percColumn * 20, HorizontalAlignment.Left);
            this.lstGrupos.Columns.Add(ResourceString.DESCRICAO, (percColumn * 80) - diferenca, HorizontalAlignment.Left);
        }

        private void populaLista()
        {
            try
            {
                lista = PersisteGrupo.loadGrupos();
                this.lstGrupos.Items.Clear();
                bool colorGreen = true;
                foreach (Grupo c in lista.getAllGrupos())
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
                    this.lstGrupos.Items.Add(li);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ResourceString.ERROR_BANCO, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void habilitaDesabilitaBotoes(object sender, EventArgs e)
        {
            this.btnIncluir.Enabled = ! this.isGrupoSelecionado;
            this.btnAlterar.Enabled = this.isGrupoSelecionado;
            this.btnExcluir.Enabled = this.isGrupoSelecionado;

            this.btnIncluir.Invalidate();
            this.btnAlterar.Invalidate();
            this.btnExcluir.Invalidate();
        }

        private void lstGrupos_Click(object sender, EventArgs e)
        {
            this.grupoSelecionado = lista.getGrupo(this.lstGrupos.FocusedItem.Index);
            this.txtCodigo.Text = grupoSelecionado.CodigoFormatado;
            this.txtDescricao.Text = grupoSelecionado.Descricao;
            this.isGrupoSelecionado = true;
        }

        private void lstGrupos_SizeChanged(object sender, EventArgs e)
        {
            int percColumn = (int)Math.Round((this.lstGrupos.ClientSize.Width) / 100.0, 1);

            int tamanhoOriginal = this.lstGrupos.ClientSize.Width;
            int acumlaTamanho = 0;
            int index = 0;
            foreach (ColumnHeader he in this.lstGrupos.Columns)
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
            this.lstGrupos.Update();
            Update();
        }

        public void btnFechar_Click(object sender, EventArgs e)
        {
            envento.Invoke(sender, e);
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            string messageInfo = String.Format(ResourceString.QUESTION_ATUALIZAR, this.grupoSelecionado.CodigoFormatado);
            if (MessageBox.Show(messageInfo, ResourceString.ATENCAO, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {


                try
                {
                    this.validaCampos();
                    this.isGrupoSelecionado = false;
                    this.grupoSelecionado.Descricao = this.txtDescricao.Text;

                    this.txtDescricao.Clear();
                    this.txtCodigo.Clear();
                    PersisteGrupo.updateGrupo(this.grupoSelecionado);
                    
                    this.grupoSelecionado = null;
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
            string messageInfo = String.Format(ResourceString.QUESTION_EXCLUIR, this.grupoSelecionado.CodigoFormatado);
            if (MessageBox.Show(messageInfo, ResourceString.ATENCAO, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.isGrupoSelecionado = false;
                this.txtDescricao.Clear();
                this.txtCodigo.Clear();

                try
                {
                    PersisteGrupo.deleteGrupo(this.grupoSelecionado);
                    
                    this.grupoSelecionado = null;
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
                validaCampos();
                this.isGrupoSelecionado = false;
                Grupo grupo = new Grupo();
                grupo.Descricao = this.txtDescricao.Text;
                this.txtDescricao.Clear();
                PersisteGrupo.inserirGrupo(grupo);

                this.grupoSelecionado = null;
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
            this.isGrupoSelecionado = false;
            this.txtDescricao.Clear();
            this.txtCodigo.Clear();
            this.grupoSelecionado = null;
            this.populaLista();
        }

    }
}
