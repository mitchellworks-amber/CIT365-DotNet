using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk
{
    public partial class AddQuoteView : Form
    {
        public AddQuoteView()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DisplayQuoteView view = new DisplayQuoteView();
            view.ShowDialog();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
