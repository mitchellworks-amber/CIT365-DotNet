using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk1_1
{
    public partial class AddQuoteView : Form
    {
        public AddQuoteView()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // check all the error providers to make sure
            bool success = true;
            foreach (Control c in this.Controls)
            {
                if (errorProvider1.GetError(c).Length > 0)
                {
                    success = false;
                }
                if (c is ComboBox && string.IsNullOrEmpty(c.Text)) {
                    success = false;
                }
            }

            // okay, display the quote view!
            if (success)
            {
                DisplayQuoteView view = new DisplayQuoteView();
                view.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please fix all errors and submit again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            if (textBox1.Text.Length == 0)
            {
                textBox1.Select(0, textBox1.Text.Length);
                errorProvider1.SetError(textBox1, "Customer name is required.");
            }
            else
            {
                errorProvider1.SetError(textBox1, "");
            }
        }

        private void comboBox1_Leave(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null || comboBox1.GetItemText(comboBox1.SelectedItem).Equals("-"))
            {
                errorProvider1.SetError(comboBox1, "Width is required.");
            }
            else
            {
                errorProvider1.SetError(comboBox1, "");
            }
        }

        private void comboBox2_Leave(object sender, EventArgs e)
        {
            if (comboBox2.SelectedItem == null || comboBox2.GetItemText(comboBox2.SelectedItem).Equals("-"))
            {
                errorProvider1.SetError(comboBox2, "Depth is required.");
            }
            else
            {
                errorProvider1.SetError(comboBox2, "");
            }
        }

        private void comboBox3_Leave(object sender, EventArgs e)
        {
            if (comboBox3.SelectedItem == null || comboBox3.GetItemText(comboBox3.SelectedItem).Equals("-"))
            {
                errorProvider1.SetError(comboBox3, "Drawer Number is required.");
            }
            else
            {
                errorProvider1.SetError(comboBox3, "");
            }
        }

        private void comboBox4_Leave(object sender, EventArgs e)
        {
            if (comboBox4.SelectedItem == null || comboBox4.GetItemText(comboBox4.SelectedItem).Equals("-"))
            {
                errorProvider1.SetError(comboBox4, "Material is required.");
            }
            else
            {
                errorProvider1.SetError(comboBox4, "");
            }
        }

        private void comboBox5_Leave(object sender, EventArgs e)
        {
            if (comboBox5.SelectedItem == null || comboBox5.GetItemText(comboBox5.SelectedItem).Equals("-"))
            {
                errorProvider1.SetError(comboBox5, "Delivery days is required.");
            }
            else
            {
                errorProvider1.SetError(comboBox5, "");
            }
        }
    }
}
