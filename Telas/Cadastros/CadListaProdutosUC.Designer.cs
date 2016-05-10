namespace Mercado.Telas.Cadastros
{
    partial class CadListaProdutosUC
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadListaProdutosUC));
            this.tblMain = new System.Windows.Forms.TableLayoutPanel();
            this.tplPrincipal = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtDescLista = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.grpLista = new System.Windows.Forms.GroupBox();
            this.lstListaCriadas = new System.Windows.Forms.ListView();
            this.tplBotoeAcao = new System.Windows.Forms.TableLayoutPanel();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.tblListaItens = new System.Windows.Forms.TableLayoutPanel();
            this.lstProdutos = new System.Windows.Forms.ListView();
            this.tspMenuLista = new System.Windows.Forms.ToolStrip();
            this.btnExcluirItens = new System.Windows.Forms.ToolStripButton();
            this.btnIncluirItens = new System.Windows.Forms.ToolStripButton();
            this.btnItensImprir = new System.Windows.Forms.ToolStripButton();
            this.tplDados = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tblMain.SuspendLayout();
            this.tplPrincipal.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.grpLista.SuspendLayout();
            this.tplBotoeAcao.SuspendLayout();
            this.tblListaItens.SuspendLayout();
            this.tspMenuLista.SuspendLayout();
            this.tplDados.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblMain
            // 
            this.tblMain.ColumnCount = 1;
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblMain.Controls.Add(this.tplPrincipal, 0, 0);
            this.tblMain.Controls.Add(this.tblListaItens, 0, 1);
            this.tblMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblMain.Location = new System.Drawing.Point(10, 10);
            this.tblMain.Name = "tblMain";
            this.tblMain.RowCount = 2;
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblMain.Size = new System.Drawing.Size(617, 522);
            this.tblMain.TabIndex = 0;
            // 
            // tplPrincipal
            // 
            this.tplPrincipal.AutoSize = true;
            this.tplPrincipal.ColumnCount = 1;
            this.tplPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tplPrincipal.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.tplPrincipal.Controls.Add(this.grpLista, 0, 2);
            this.tplPrincipal.Controls.Add(this.tplBotoeAcao, 0, 1);
            this.tplPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tplPrincipal.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tplPrincipal.Location = new System.Drawing.Point(3, 3);
            this.tplPrincipal.Name = "tplPrincipal";
            this.tplPrincipal.RowCount = 3;
            this.tplPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tplPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tplPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tplPrincipal.Size = new System.Drawing.Size(611, 255);
            this.tplPrincipal.TabIndex = 6;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 72F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 169F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.txtDescLista, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtCodigo, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(605, 49);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // txtDescLista
            // 
            this.txtDescLista.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tableLayoutPanel1.SetColumnSpan(this.txtDescLista, 2);
            this.txtDescLista.Location = new System.Drawing.Point(75, 27);
            this.txtDescLista.Name = "txtDescLista";
            this.txtDescLista.Size = new System.Drawing.Size(212, 20);
            this.txtDescLista.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Código:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Descrição:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtCodigo.Location = new System.Drawing.Point(75, 3);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(43, 20);
            this.txtCodigo.TabIndex = 1;
            // 
            // grpLista
            // 
            this.grpLista.Controls.Add(this.lstListaCriadas);
            this.grpLista.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpLista.Location = new System.Drawing.Point(3, 93);
            this.grpLista.Name = "grpLista";
            this.grpLista.Size = new System.Drawing.Size(605, 159);
            this.grpLista.TabIndex = 1;
            this.grpLista.TabStop = false;
            this.grpLista.Text = "Lista criadas";
            // 
            // lstListaCriadas
            // 
            this.lstListaCriadas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstListaCriadas.FullRowSelect = true;
            this.lstListaCriadas.Location = new System.Drawing.Point(3, 16);
            this.lstListaCriadas.MultiSelect = false;
            this.lstListaCriadas.Name = "lstListaCriadas";
            this.lstListaCriadas.Size = new System.Drawing.Size(599, 140);
            this.lstListaCriadas.TabIndex = 1;
            this.lstListaCriadas.UseCompatibleStateImageBehavior = false;
            this.lstListaCriadas.View = System.Windows.Forms.View.Details;
            this.lstListaCriadas.SizeChanged += new System.EventHandler(this.lstListaCriadas_SizeChanged);
            this.lstListaCriadas.Click += new System.EventHandler(this.lstListaCriadas_Click);
            // 
            // tplBotoeAcao
            // 
            this.tplBotoeAcao.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tplBotoeAcao.ColumnCount = 8;
            this.tplBotoeAcao.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.130713F));
            this.tplBotoeAcao.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.29F));
            this.tplBotoeAcao.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.29F));
            this.tplBotoeAcao.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.29F));
            this.tplBotoeAcao.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.29F));
            this.tplBotoeAcao.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.29F));
            this.tplBotoeAcao.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.2881F));
            this.tplBotoeAcao.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.131192F));
            this.tplBotoeAcao.Controls.Add(this.btnLimpar, 5, 0);
            this.tplBotoeAcao.Controls.Add(this.btnFechar, 6, 0);
            this.tplBotoeAcao.Controls.Add(this.btnExcluir, 3, 0);
            this.tplBotoeAcao.Controls.Add(this.btnAlterar, 2, 0);
            this.tplBotoeAcao.Controls.Add(this.btnIncluir, 1, 0);
            this.tplBotoeAcao.Location = new System.Drawing.Point(3, 58);
            this.tplBotoeAcao.Name = "tplBotoeAcao";
            this.tplBotoeAcao.RowCount = 1;
            this.tplBotoeAcao.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tplBotoeAcao.Size = new System.Drawing.Size(605, 29);
            this.tplBotoeAcao.TabIndex = 2;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLimpar.Location = new System.Drawing.Point(390, 3);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(80, 23);
            this.btnLimpar.TabIndex = 4;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnFechar.Location = new System.Drawing.Point(476, 3);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(80, 23);
            this.btnFechar.TabIndex = 3;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnExcluir.Enabled = false;
            this.btnExcluir.Location = new System.Drawing.Point(218, 3);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(80, 23);
            this.btnExcluir.TabIndex = 2;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAlterar.Enabled = false;
            this.btnAlterar.Location = new System.Drawing.Point(132, 3);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(80, 23);
            this.btnAlterar.TabIndex = 1;
            this.btnAlterar.Text = "Atualizar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnIncluir
            // 
            this.btnIncluir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnIncluir.Location = new System.Drawing.Point(46, 3);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(80, 23);
            this.btnIncluir.TabIndex = 0;
            this.btnIncluir.Text = "Incluir";
            this.btnIncluir.UseVisualStyleBackColor = true;
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // tblListaItens
            // 
            this.tblListaItens.ColumnCount = 1;
            this.tblListaItens.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblListaItens.Controls.Add(this.lstProdutos, 0, 1);
            this.tblListaItens.Controls.Add(this.tspMenuLista, 0, 0);
            this.tblListaItens.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblListaItens.Location = new System.Drawing.Point(3, 264);
            this.tblListaItens.Name = "tblListaItens";
            this.tblListaItens.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tblListaItens.RowCount = 2;
            this.tblListaItens.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tblListaItens.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblListaItens.Size = new System.Drawing.Size(611, 255);
            this.tblListaItens.TabIndex = 0;
            // 
            // lstProdutos
            // 
            this.lstProdutos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstProdutos.FullRowSelect = true;
            this.lstProdutos.Location = new System.Drawing.Point(3, 28);
            this.lstProdutos.MultiSelect = false;
            this.lstProdutos.Name = "lstProdutos";
            this.lstProdutos.Size = new System.Drawing.Size(605, 224);
            this.lstProdutos.TabIndex = 2;
            this.lstProdutos.UseCompatibleStateImageBehavior = false;
            this.lstProdutos.View = System.Windows.Forms.View.Details;
            this.lstProdutos.SelectedIndexChanged += new System.EventHandler(this.lstProdutos_SelectedIndexChanged);
            this.lstProdutos.SizeChanged += new System.EventHandler(this.lstProdutos_SizeChanged);
            this.lstProdutos.Click += new System.EventHandler(this.lstProdutos_Click);
            // 
            // tspMenuLista
            // 
            this.tspMenuLista.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tspMenuLista.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnExcluirItens,
            this.btnIncluirItens,
            this.btnItensImprir});
            this.tspMenuLista.Location = new System.Drawing.Point(0, 0);
            this.tspMenuLista.Name = "tspMenuLista";
            this.tspMenuLista.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tspMenuLista.Size = new System.Drawing.Size(611, 25);
            this.tspMenuLista.TabIndex = 0;
            // 
            // btnExcluirItens
            // 
            this.btnExcluirItens.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnExcluirItens.Enabled = false;
            this.btnExcluirItens.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluirItens.Image")));
            this.btnExcluirItens.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExcluirItens.Name = "btnExcluirItens";
            this.btnExcluirItens.Size = new System.Drawing.Size(23, 22);
            this.btnExcluirItens.Text = "Excluir produto da lista";
            this.btnExcluirItens.Click += new System.EventHandler(this.btnExcluirItens_Click);
            // 
            // btnIncluirItens
            // 
            this.btnIncluirItens.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnIncluirItens.Enabled = false;
            this.btnIncluirItens.Image = ((System.Drawing.Image)(resources.GetObject("btnIncluirItens.Image")));
            this.btnIncluirItens.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnIncluirItens.Name = "btnIncluirItens";
            this.btnIncluirItens.Size = new System.Drawing.Size(23, 22);
            this.btnIncluirItens.Text = "Incluir produtos na lista de compra";
            this.btnIncluirItens.Click += new System.EventHandler(this.btnIncluirItens_Click);
            // 
            // btnItensImprir
            // 
            this.btnItensImprir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnItensImprir.Image = ((System.Drawing.Image)(resources.GetObject("btnItensImprir.Image")));
            this.btnItensImprir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnItensImprir.Name = "btnItensImprir";
            this.btnItensImprir.Size = new System.Drawing.Size(23, 22);
            this.btnItensImprir.Text = "Imprime os itens cadastrado na lista";
            this.btnItensImprir.Click += new System.EventHandler(this.btnItensImprir_Click);
            // 
            // tplDados
            // 
            this.tplDados.ColumnCount = 4;
            this.tplDados.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 72F));
            this.tplDados.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tplDados.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160F));
            this.tplDados.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tplDados.Controls.Add(this.label1, 0, 0);
            this.tplDados.Location = new System.Drawing.Point(0, 0);
            this.tplDados.Name = "tplDados";
            this.tplDados.RowCount = 2;
            this.tplDados.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tplDados.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tplDados.Size = new System.Drawing.Size(200, 100);
            this.tplDados.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 7);
            this.label2.TabIndex = 2;
            this.label2.Text = "Descrição:";
            // 
            // reportViewer1
            // 
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Remote;
            this.reportViewer1.Size = new System.Drawing.Size(400, 250);
            this.reportViewer1.TabIndex = 0;
            // 
            // CadListaProdutosUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.tblMain);
            this.Name = "CadListaProdutosUC";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Size = new System.Drawing.Size(637, 542);
            this.tblMain.ResumeLayout(false);
            this.tblMain.PerformLayout();
            this.tplPrincipal.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.grpLista.ResumeLayout(false);
            this.tplBotoeAcao.ResumeLayout(false);
            this.tblListaItens.ResumeLayout(false);
            this.tblListaItens.PerformLayout();
            this.tspMenuLista.ResumeLayout(false);
            this.tspMenuLista.PerformLayout();
            this.tplDados.ResumeLayout(false);
            this.tplDados.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblMain;
        private System.Windows.Forms.TableLayoutPanel tblListaItens;
        private System.Windows.Forms.ToolStrip tspMenuLista;
        private System.Windows.Forms.ListView lstProdutos;
        private System.Windows.Forms.TableLayoutPanel tplDados;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tplPrincipal;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox txtDescLista;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.GroupBox grpLista;
        private System.Windows.Forms.ListView lstListaCriadas;
        private System.Windows.Forms.TableLayoutPanel tplBotoeAcao;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.ToolStripButton btnExcluirItens;
        private System.Windows.Forms.ToolStripButton btnIncluirItens;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.ToolStripButton btnItensImprir;
    }
}
