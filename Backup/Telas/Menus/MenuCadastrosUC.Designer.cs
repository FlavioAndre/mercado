namespace Mercado.Telas.Menus
{
    partial class MenuCadastrosUC
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lnkCadLista = new System.Windows.Forms.LinkLabel();
            this.lnkCadMercados = new System.Windows.Forms.LinkLabel();
            this.lnkCadProdutos = new System.Windows.Forms.LinkLabel();
            this.lnkCadGrupos = new System.Windows.Forms.LinkLabel();
            this.lnkCadUnidadeMedida = new System.Windows.Forms.LinkLabel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.lnkCadUnidadeMedida, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.lnkCadLista, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lnkCadMercados, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lnkCadProdutos, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lnkCadGrupos, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(208, 445);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lnkCadLista
            // 
            this.lnkCadLista.AutoSize = true;
            this.lnkCadLista.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lnkCadLista.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lnkCadLista.Location = new System.Drawing.Point(3, 60);
            this.lnkCadLista.Name = "lnkCadLista";
            this.lnkCadLista.Size = new System.Drawing.Size(202, 20);
            this.lnkCadLista.TabIndex = 3;
            this.lnkCadLista.TabStop = true;
            this.lnkCadLista.Text = "Lista de Compras";
            this.lnkCadLista.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lnkCadLista.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkCadLista_LinkClicked);
            // 
            // lnkCadMercados
            // 
            this.lnkCadMercados.AutoSize = true;
            this.lnkCadMercados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lnkCadMercados.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lnkCadMercados.Location = new System.Drawing.Point(3, 40);
            this.lnkCadMercados.Name = "lnkCadMercados";
            this.lnkCadMercados.Size = new System.Drawing.Size(202, 20);
            this.lnkCadMercados.TabIndex = 2;
            this.lnkCadMercados.TabStop = true;
            this.lnkCadMercados.Text = "Supermercados";
            this.lnkCadMercados.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lnkCadMercados.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkCadMercados_LinkClicked);
            // 
            // lnkCadProdutos
            // 
            this.lnkCadProdutos.AutoSize = true;
            this.lnkCadProdutos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lnkCadProdutos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lnkCadProdutos.Location = new System.Drawing.Point(3, 20);
            this.lnkCadProdutos.Name = "lnkCadProdutos";
            this.lnkCadProdutos.Size = new System.Drawing.Size(202, 20);
            this.lnkCadProdutos.TabIndex = 1;
            this.lnkCadProdutos.TabStop = true;
            this.lnkCadProdutos.Text = "Produtos";
            this.lnkCadProdutos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lnkCadProdutos.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkCadProdutos_LinkClicked);
            // 
            // lnkCadGrupos
            // 
            this.lnkCadGrupos.AutoSize = true;
            this.lnkCadGrupos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lnkCadGrupos.Location = new System.Drawing.Point(3, 0);
            this.lnkCadGrupos.Name = "lnkCadGrupos";
            this.lnkCadGrupos.Size = new System.Drawing.Size(202, 20);
            this.lnkCadGrupos.TabIndex = 0;
            this.lnkCadGrupos.TabStop = true;
            this.lnkCadGrupos.Text = "Grupos";
            this.lnkCadGrupos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lnkCadGrupos.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkCadGrupos_LinkClicked);
            // 
            // lnkCadUnidadeMedida
            // 
            this.lnkCadUnidadeMedida.AutoSize = true;
            this.lnkCadUnidadeMedida.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lnkCadUnidadeMedida.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lnkCadUnidadeMedida.Location = new System.Drawing.Point(3, 80);
            this.lnkCadUnidadeMedida.Name = "lnkCadUnidadeMedida";
            this.lnkCadUnidadeMedida.Size = new System.Drawing.Size(202, 20);
            this.lnkCadUnidadeMedida.TabIndex = 4;
            this.lnkCadUnidadeMedida.TabStop = true;
            this.lnkCadUnidadeMedida.Text = "Unidade de Medida";
            this.lnkCadUnidadeMedida.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lnkCadUnidadeMedida.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkCadUnidadeMedida_LinkClicked);
            // 
            // MenuCadastrosUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "MenuCadastrosUC";
            this.Size = new System.Drawing.Size(208, 445);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.LinkLabel lnkCadGrupos;
        private System.Windows.Forms.LinkLabel lnkCadProdutos;
        private System.Windows.Forms.LinkLabel lnkCadMercados;
        private System.Windows.Forms.LinkLabel lnkCadLista;
        private System.Windows.Forms.LinkLabel lnkCadUnidadeMedida;
    }
}
