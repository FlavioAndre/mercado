using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace Mercado.Telas.Menus
{
    public partial class MenuMovimentacaoUC : UserControl
    {
        private SplitterPanel panel;

        public SplitterPanel Panel
        {
            get { return panel; }
            set { panel = value; }
        }

        public MenuMovimentacaoUC()
        {
            InitializeComponent();
        }
    }
}
