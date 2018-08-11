using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeyCrackTest1
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        public void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public void button2_Click(object sender, EventArgs e)
        {
            string password = null;
            string right_password = "123456";
            password = textBox1.Text;
            if (password!=right_password)
            {
                ThirdForm dialog = new ThirdForm(this);
                dialog.ShowDialog();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SecondForm dialog = new SecondForm(this);
            dialog.ShowDialog();
        }
    }
}
