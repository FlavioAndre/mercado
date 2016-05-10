namespace Mercado.Telas.Cadastros
{
    partial class CadGruposUC
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
            this.tplDados = new System.Windows.Forms.TableLayoutPanel();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.grpLista = new System.Windows.Forms.GroupBox();
            this.lstGrupos = new System.Windows.Forms.ListView();
            this.tplBotoeAcao = new System.Windows.Forms.TableLayoutPanel();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.tplPrincipal = new System.Windows.Forms.TableLayoutPanel();
            this.tplDados.SuspendLayout();
            this.grpLista.SuspendLayout();
            this.tplBotoeAcao.SuspendLayout();
            this.tplPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // tplDados
            // 
            this.tplDados.ColumnCount = 4;
            this.tplDados.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 72F));
            this.tplDados.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tplDados.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160F));
            this.tplDados.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tplDados.Controls.Add(this.txtDescricao, 1, 1);
            this.tplDados.Controls.Add(this.label1, 0, 0);
            this.tplDados.Controls.Add(this.label2, 0, 1);
            this.tplDados.Controls.Add(this.txtCodigo, 1, 0);
            this.tplDados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tplDados.Location = new System.Drawing.Point(3, 3);
            this.tplDados.Name = "tplDados";
            this.tplDados.RowCount = 2;
            this.tplDados.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tplDados.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tplDados.Size = new System.Drawing.Size(433, 49);
            this.tplDados.TabIndex = 0;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tplDados.SetColumnSpan(this.txtDescricao, 2);
            this.txtDescricao.Location = new System.Drawing.Point(75, 27);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(203, 20);
            this.txtDescricao.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Descrição:";
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
            this.grpLista.Controls.Add(this.lstGrupos);
            this.grpLista.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpLista.Location = new System.Drawing.Point(3, 93);
            this.grpLista.Name = "grpLista";
            this.grpLista.Size = new System.Drawing.Size(433, 349);
            this.grpLista.TabIndex = 1;
            this.grpLista.TabStop = false;
            this.grpLista.Text = "Lista de Grupos";
            // 
            // lstGrupos
            // 
            this.lstGrupos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstGrupos.FullRowSelect = true;
            this.lstGrupos.Location = new System.Drawing.Point(3, 16);
            this.lstGrupos.MultiSelect = false;
            this.lstGrupos.Name = "lstGrupos";
            this.lstGrupos.Size = new System.Drawing.Size(427, 330);
            this.lstGrupos.TabIndex = 1;
            this.lstGrupos.UseCompatibleStateImageBehavior = false;
            this.lstGrupos.View = System.Windows.Forms.View.Details;
            this.lstGrupos.SizeChanged += new System.EventHandler(this.lstGrupos_SizeChanged);
            this.lstGrupos.Click += new System.EventHandler(this.lstGrupos_Click);
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
            this.tplBotoeAcao.Size = new System.Drawing.Size(433, 29);
            this.tplBotoeAcao.TabIndex = 2;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLimpar.Location = new System.Drawing.Point(277, 3);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(55, 23);
            this.btnLimpar.TabIndex = 4;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnFechar.Location = new System.Drawing.Point(338, 3);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(55, 23);
            this.btnFechar.TabIndex = 3;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnExcluir.Enabled = false;
            this.btnExcluir.Location = new System.Drawing.Point(155, 3);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(55, 23);
            this.btnExcluir.TabIndex = 2;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAlterar.Enabled = false;
            this.btnAlterar.Location = new System.Drawing.Point(94, 3);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(55, 23);
            this.btnAlterar.TabIndex = 1;
            this.btnAlterar.Text = "Atualizar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnIncluir
            // 
            this.btnIncluir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnIncluir.Location = new System.Drawing.Point(33, 3);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(55, 23);
            this.btnIncluir.TabIndex = 0;
            this.btnIncluir.Text = "Incluir";
            this.btnIncluir.UseVisualStyleBackColor = true;
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // tplPrincipal
            // 
            this.tplPrincipal.AutoSize = true;
            this.tplPrincipal.ColumnCount = 1;
            this.tplPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tplPrincipal.Controls.Add(this.tplDados, 0, 0);
            this.tplPrincipal.Controls.Add(this.grpLista, 0, 2);
            this.tplPrincipal.Controls.Add(this.tplBotoeAcao, 0, 1);
            this.tplPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tplPrincipal.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tplPrincipal.Location = new System.Drawing.Point(10, 10);
            this.tplPrincipal.Name = "tplPrincipal";
            this.tplPrincipal.RowCount = 3;
            this.tplPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tplPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tplPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tplPrincipal.Size = new System.Drawing.Size(439, 445);
            this.tplPrincipal.TabIndex = 5;
            // 
            // CadGruposUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.tplPrincipal);
            this.Name = "CadGruposUC";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Size = new System.Drawing.Size(459, 465);
            this.tplDados.ResumeLayout(false);
            this.tplDados.PerformLayout();
            this.grpLista.ResumeLayout(false);
            this.tplBotoeAcao.ResumeLayout(false);
            this.tplPrincipal.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tplDados;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.GroupBox grpLista;
        private System.Windows.Forms.TableLayoutPanel tplBotoeAcao;
        private System.Windows.Forms.TableLayoutPanel tplPrincipal;
        private System.Windows.Forms.ListView lstGrupos;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnLimpar;

        
    }
}
