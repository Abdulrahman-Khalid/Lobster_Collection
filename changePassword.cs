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
    public partial class changePassword : Form
    {
        public changePassword()
        {
            InitializeComponent();
            adminPass.PasswordChar = '*';
            adminPass.MaxLength = 15;
            currUserPass.PasswordChar = '*';
            currUserPass.MaxLength = 15;
            confirmNewUserPass.PasswordChar = '*';
            confirmNewUserPass.MaxLength = 15;
            newUserPass.PasswordChar = '*';
            newUserPass.MaxLength = 15;
        }

        lobsterClass c = new lobsterClass();

        private void button1_Click(object sender, EventArgs e)
        {
            if (confirmNewUserPass.Text != "")
            {
                if (c.confirmPassword(currUserPass.Text))
                {
                    if (confirmNewUserPass.Text == newUserPass.Text)
                    {
                        if (c.confirmAdminPassword(adminPass.Text))
                        {
                            if (c.updatePassword(confirmNewUserPass.Text))
                            {
                                MessageBox.Show("تم تغيير كلمة المرور بنجاح");

                                Form1 login = new Form1();
                                this.Hide();
                                login.ShowDialog();
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("فشل تغيير كلمة المرور... حاول مرة اخرة");
                            }
                        }
                        else
                        {
                            MessageBox.Show("كلمة مرور الادمن غير صحيحة");
                            adminPass.Text = "";
                        }
                    }
                    else
                    {
                        MessageBox.Show("كلمة المرور الحديثة غير متطابقة مع تأكيد كلمة المرور الحديثة");
                        confirmNewUserPass.Text = "";
                        newUserPass.Text = "";
                    }
                } else
                {
                    MessageBox.Show("كلمة المرور الحالية غير صحيحة");
                    currUserPass.Text = "";
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form2 prog = new Form2();
            this.Hide();
            prog.ShowDialog();
            this.Close();
        }
    }
}
