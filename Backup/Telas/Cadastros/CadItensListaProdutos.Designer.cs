namespace Mercado.Telas.Cadastros
{
    partial class CadItensListaProdutos
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tblMain = new System.Windows.Forms.TableLayoutPanel();
            this.tblDadosLista = new System.Windows.Forms.TableLayoutPanel();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.grpProdutos = new System.Windows.Forms.GroupBox();
            this.dtGridView = new System.Windows.Forms.DataGridView();
            this.tblBotoes = new System.Windows.Forms.TableLayoutPanel();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tblMain.SuspendLayout();
            this.tblDadosLista.SuspendLayout();
            this.grpProdutos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridView)).BeginInit();
            this.tblBotoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblMain
            // 
            this.tblMain.ColumnCount = 1;
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblMain.Controls.Add(this.tblDadosLista, 0, 0);
            this.tblMain.Controls.Add(this.grpProdutos, 0, 1);
            this.tblMain.Controls.Add(this.tblBotoes, 0, 2);
            this.tblMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblMain.Location = new System.Drawing.Point(0, 0);
            this.tblMain.Name = "tblMain";
            this.tblMain.RowCount = 3;
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 59F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tblMain.Size = new System.Drawing.Size(658, 602);
            this.tblMain.TabIndex = 0;
            // 
            // tblDadosLista
            // 
            this.tblDadosLista.ColumnCount = 2;
            this.tblDadosLista.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.64706F));
            this.tblDadosLista.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 82.35294F));
            this.tblDadosLista.Controls.Add(this.lblCodigo, 0, 0);
            this.tblDadosLista.Controls.Add(this.txtCodigo, 1, 0);
            this.tblDadosLista.Controls.Add(this.lblDescricao, 0, 1);
            this.tblDadosLista.Controls.Add(this.txtDescricao, 1, 1);
            this.tblDadosLista.Dock = System.Windows.Forms.DockStyle.Top;
            this.tblDadosLista.Location = new System.Drawing.Point(3, 3);
            this.tblDadosLista.Name = "tblDadosLista";
            this.tblDadosLista.RowCount = 2;
            this.tblDadosLista.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tblDadosLista.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tblDadosLista.Size = new System.Drawing.Size(652, 53);
            this.tblDadosLista.TabIndex = 0;
            // 
            // lblCodigo
            // 
            this.lblCodigo.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(69, 6);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(43, 13);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Código:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtCodigo.Location = new System.Drawing.Point(118, 3);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(53, 20);
            this.txtCodigo.TabIndex = 1;
            // 
            // lblDescricao
            // 
            this.lblDescricao.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(54, 32);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(58, 13);
            this.lblDescricao.TabIndex = 2;
            this.lblDescricao.Text = "Descrição:";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(118, 28);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.ReadOnly = true;
            this.txtDescricao.Size = new System.Drawing.Size(303, 20);
            this.txtDescricao.TabIndex = 3;
            // 
            // grpProdutos
            // 
            this.grpProdutos.Controls.Add(this.dtGridView);
            this.grpProdutos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpProdutos.Location = new System.Drawing.Point(3, 62);
            this.grpProdutos.Name = "grpProdutos";
            this.grpProdutos.Size = new System.Drawing.Size(652, 500);
            this.grpProdutos.TabIndex = 1;
            this.grpProdutos.TabStop = false;
            this.grpProdutos.Text = "Selecione os Produtos";
            // 
            // dtGridView
            // 
            this.dtGridView.AllowUserToAddRows = false;
            this.dtGridView.AllowUserToDeleteRows = false;
            this.dtGridView.AllowUserToOrderColumns = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtGridView.DefaultCellStyle = dataGridViewCellStyle4;
            this.dtGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtGridView.Location = new System.Drawing.Point(3, 16);
            this.dtGridView.Name = "dtGridView";
            this.dtGridView.ReadOnly = true;
            this.dtGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dtGridView.Size = new System.Drawing.Size(646, 481);
            this.dtGridView.TabIndex = 0;
            this.dtGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGridView_CellDoubleClick);
            this.dtGridView.SizeChanged += new System.EventHandler(this.dtGridView_SizeChanged);
            // 
            // tblBotoes
            // 
            this.tblBotoes.ColumnCount = 3;
            this.tblBotoes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblBotoes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 88F));
            this.tblBotoes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 88F));
            this.tblBotoes.Controls.Add(this.btnOK, 1, 0);
            this.tblBotoes.Controls.Add(this.btnCancel, 2, 0);
            this.tblBotoes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblBotoes.Location = new System.Drawing.Point(3, 568);
            this.tblBotoes.Name = "tblBotoes";
            this.tblBotoes.RowCount = 1;
            this.tblBotoes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblBotoes.Size = new System.Drawing.Size(652, 31);
            this.tblBotoes.TabIndex = 2;
            // 
            // btnOK
            // 
            this.btnOK.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnOK.Image = global::Mercado.Properties.Resources.adicionar1;
            this.btnOK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOK.Location = new System.Drawing.Point(479, 3);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(82, 25);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCancel.Image = global::Mercado.Properties.Resources.excluir;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(567, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(82, 25);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // CadItensListaProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 602);
            this.Controls.Add(this.tblMain);
            this.Name = "CadItensListaProdutos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Incluir Produtos na Lista";
            this.Load += new System.EventHandler(this.CadItensListaProdutos_Load);
            this.tblMain.ResumeLayout(false);
            this.tblDadosLista.ResumeLayout(false);
            this.tblDadosLista.PerformLayout();
            this.grpProdutos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridView)).EndInit();
            this.tblBotoes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblMain;
        private System.Windows.Forms.TableLayoutPanel tblDadosLista;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.GroupBox grpProdutos;
        private System.Windows.Forms.TableLayoutPanel tblBotoes;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DataGridView dtGridView;
    }
}