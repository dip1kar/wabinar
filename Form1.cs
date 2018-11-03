using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Barcode2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string UserName = "Rupshikha";
            string PassWord = "12345";
            if (UserName == textBox1.Text && PassWord == textBox2.Text)

            {

               // MessageBox.Show("Login successfully....!");
                Form2 frm = new Form2();
                frm.Show();

            }

            else
            {
                MessageBox.Show("Please enter vaild UserName");
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
