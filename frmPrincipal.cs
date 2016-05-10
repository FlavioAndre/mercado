using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Mercado.Telas;
using Mercado.Telas.Menus;
using Mercado.Resources;
using Mercado.Util;
using System.Drawing.Drawing2D;

namespace Mercado
{
    public partial class frmPrincipal : Form
    {
        private Color StartColor;
        private Color EndColor;


        public frmPrincipal()
        {
            InitializeComponent();
            selecionaMenu(0);
            conectaBanco();
            /*
               outlookBar1.GradientButtonNormalDark = Color.FromArgb(178, 193, 140);
            outlookBar1.GradientButtonNormalLight = Color.FromArgb(234, 240, 207);
             */
            //this.EndColor = Color.FromArgb(150, 148, 178);
            //this.StartColor = Color.FromArgb(225, 226, 236);

            /*
             *
             *   outlookBar1.GradientButtonNormalDark = Color.FromArgb(126, 166, 225);
            outlookBar1.GradientButtonNormalLight = Color.FromArgb(203, 225, 252);
             * */

            this.EndColor = Color.FromArgb(234, 240, 207);
            this.StartColor = Color.FromArgb(255, 255, 255);
            RepaintControls();
            
        }


        private void conectaBanco()
        {

            string sPath = String.Format(@"{0}\Data\{1}", Application.StartupPath,ResourceString.BANCO);
           // Conexao.Instance.Usuario = ResourceString.USUARIO;
           // Conexao.Instance.Senha = ResourceString.SENHA;
            Conexao.Instance.Banco = sPath;
            /*
            try
            {
                Conexao.Instance.Open();
                this.status.Text = Conexao.Instance.Connection.State.ToString();
            }
            catch (Exception ex)
            {
                this.status.Text = ex.Message.ToString();
            }*/
        }
        

        private void mnuSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void outlookBar1_Load(object sender, EventArgs e)
        {

        }

        private void selecionaMenu(int index)
        {
            switch (index)
            {

                case 1: // movimentações
                    {
                        MenuMovimentacaoUC frm = new MenuMovimentacaoUC();
                        frm.Dock = DockStyle.Fill;
                        frm.Panel = this.splitContainerMenu.Panel2;
                        if (this.splitContainerMenu.Panel1.Controls.Count > 1)
                            this.splitContainerMenu.Panel1.Controls.RemoveAt(1);
                        this.splitContainerMenu.Panel1.Controls.Add(frm);


                    }

                    break;
                case 2: // relatorios
                    {
                        MenuRelatoriosUC frm = new MenuRelatoriosUC();
                        frm.Dock = DockStyle.Fill;
                        frm.Panel = this.splitContainerMenu.Panel2;
                        if (this.splitContainerMenu.Panel1.Controls.Count > 1)
                            this.splitContainerMenu.Panel1.Controls.RemoveAt(1);
                        this.splitContainerMenu.Panel1.Controls.Add(frm);
                    }

                    break;
                default: // cadastros
                    {
                        MenuCadastrosUC frm = new MenuCadastrosUC();
                        frm.Dock = DockStyle.Fill;
                        frm.Panel = this.splitContainerMenu.Panel2;
                        if (this.splitContainerMenu.Panel1.Controls.Count > 1)
                            this.splitContainerMenu.Panel1.Controls.RemoveAt(1);
                        this.splitContainerMenu.Panel1.Controls.Add(frm);
                    }
                    break;

            }   

        }

        private void outlookBar1_Click(object sender, OutlookStyleControls.OutlookBar.ButtonClickEventArgs e)
        {
            selecionaMenu(outlookBar1.Buttons.IndexOf(e.SelectedButton));
        }

        private void paintPane1()
        {
            LinearGradientBrush gradBrush;
            gradBrush = new LinearGradientBrush(new
                            Point(0, 0),
                            new Point(this.splitContainerMenu.Panel1.Width, this.splitContainerMenu.Panel1.Height),
                            this.StartColor,
                            this.EndColor);

            Bitmap bmp = new Bitmap(this.splitContainerMenu.Panel1.Width, this.splitContainerMenu.Panel1.Height);
            Graphics g = Graphics.FromImage(bmp);

            g.FillRectangle(gradBrush, new Rectangle(0, 0, this.splitContainerMenu.Panel1.Width,
                            this.splitContainerMenu.Panel1.Height));

            this.splitContainerMenu.Panel1.BackgroundImage = bmp;
            this.splitContainerMenu.Panel1.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void paintPane2()
        {
            LinearGradientBrush gradBrush;
            gradBrush = new LinearGradientBrush(new
                            Point(0, 0),
                            new Point(this.splitContainerMenu.Panel2.Width, this.splitContainerMenu.Panel2.Height),
                            this.StartColor,
                            this.EndColor);

            Bitmap bmp = new Bitmap(this.splitContainerMenu.Panel2.Width, this.splitContainerMenu.Panel2.Height);
            Graphics g = Graphics.FromImage(bmp);

            g.FillRectangle(gradBrush, new Rectangle(0, 0, this.splitContainerMenu.Panel2.Width,
                            this.splitContainerMenu.Panel2.Height));

            this.splitContainerMenu.Panel2.BackgroundImage = bmp;
            this.splitContainerMenu.Panel2.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void RepaintControls()
        {
            this.EndColor = outlookBar1.GradientButtonNormalLight;
            paintPane1();
            paintPane2();
        }

        private void azulToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            outlookBar1.GradientButtonNormalDark = Color.FromArgb(126, 166, 225);
            outlookBar1.GradientButtonNormalLight = Color.FromArgb(203, 225, 252);
            outlookBar1.Invalidate();
            RepaintControls();
        }

        private void oliviaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            outlookBar1.GradientButtonNormalDark = Color.FromArgb(178, 193, 140);
            outlookBar1.GradientButtonNormalLight = Color.FromArgb(234, 240, 207);
            outlookBar1.Invalidate();
            RepaintControls();

        }

        private void prataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            outlookBar1.GradientButtonNormalDark = Color.FromArgb(150, 148, 178);
            outlookBar1.GradientButtonNormalLight = Color.FromArgb(225, 226, 236);
            outlookBar1.Invalidate();
            RepaintControls();
        }


       

       
      

        

      

        
    }
}