using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp6.lobsterClasses;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtPassword.PasswordChar = '*';
            txtPassword.MaxLength = 15;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            lobsterClass c = new lobsterClass();
            bool enterProg = c.confirmPassword(txtPassword.Text);
            if (enterProg)
            {
                Form2 prog = new Form2();
                this.Hide();
                prog.ShowDialog();
                this.Close();
            } else
            {
                MessageBox.Show("كلمة مرور خاطئة");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
