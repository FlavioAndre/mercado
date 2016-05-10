namespace Mercado.Telas.Cadastros
{
    partial class CadUnidadeMedidasUC
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
            this.txtAbreviatura = new System.Windows.Forms.TextBox();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblAbreviatura = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.tplBotoeAcao = new System.Windows.Forms.TableLayoutPanel();
            this.lstUnidadeMedida = new System.Windows.Forms.ListView();
            this.grpLista = new System.Windows.Forms.GroupBox();
            this.tplPrincipal = new System.Windows.Forms.TableLayoutPanel();
            this.tplDados.SuspendLayout();
            this.tplBotoeAcao.SuspendLayout();
            this.grpLista.SuspendLayout();
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
            this.tplDados.Controls.Add(this.txtAbreviatura, 0, 1);
            this.tplDados.Controls.Add(this.lblDescricao, 0, 2);
            this.tplDados.Controls.Add(this.txtDescricao, 1, 2);
            this.tplDados.Controls.Add(this.lblCodigo, 0, 0);
            this.tplDados.Controls.Add(this.txtCodigo, 1, 0);
            this.tplDados.Controls.Add(this.lblAbreviatura, 0, 1);
            this.tplDados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tplDados.Location = new System.Drawing.Point(3, 3);
            this.tplDados.Name = "tplDados";
            this.tplDados.RowCount = 3;
            this.tplDados.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tplDados.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tplDados.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tplDados.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tplDados.Size = new System.Drawing.Size(433, 76);
            this.tplDados.TabIndex = 0;
            // 
            // txtAbreviatura
            // 
            this.txtAbreviatura.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tplDados.SetColumnSpan(this.txtAbreviatura, 2);
            this.txtAbreviatura.Location = new System.Drawing.Point(75, 28);
            this.txtAbreviatura.MaxLength = 3;
            this.txtAbreviatura.Name = "txtAbreviatura";
            this.txtAbreviatura.Size = new System.Drawing.Size(43, 20);
            this.txtAbreviatura.TabIndex = 5;
            // 
            // lblDescricao
            // 
            this.lblDescricao.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(11, 56);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(58, 13);
            this.lblDescricao.TabIndex = 4;
            this.lblDescricao.Text = "Descrição:";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tplDados.SetColumnSpan(this.txtDescricao, 2);
            this.txtDescricao.Location = new System.Drawing.Point(75, 53);
            this.txtDescricao.MaxLength = 15;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(203, 20);
            this.txtDescricao.TabIndex = 3;
            // 
            // lblCodigo
            // 
            this.lblCodigo.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(26, 6);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(43, 13);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Código:";
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
            // lblAbreviatura
            // 
            this.lblAbreviatura.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblAbreviatura.AutoSize = true;
            this.lblAbreviatura.Location = new System.Drawing.Point(5, 31);
            this.lblAbreviatura.Name = "lblAbreviatura";
            this.lblAbreviatura.Size = new System.Drawing.Size(64, 13);
            this.lblAbreviatura.TabIndex = 2;
            this.lblAbreviatura.Text = "Abreviatura:";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLimpar.Location = new System.Drawing.Point(277, 3);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(55, 33);
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
            this.btnFechar.Size = new System.Drawing.Size(55, 33);
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
            this.btnExcluir.Size = new System.Drawing.Size(55, 33);
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
            this.btnAlterar.Size = new System.Drawing.Size(55, 33);
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
            this.btnIncluir.Size = new System.Drawing.Size(55, 33);
            this.btnIncluir.TabIndex = 0;
            this.btnIncluir.Text = "Incluir";
            this.btnIncluir.UseVisualStyleBackColor = true;
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
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
            this.tplBotoeAcao.Location = new System.Drawing.Point(3, 85);
            this.tplBotoeAcao.Name = "tplBotoeAcao";
            this.tplBotoeAcao.RowCount = 1;
            this.tplBotoeAcao.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tplBotoeAcao.Size = new System.Drawing.Size(433, 39);
            this.tplBotoeAcao.TabIndex = 2;
            // 
            // lstUnidadeMedida
            // 
            this.lstUnidadeMedida.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstUnidadeMedida.FullRowSelect = true;
            this.lstUnidadeMedida.Location = new System.Drawing.Point(3, 16);
            this.lstUnidadeMedida.MultiSelect = false;
            this.lstUnidadeMedida.Name = "lstUnidadeMedida";
            this.lstUnidadeMedida.Size = new System.Drawing.Size(427, 293);
            this.lstUnidadeMedida.TabIndex = 1;
            this.lstUnidadeMedida.UseCompatibleStateImageBehavior = false;
            this.lstUnidadeMedida.View = System.Windows.Forms.View.Details;
            this.lstUnidadeMedida.SizeChanged += new System.EventHandler(this.lstUnidadeMedida_SizeChanged);
            this.lstUnidadeMedida.Click += new System.EventHandler(this.lstUnidadeMedida_Click);
            // 
            // grpLista
            // 
            this.grpLista.Controls.Add(this.lstUnidadeMedida);
            this.grpLista.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpLista.Location = new System.Drawing.Point(3, 130);
            this.grpLista.Name = "grpLista";
            this.grpLista.Size = new System.Drawing.Size(433, 312);
            this.grpLista.TabIndex = 1;
            this.grpLista.TabStop = false;
            this.grpLista.Text = "Lista de Unidade de Medida";
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
            this.tplPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 82F));
            this.tplPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tplPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tplPrincipal.Size = new System.Drawing.Size(439, 445);
            this.tplPrincipal.TabIndex = 6;
            // 
            // CadUnidadeMedidasUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.tplPrincipal);
            this.Name = "CadUnidadeMedidasUC";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Size = new System.Drawing.Size(459, 465);
            this.tplDados.ResumeLayout(false);
            this.tplDados.PerformLayout();
            this.tplBotoeAcao.ResumeLayout(false);
            this.grpLista.ResumeLayout(false);
            this.tplPrincipal.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tplDados;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblAbreviatura;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.TableLayoutPanel tplBotoeAcao;
        private System.Windows.Forms.ListView lstUnidadeMedida;
        private System.Windows.Forms.GroupBox grpLista;
        private System.Windows.Forms.TableLayoutPanel tplPrincipal;
        private System.Windows.Forms.TextBox txtAbreviatura;
        private System.Windows.Forms.Label lblDescricao;
    }
}
