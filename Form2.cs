using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp6.lobsterClasses;

namespace WindowsFormsApp6
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        lobsterClass c = new lobsterClass();
        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            changePassword changePass = new changePassword();
            this.Hide();
            changePass.ShowDialog();
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            DataTable dt = c.select();
            showList.DataSource = dt;
            dt = c.calcSum();
            dataSUM.DataSource = dt;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtBoxCompanyName.Text != "" && numericQuantity.Value != 0 && numericPrice.Value != 0 && numericId.Value != 0 && txtCountry.Text != "")
            {
                c.companyName = txtBoxCompanyName.Text;
                c.quantity = Convert.ToInt64(numericQuantity.Value);
                c.price = Convert.ToInt64(numericPrice.Value);
                c.id = numericId.Value.ToString();
                c.date = datePicker.Value.ToString("yyyy-MM-dd");
                c.country = txtCountry.Text;
                bool success = c.insert(c);
                if (success)
                {
                    MessageBox.Show("تم اضافة عنصر جديد بنجاح");
                    DataTable dt = c.select();
                    showList.DataSource = dt;
                    dt = c.calcSum();
                    dataSUM.DataSource = dt;

                    txtBoxCompanyName.Text = "";
                    numericQuantity.Value = 0;
                    numericPrice.Value = 0;
                    numericId.Value = 0;
                    txtCountry.Text = "";
                }
                else
                {
                    MessageBox.Show("فشل في الاضافة, حاول مرة اخرى");
                }
            }
            else
            {
                MessageBox.Show("يوجد خانة فارغة او تحتوي على الرقم صفر, فشل فالاضافة");
            }
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {

        }

        private void showList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void clear()
        {
            txtBoxCompanyName.Text = "";
            numericQuantity.Value = 0;
            numericPrice.Value = 0;
            numericId.Value = 0;
            datePicker.Value = DateTime.Today;
            txtCountry.Text = "";
        }

        private void showList_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            txtBoxCompanyName.Text = showList.Rows[rowIndex].Cells[0].Value.ToString();
            numericQuantity.Value = (long)showList.Rows[rowIndex].Cells[1].Value;
            numericPrice.Value = (long)showList.Rows[rowIndex].Cells[2].Value;
            numericId.Value = (long)showList.Rows[rowIndex].Cells[3].Value;
            string d = showList.Rows[rowIndex].Cells[4].Value.ToString();
            datePicker.Value = DateTime.ParseExact(d, "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);
            txtCountry.Text = showList.Rows[rowIndex].Cells[5].Value.ToString();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            if (txtBoxCompanyName.Text != "" && numericQuantity.Value != 0 && numericPrice.Value != 0 && numericId.Value != 0 && txtCountry.Text != "")
            {
                c.companyName = txtBoxCompanyName.Text;
                c.quantity = Convert.ToInt64(numericQuantity.Value);
                c.price = Convert.ToInt64(numericPrice.Value);
                c.id = numericId.Value.ToString();
                c.date = datePicker.Value.ToString("yyyy-MM-dd");
                c.country = txtCountry.Text;
                bool success = c.update(c);
                if (success)
                {
                    MessageBox.Show("تم تحديث عنصر بنجاح");
                    DataTable dt = c.select();
                    showList.DataSource = dt;
                    dt = c.calcSum();
                    dataSUM.DataSource = dt;

                    clear();
                }
                else
                {
                    MessageBox.Show("فشل في التحديث, حاول مرة اخرى");
                }
            }
            else
            {
                MessageBox.Show("يوجد خانة فارغة او تحتوي على الرقم صفر, فشل فالاضافة");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (numericId.Value != 0)
            {
                c.companyName = txtBoxCompanyName.Text;
                c.quantity = Convert.ToInt64(numericQuantity.Value);
                c.price = Convert.ToInt64(numericPrice.Value);
                c.id = numericId.Value.ToString();
                c.date = datePicker.Value.ToString("yyyy-MM-dd");
                c.country = txtCountry.Text;
                bool success = c.delete(c);
                if (success)
                {
                    MessageBox.Show("تم مسح عنصر بنجاح");
                    DataTable dt = c.select();
                    showList.DataSource = dt;
                    dt = c.calcSum();
                    dataSUM.DataSource = dt;

                    clear();
                }
                else
                {
                    MessageBox.Show("فشل في المسح, حاول مرة اخرى");
                }
            }
            else
            {
                MessageBox.Show("رقم المطالبة غير صحيح");
            }
        }

        static string myconnstring = ConfigurationManager.ConnectionStrings["DBapplication.Properties.Settings.ConnectionString"].ConnectionString;
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            string searchText = textBox3.Text;
            SqlConnection conn = new SqlConnection(myconnstring);
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM [حصر الاستاكوزا] WHERE [اسم الشركة] LIKE '%" + searchText + "%';", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            showList.DataSource = dt;
        }
    }
}
