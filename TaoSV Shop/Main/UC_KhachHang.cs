using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TaoSV_Shop.Main
{
    public partial class UC_KhachHang : UserControl
    {
        SqlConnection con = new SqlConnection(@$"Data Source=DESKTOP-R8T388A\SQLEXPRESS01;Initial Catalog=qldt;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
        DataTable dt = new DataTable();
        SqlCommand cmd;
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable dt2 = new DataTable();
        SqlCommand cmd2;
        SqlDataAdapter adapter2 = new SqlDataAdapter();
        public UC_KhachHang()
        {
            InitializeComponent();
            loaddata();
        }
        private void loaddata()
        {
            try
            {
                con.Open(); // Mở kết nối

                cmd = con.CreateCommand();
                cmd.CommandText = "select * From Khach_Hang";
                adapter.SelectCommand = cmd;
                dt.Clear();
                adapter.Fill(dt);
                guna2DataGridView2.DataSource = dt;

                guna2ComboBox2.Items.Clear(); // Xóa các mục trước khi thêm mới
                guna2ComboBox2.Items.Add("Nam");
                guna2ComboBox2.Items.Add("Nữ");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
            }
            finally
            {
                con.Close(); // Đảm bảo kết nối được đóng sau khi sử dụng
            }
        }
        private void txt_email_Click(object sender, EventArgs e)
        {

        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void guna2GradientButton3_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                cmd = con.CreateCommand();
                cmd.CommandText = "insert into Khach_Hang values('" + guna2TextBox10.Text + "','" + guna2TextBox9.Text + "','" + guna2ComboBox2.Text + "','" + guna2TextBox8.Text + "','" + guna2DateTimePicker2.Value.ToString("dd-MM-yyyy") + "','" + guna2TextBox7.Text + "','" + guna2TextBox4.Text + "')";
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
            }
            finally
            {
                con.Close();
                loaddata();
            }
        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open(); // Mở kết nối trước khi thực hiện truy vấn
                SqlTransaction transaction = con.BeginTransaction();
                cmd = con.CreateCommand();
                cmd.Transaction = transaction;
                cmd.CommandText = "UPDATE Khach_Hang SET tenkh = @TenKhachHang, GioiTinh = @GioiTinh, DiaChi = @DiaChi, NamSinh = @NamSinh, sdt = @SoDienThoai, Email = @Email WHERE makh = @MaKhachHang";
                cmd.Parameters.AddWithValue("@TenKhachHang", guna2TextBox9.Text);
                cmd.Parameters.AddWithValue("@GioiTinh", guna2ComboBox2.Text);
                cmd.Parameters.AddWithValue("@DiaChi", guna2TextBox8.Text);
                cmd.Parameters.AddWithValue("@NamSinh", guna2DateTimePicker2.Value.ToString("dd-MM-yyyy"));
                cmd.Parameters.AddWithValue("@SoDienThoai", guna2TextBox7.Text);
                cmd.Parameters.AddWithValue("@Email", guna2TextBox4.Text);
                cmd.Parameters.AddWithValue("@MaKhachHang", guna2TextBox10.Text);
                cmd.ExecuteNonQuery();
                transaction.Commit();
                con.Close(); // Đóng kết nối sau khi hoàn thành
                loaddata();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            // Hiển thị hộp thoại xác nhận
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa khách hàng này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Nếu người dùng chọn Yes, tiến hành xóa
            if (result == DialogResult.Yes)
            {
                try
                {
                    using (cmd = con.CreateCommand())
                    {
                        con.Open();
                        cmd.CommandText = "delete from Khach_Hang WHERE makh = @maKH";
                        cmd.Parameters.AddWithValue("@maKH", guna2TextBox10.Text);
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Khách hàng đã được xóa thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy khách hàng để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Có lỗi xảy ra: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    con.Close();
                    loaddata();
                }
            }
            else
            {
                // Nếu người dùng chọn No, không làm gì cả
                MessageBox.Show("Hành động xóa đã bị hủy.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void loaddataf(string maKhachHang = "")
        {
            cmd2 = con.CreateCommand();
            if (string.IsNullOrEmpty(maKhachHang))
            {
                cmd2.CommandText = "select * from Khach_Hang";
                MessageBox.Show("Nhập lại ");
            }
            else 
            {
                cmd2.CommandText = "select * from Khach_Hang where makh = @maKhachHang";
                cmd2.Parameters.AddWithValue("@maKhachHang", maKhachHang);
            }

            adapter2.SelectCommand = cmd2;
            dt2.Clear();
            adapter2.Fill(dt2);
            guna2DataGridView1.DataSource = dt2;
        }

        private void guna2GradientButton4_Click(object sender, EventArgs e)
        {
            string maKhachHang = guna2TextBox12.Text.Trim();
            loaddataf(maKhachHang);
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void guna2DataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = guna2DataGridView2.Rows[e.RowIndex];
                guna2TextBox10.Text = row.Cells["dataGridViewTextBoxColumn7"].Value.ToString();
                guna2TextBox9.Text = row.Cells["dataGridViewTextBoxColumn8"].Value.ToString();
                guna2ComboBox2.Text = row.Cells["dataGridViewTextBoxColumn9"].Value.ToString();
                guna2TextBox8.Text = row.Cells["dataGridViewTextBoxColumn10"].Value.ToString();
                guna2DateTimePicker2.Value = Convert.ToDateTime(row.Cells["dataGridViewTextBoxColumn11"].Value);
                guna2TextBox7.Text = row.Cells["dataGridViewTextBoxColumn12"].Value.ToString();
                guna2TextBox4.Text = row.Cells["dataGridViewTextBoxColumn13"].Value.ToString();
            }
        }
        

        private void guna2ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
