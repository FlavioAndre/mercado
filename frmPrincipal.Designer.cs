namespace Mercado
{
    partial class frmPrincipal
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
            OutlookStyleControls.OutlookBarButton outlookBarButton1 = new OutlookStyleControls.OutlookBarButton();
            OutlookStyleControls.OutlookBarButton outlookBarButton2 = new OutlookStyleControls.OutlookBarButton();
            OutlookStyleControls.OutlookBarButton outlookBarButton3 = new OutlookStyleControls.OutlookBarButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.status = new System.Windows.Forms.ToolStripStatusLabel();
            this.splitContainerMenu = new System.Windows.Forms.SplitContainer();
            this.outlookBar1 = new OutlookStyleControls.OutlookBar();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuColorMain = new System.Windows.Forms.ToolStripMenuItem();
            this.azulToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oliviaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1.SuspendLayout();
            this.splitContainerMenu.Panel1.SuspendLayout();
            this.splitContainerMenu.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.status});
            this.statusStrip1.Location = new System.Drawing.Point(0, 485);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(896, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // status
            // 
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(0, 17);
            // 
            // splitContainerMenu
            // 
            this.splitContainerMenu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainerMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerMenu.IsSplitterFixed = true;
            this.splitContainerMenu.Location = new System.Drawing.Point(0, 24);
            this.splitContainerMenu.Name = "splitContainerMenu";
            // 
            // splitContainerMenu.Panel1
            // 
            this.splitContainerMenu.Panel1.BackColor = System.Drawing.Color.White;
            this.splitContainerMenu.Panel1.Controls.Add(this.outlookBar1);
            // 
            // splitContainerMenu.Panel2
            // 
            this.splitContainerMenu.Panel2.BackColor = System.Drawing.Color.White;
            this.splitContainerMenu.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.splitContainerMenu.Size = new System.Drawing.Size(896, 461);
            this.splitContainerMenu.SplitterDistance = 201;
            this.splitContainerMenu.TabIndex = 3;
            // 
            // outlookBar1
            // 
            this.outlookBar1.BackColor = System.Drawing.SystemColors.Highlight;
            this.outlookBar1.ButtonHeight = 30;
            outlookBarButton1.Enabled = true;
            outlookBarButton1.Image = global::Mercado.Properties.Resources.Cadastros;
            outlookBarButton1.Tag = null;
            outlookBarButton1.Text = "Cadastros";
            outlookBarButton2.Enabled = true;
            outlookBarButton2.Image = global::Mercado.Properties.Resources.Movimentacao;
            outlookBarButton2.Tag = null;
            outlookBarButton2.Text = "Movimentações";
            outlookBarButton3.Enabled = true;
            outlookBarButton3.Image = global::Mercado.Properties.Resources.Relatorios;
            outlookBarButton3.Tag = null;
            outlookBarButton3.Text = "Relatórios";
            this.outlookBar1.Buttons.Add(outlookBarButton1);
            this.outlookBar1.Buttons.Add(outlookBarButton2);
            this.outlookBar1.Buttons.Add(outlookBarButton3);
            this.outlookBar1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.outlookBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.outlookBar1.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.outlookBar1.GradientButtonHoverDark = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(192)))), ((int)(((byte)(91)))));
            this.outlookBar1.GradientButtonHoverLight = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(220)))));
            this.outlookBar1.GradientButtonNormalDark = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(193)))), ((int)(((byte)(140)))));
            this.outlookBar1.GradientButtonNormalLight = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(240)))), ((int)(((byte)(207)))));
            this.outlookBar1.GradientButtonSelectedDark = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(150)))), ((int)(((byte)(21)))));
            this.outlookBar1.GradientButtonSelectedLight = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(230)))), ((int)(((byte)(148)))));
            this.outlookBar1.Location = new System.Drawing.Point(0, 305);
            this.outlookBar1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.outlookBar1.Name = "outlookBar1";
            this.outlookBar1.SelectedButton = outlookBarButton1;
            this.outlookBar1.Size = new System.Drawing.Size(197, 152);
            this.outlookBar1.TabIndex = 0;
            this.outlookBar1.Click += new OutlookStyleControls.OutlookBar.ButtonClickEventHandler(this.outlookBar1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuColorMain});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(896, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuColorMain
            // 
            this.mnuColorMain.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.azulToolStripMenuItem,
            this.oliviaToolStripMenuItem,
            this.prataToolStripMenuItem});
            this.mnuColorMain.Name = "mnuColorMain";
            this.mnuColorMain.Size = new System.Drawing.Size(44, 20);
            this.mnuColorMain.Text = "Color";
            // 
            // azulToolStripMenuItem
            // 
            this.azulToolStripMenuItem.Name = "azulToolStripMenuItem";
            this.azulToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.azulToolStripMenuItem.Text = "Azul";
            this.azulToolStripMenuItem.Click += new System.EventHandler(this.azulToolStripMenuItem_Click);
            // 
            // oliviaToolStripMenuItem
            // 
            this.oliviaToolStripMenuItem.Name = "oliviaToolStripMenuItem";
            this.oliviaToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.oliviaToolStripMenuItem.Text = "Olivia";
            this.oliviaToolStripMenuItem.Click += new System.EventHandler(this.oliviaToolStripMenuItem_Click);
            // 
            // prataToolStripMenuItem
            // 
            this.prataToolStripMenuItem.Name = "prataToolStripMenuItem";
            this.prataToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.prataToolStripMenuItem.Text = "Prata";
            this.prataToolStripMenuItem.Click += new System.EventHandler(this.prataToolStripMenuItem_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 507);
            this.Controls.Add(this.splitContainerMenu);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de Supermercado";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.splitContainerMenu.Panel1.ResumeLayout(false);
            this.splitContainerMenu.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.SplitContainer splitContainerMenu;
        private OutlookStyleControls.OutlookBar outlookBar1;
        private System.Windows.Forms.ToolStripStatusLabel status;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuColorMain;
        private System.Windows.Forms.ToolStripMenuItem azulToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oliviaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prataToolStripMenuItem;
    }
}

