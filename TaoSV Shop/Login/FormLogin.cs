using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaoSV_Shop.Main;

namespace TaoSV_Shop.NewFolder
{
    public partial class FormLogin : Form
    {
        SqlConnection con = new SqlConnection(@$"Data Source=DESKTOP-R8T388A\SQLEXPRESS01;Initial Catalog=qldt;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
        public FormLogin()
        {
            InitializeComponent();
        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void peye_Click(object sender, EventArgs e)
        {
            if (txtPass.PasswordChar == '\0')
            {
                phide.BringToFront();
                txtPass.PasswordChar = '●';
            }
        }

        private void phide_Click(object sender, EventArgs e)
        {
            if (txtPass.PasswordChar == '●')
            {
                peye.BringToFront();
                txtPass.PasswordChar = '\0';
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            String username, user_password;
            username = txtUsername.Text;
            user_password = txtPass.Text;

            try
            {
                String querry = "Select * From Tai_Khoan WHERE TaiKhoan='" + txtUsername.Text + "' AND MatKhau ='" + txtPass.Text + "'";
                SqlDataAdapter sda = new SqlDataAdapter(querry, con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    username = txtUsername.Text;

                    user_password = txtPass.Text;

                    Base formMain = new Base();
                    formMain.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUsername.Clear();
                    txtPass.Clear();

                    txtUsername.Focus();

                }
            }
            catch
            {
                MessageBox.Show("Error");
            }
            finally
            {
                con.Close();
            }
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
