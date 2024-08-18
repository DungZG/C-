using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaoSV_Shop.Main
{
    public partial class UC_BanHang : UserControl
    {
        SqlConnection con = new SqlConnection(@$"Data Source=DESKTOP-R8T388A\SQLEXPRESS01;Initial Catalog=qldt;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
        DataTable dt = new DataTable();
        SqlCommand cmd;
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable dt2 = new DataTable();
        SqlCommand cmd2;
        SqlDataAdapter adapter2 = new SqlDataAdapter();
        private Dictionary<string, string> productData = new Dictionary<string, string>();
        public UC_BanHang()
        {
            InitializeComponent();
            loaddatahd();
            CalculateTotal();
            LoadKhachHangData();
            LoadSanPhamData();
            LoadKhachtensp();

            guna2ComboBox3.SelectedIndexChanged += guna2ComboBox3_SelectedIndexChanged;
            guna2ComboBox4.SelectedIndexChanged += guna2ComboBox4_SelectedIndexChanged;
        }
        private void loaddatahd()
        {
            cmd = con.CreateCommand();
            cmd.CommandText = "select chi_tiet_hoa_don.mahd,Hoa_Don.NgayLap,Hoa_Don.makh,chi_tiet_hoa_don.tensp,chi_tiet_hoa_don.masp,chi_tiet_hoa_don.soluong,chi_tiet_hoa_don.thanhtien,Hoa_Don.trangthai From chi_tiet_hoa_don \r\njoin hoa_don on chi_tiet_hoa_don.mahd = hoa_don.mahd";
            adapter.SelectCommand = cmd;
            dt.Clear();
            adapter.Fill(dt);
            guna2DataGridView1.DataSource = dt;

            guna2ComboBox2.Items.Add("Đã Thanh Toán");
            guna2ComboBox2.Items.Add("Chưa Thanh Toán");
        }
        private void LoadKhachHangData()
        {
            try
            {
                con.Open();
                cmd = new SqlCommand("SELECT makh FROM Khach_Hang", con);
                SqlDataReader reader = cmd.ExecuteReader();

                List<string> khachHangList = new List<string>();
                while (reader.Read())
                {
                    khachHangList.Add(reader["makh"].ToString());
                }
                reader.Close();
                con.Close();

                guna2ComboBox1.DataSource = khachHangList;
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
        private void LoadKhachtensp()
        {
            try
            {
                con.Open();
                cmd = new SqlCommand("SELECT tensp FROM san_pham", con);
                SqlDataReader reader = cmd.ExecuteReader();

                List<string> sp = new List<string>();
                while (reader.Read())
                {
                    sp.Add(reader["tensp"].ToString());
                }
                reader.Close();
                con.Close();

                guna2ComboBox4.DataSource = sp;
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
        private void LoadSanPhamData()
        {
            try
            {
                con.Open();
                cmd = new SqlCommand("SELECT masp, tensp, giaban FROM San_Pham", con);
                SqlDataReader reader = cmd.ExecuteReader();

                List<string> sanPhamList = new List<string>();
                List<string> tenSanPhamList = new List<string>();
                Dictionary<string, decimal> giaBanDict = new Dictionary<string, decimal>();

                while (reader.Read())
                {
                    string masp = reader["masp"].ToString();
                    string tensp = reader["tensp"].ToString();
                    decimal giaban = Convert.ToDecimal(reader["giaban"]);

                    sanPhamList.Add(masp);
                    tenSanPhamList.Add(tensp);
                    productData[masp] = tensp; // Thêm dữ liệu vào từ điển
                    giaBanDict[masp] = giaban; // Thêm giá bán vào từ điển
                }
                reader.Close();
                con.Close();

                guna2ComboBox3.DataSource = sanPhamList;
                guna2ComboBox4.DataSource = tenSanPhamList;

                // Gán sự kiện SelectedIndexChanged cho guna2ComboBox3
                guna2ComboBox3.SelectedIndexChanged += (sender, e) =>
                {
                    string selectedMasp = guna2ComboBox3.SelectedItem.ToString();
                    if (giaBanDict.ContainsKey(selectedMasp))
                    {
                        decimal selectedGiaBan = giaBanDict[selectedMasp];
                        // Gán giá trị giaban vào đâu đó, ví dụ: một TextBox hoặc Label
                        guna2TextBox4.Text = selectedGiaBan.ToString();
                    }
                };
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



        private void CalculateTotal()
        {
            try
            {
                con.Open();
                cmd = new SqlCommand("SELECT SUM(thanhtien) AS Total FROM chi_tiet_hoa_don", con);
                object result = cmd.ExecuteScalar();
                if (result != DBNull.Value)
                {
                    guna2TextBox2.Text = result.ToString();

                    cmd = new SqlCommand("UPDATE hoa_don SET tongtien = @tongtien", con);
                    cmd.Parameters.AddWithValue("@tongtien", result);
                    cmd.ExecuteNonQuery();
                }
                con.Close();
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

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {

        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {

        }

        private void UC_BanHang_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void guna2GradientButton4_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlTransaction transaction = con.BeginTransaction();

                cmd = new SqlCommand("INSERT INTO Hoa_Don (mahd, NgayLap, makh, trangthai) VALUES (@mahd, @NgayLap, @makh, @trangthai)", con, transaction);
                cmd.Parameters.AddWithValue("@mahd", guna2TextBox10.Text);
                cmd.Parameters.AddWithValue("@NgayLap", guna2DateTimePicker1.Value.ToString("dd-MM-yyyy"));
                cmd.Parameters.AddWithValue("@makh", guna2ComboBox1.Text);
                cmd.Parameters.AddWithValue("@trangthai", guna2ComboBox2.Text);
                cmd.ExecuteNonQuery();

                double dongia = double.Parse(guna2TextBox4.Text);
                int soluong = int.Parse(guna2TextBox1.Text);
                double thanhtien = dongia * soluong;

                cmd = new SqlCommand("INSERT INTO chi_tiet_hoa_don (mahd, tensp, masp, soluong, dongia, thanhtien) VALUES (@mahd, @tensp, @masp, @soluong, @dongia, @thanhtien)", con, transaction);
                cmd.Parameters.AddWithValue("@mahd", guna2TextBox10.Text);
                cmd.Parameters.AddWithValue("@masp", guna2ComboBox3.Text);
                cmd.Parameters.AddWithValue("@tensp", guna2ComboBox4.Text);
                cmd.Parameters.AddWithValue("@soluong", guna2TextBox1.Text);
                cmd.Parameters.AddWithValue("@dongia", guna2TextBox4.Text);
                cmd.Parameters.AddWithValue("@thanhtien", thanhtien);
                cmd.ExecuteNonQuery();

                transaction.Commit();
                con.Close();
                loaddatahd();
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

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2GradientButton3_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlTransaction transaction = con.BeginTransaction();

                cmd = new SqlCommand("UPDATE Hoa_Don SET NgayLap = @NgayLap, makh = @makh, trangthai = @trangthai WHERE mahd = @mahd", con, transaction);
                cmd.Parameters.AddWithValue("@mahd", guna2TextBox10.Text);
                cmd.Parameters.AddWithValue("@NgayLap", guna2DateTimePicker1.Value.ToString("dd-MM-yyyy"));
                cmd.Parameters.AddWithValue("@makh", guna2ComboBox1.Text);
                cmd.Parameters.AddWithValue("@trangthai", guna2ComboBox2.Text);
                cmd.ExecuteNonQuery();

                double dongia = double.Parse(guna2TextBox4.Text);
                int soluong = int.Parse(guna2TextBox1.Text);
                double thanhtien = dongia * soluong;

                cmd = new SqlCommand("UPDATE chi_tiet_hoa_don SET tensp = @tensp, masp = @masp, soluong = @soluong, dongia = @dongia, thanhtien = @thanhtien WHERE mahd = @mahd", con, transaction);
                cmd.Parameters.AddWithValue("@mahd", guna2TextBox10.Text);
                cmd.Parameters.AddWithValue("@tensp", guna2ComboBox4.Text);
                cmd.Parameters.AddWithValue("@masp", guna2ComboBox3.Text);
                cmd.Parameters.AddWithValue("@soluong", soluong);
                cmd.Parameters.AddWithValue("@dongia", dongia);
                cmd.Parameters.AddWithValue("@thanhtien", thanhtien);
                cmd.ExecuteNonQuery();

                transaction.Commit();
                con.Close();
                loaddatahd();
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

        private void guna2GradientButton2_Click_1(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlTransaction transaction = con.BeginTransaction();

                cmd = new SqlCommand("DELETE FROM chi_tiet_hoa_don WHERE mahd = @mahd", con, transaction);
                cmd.Parameters.AddWithValue("@mahd", guna2TextBox10.Text);
                cmd.ExecuteNonQuery();

                cmd = new SqlCommand("DELETE FROM Hoa_Don WHERE mahd = @mahd", con, transaction);
                cmd.Parameters.AddWithValue("@mahd", guna2TextBox10.Text);
                cmd.ExecuteNonQuery();

                transaction.Commit();
                con.Close();
                loaddatahd();
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
        private void guna2ComboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (guna2ComboBox3.SelectedItem != null)
            {
                string selectedMasp = guna2ComboBox3.SelectedItem.ToString();
                if (productData.ContainsKey(selectedMasp))
                {
                    guna2ComboBox4.SelectedItem = productData[selectedMasp];
                }
            }
        }

        private void guna2ComboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (guna2ComboBox4.SelectedItem != null)
            {
                string selectedTensp = guna2ComboBox4.SelectedItem.ToString();
                string correspondingMasp = productData.FirstOrDefault(x => x.Value == selectedTensp).Key;
                if (correspondingMasp != null)
                {
                    guna2ComboBox3.SelectedItem = correspondingMasp;
                }
            }
        }
        private void loaddataf(string mahd = "")
        {
            cmd2 = con.CreateCommand();
            if (string.IsNullOrEmpty(mahd))
            {
                cmd2.CommandText = "select * from Hoa_Don";
            }
            else
            {
                cmd2.CommandText = "select * from Hoa_Don where mahd = @mahd";
                cmd2.Parameters.AddWithValue("@mahd", mahd);
            }
            adapter2.SelectCommand = cmd2;
            dt2.Clear();
            adapter2.Fill(dt2);
            guna2DataGridView2.DataSource = dt2;
        }
        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            string mahd = guna2TextBox7.Text.Trim();
            loaddataf(mahd);
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = guna2DataGridView1.Rows[e.RowIndex];
                guna2TextBox10.Text = row.Cells["dataGridViewTextBoxColumn7"].Value.ToString();
                guna2DateTimePicker1.Value = Convert.ToDateTime(row.Cells["dataGridViewTextBoxColumn8"].Value);
                guna2ComboBox1.Text = row.Cells["dataGridViewTextBoxColumn9"].Value.ToString();
                guna2ComboBox2.Text = row.Cells["dataGridViewTextBoxColumn10"].Value.ToString();
                guna2ComboBox3.Text = row.Cells["dataGridViewTextBoxColumn11"].Value.ToString();
                guna2ComboBox4.Text = row.Cells["dataGridViewTextBoxColumn12"].Value.ToString();
                guna2TextBox1.Text = row.Cells["dataGridViewTextBoxColumn13"].Value.ToString();
                guna2TextBox3.Text = row.Cells["dongia"].Value.ToString();
            }
        }

        private void guna2TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void UC_BanHang_Load_1(object sender, EventArgs e)
        {

        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
