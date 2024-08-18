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
using System.Transactions;
using System.Windows.Forms;

namespace TaoSV_Shop.Main
{
    public partial class UC_SanPham : UserControl
    {
        SqlConnection con = new SqlConnection(@$"Data Source=DESKTOP-R8T388A\SQLEXPRESS01;Initial Catalog=qldt;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
        DataTable dt = new DataTable();
        SqlCommand cmd;
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable dt2 = new DataTable();
        SqlCommand cmd2;
        SqlDataAdapter adapter2 = new SqlDataAdapter();
        DataTable dt3 = new DataTable();
        SqlCommand cmd3;
        SqlDataAdapter adapter3 = new SqlDataAdapter();

        DataTable dt4 = new DataTable();
        SqlCommand cmd4;
        SqlDataAdapter adapter4 = new SqlDataAdapter();
        public UC_SanPham()
        {
            InitializeComponent();
            loaddata();
            LoadSanPhamData();
            loaddatapn1();
        }
        private void LoadSanPhamData()
        {
            try
            {
                con.Open();
                cmd = new SqlCommand("SELECT masp FROM San_Pham", con);
                SqlDataReader reader = cmd.ExecuteReader();

                List<string> sanPhamList = new List<string>();
                while (reader.Read())
                {
                    sanPhamList.Add(reader["masp"].ToString());
                }
                reader.Close();
                con.Close();

                guna2ComboBox2.DataSource = sanPhamList;
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
        private void loaddata()
        {
            cmd = con.CreateCommand();
            cmd.CommandText = "select * From san_pham";
            adapter.SelectCommand = cmd;
            dt.Clear();
            adapter.Fill(dt);
            guna2DataGridView1.DataSource = dt;
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlTransaction transaction = con.BeginTransaction();
                cmd = con.CreateCommand();
                cmd.Transaction = transaction;
                cmd.CommandText = "insert into san_pham values(@masp, @tensp, @nhasx, @soluong, @giaban, @mota)";
                cmd.Parameters.AddWithValue("@masp", guna2TextBox1.Text);
                cmd.Parameters.AddWithValue("@tensp", guna2TextBox2.Text);
                cmd.Parameters.AddWithValue("@nhasx", guna2TextBox3.Text);
                cmd.Parameters.AddWithValue("@giaban", guna2TextBox6.Text);
                cmd.Parameters.AddWithValue("@soluong", guna2TextBox16.Text);
                cmd.Parameters.AddWithValue("@mota", guna2TextBox4.Text);
                cmd.ExecuteNonQuery();
                transaction.Commit();
                con.Close();
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

        private void btn_sua_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlTransaction transaction = con.BeginTransaction();
                cmd = con.CreateCommand();
                cmd.Transaction = transaction;
                cmd.CommandText = "update san_pham SET tensp = @Tensp, nhasx = @Nsx, soluong = @Soluong, giaban = @Giaban, mota = @Mota where masp = @Masp";
                cmd.Parameters.AddWithValue("@Tensp", guna2TextBox2.Text);
                cmd.Parameters.AddWithValue("@Nsx", guna2TextBox3.Text);
                cmd.Parameters.AddWithValue("@Soluong", guna2TextBox6.Text);
                cmd.Parameters.AddWithValue("@Giaban", guna2TextBox16.Text);
                cmd.Parameters.AddWithValue("@Mota", guna2TextBox4.Text);
                cmd.Parameters.AddWithValue("@Masp", guna2TextBox1.Text);
                cmd.ExecuteNonQuery();
                transaction.Commit();
                con.Close();
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

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            SqlTransaction transaction = null;
            try
            {
                con.Open();
                transaction = con.BeginTransaction();
                using (cmd = con.CreateCommand())
                {
                    cmd.Transaction = transaction;
                    cmd.CommandText = "delete from san_pham WHERE masp = @masp";
                    cmd.Parameters.AddWithValue("@masp", guna2TextBox1.Text);
                    cmd.ExecuteNonQuery();
                }
                transaction.Commit();
                loaddata();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);

                transaction?.Rollback();
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }


        private void loaddataf(string masp = "")
        {
            cmd2 = con.CreateCommand();
            if (string.IsNullOrEmpty(masp))
            {
                cmd2.CommandText = "select * from san_pham";
            }
            else
            {
                cmd2.CommandText = "select * from san_pham where masp = @masp";
                cmd2.Parameters.AddWithValue("@masp", masp);
            }
            adapter2.SelectCommand = cmd2;
            dt2.Clear();
            adapter2.Fill(dt2);
            guna2DataGridView2.DataSource = dt2;
        }
        private void loaddatapnf(string mapn = "")
        {
            cmd3 = con.CreateCommand();
            if (string.IsNullOrEmpty(mapn))
            {
                cmd3.CommandText = @"
            SELECT phieu_nhap.mapn, phieu_nhap.ngaynhap, phieu_nhap.tongtien,
                   chi_tiet_phieu_nhap.masp, chi_tiet_phieu_nhap.gianhap,
                   chi_tiet_phieu_nhap.soluong, chi_tiet_phieu_nhap.ghichu
            FROM phieu_nhap
            JOIN chi_tiet_phieu_nhap ON phieu_nhap.mapn = chi_tiet_phieu_nhap.mapn";
            }
            else
            {
                cmd3.CommandText = @"
            SELECT phieu_nhap.mapn, phieu_nhap.ngaynhap, phieu_nhap.tongtien,
                   chi_tiet_phieu_nhap.masp, chi_tiet_phieu_nhap.gianhap,
                   chi_tiet_phieu_nhap.soluong, chi_tiet_phieu_nhap.ghichu
            FROM phieu_nhap
            JOIN chi_tiet_phieu_nhap ON phieu_nhap.mapn = chi_tiet_phieu_nhap.mapn
            WHERE phieu_nhap.mapn = @mapn";
                cmd3.Parameters.AddWithValue("@mapn", mapn);
            }

            adapter3.SelectCommand = cmd3;
            dt3.Clear();
            adapter3.Fill(dt3);
            guna2DataGridView3.DataSource = dt3;
        }

        private void loaddatapn1()
        {
            cmd4 = con.CreateCommand();
            cmd4.CommandText = "SELECT phieu_nhap.mapn, phieu_nhap.ngaynhap, phieu_nhap.tongtien, chi_tiet_phieu_nhap.masp, chi_tiet_phieu_nhap.gianhap, chi_tiet_phieu_nhap.soluong, chi_tiet_phieu_nhap.ghichu FROM phieu_nhap JOIN chi_tiet_phieu_nhap ON phieu_nhap.mapn = chi_tiet_phieu_nhap.mapn";
            adapter4.SelectCommand = cmd4; 
            dt4.Clear();
            adapter4.Fill(dt4);
            guna2DataGridView3.DataSource = dt4;
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            string masp = guna2TextBox7.Text.Trim();
            loaddataf(masp);
        }

        private void guna2DataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = guna2DataGridView3.Rows[e.RowIndex];

                    guna2TextBox15.Text = row.Cells["dataGridViewTextBoxColumn7"].Value?.ToString() ?? string.Empty;
                    guna2ComboBox2.Text = row.Cells["dataGridViewTextBoxColumn10"].Value?.ToString() ?? string.Empty;
                    guna2TextBox10.Text = row.Cells["dataGridViewTextBoxColumn11"].Value?.ToString() ?? string.Empty;
                    guna2TextBox11.Text = row.Cells["dataGridViewTextBoxColumn12"].Value?.ToString() ?? string.Empty;

                    if (row.Cells["dataGridViewTextBoxColumn8"].Value != null)
                    {
                        guna2DateTimePicker2.Value = DateTime.Parse(row.Cells["dataGridViewTextBoxColumn8"].Value.ToString());
                    }
                    else
                    {
                        guna2DateTimePicker2.Value = DateTime.Now;
                    }

                    guna2TextBox13.Text = row.Cells["dataGridViewTextBoxColumn9"].Value?.ToString() ?? string.Empty;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            string mapn = guna2TextBox14.Text.Trim();
            loaddatapnf(mapn);
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = guna2DataGridView1.Rows[e.RowIndex];
                guna2TextBox1.Text = row.Cells["mamay"].Value.ToString();
                guna2TextBox2.Text = row.Cells["tenmay"].Value.ToString();
                guna2TextBox3.Text = row.Cells["nhasx"].Value.ToString();
                guna2TextBox6.Text = row.Cells["soluong"].Value.ToString();
                guna2TextBox16.Text = row.Cells["gia"].Value.ToString();
                guna2TextBox4.Text = row.Cells["mota"].Value.ToString();
            }
        }

        private void UC_SanPham_Load(object sender, EventArgs e)
        {

        }
        private void guna2TextBox13_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void guna2ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guna2GradientButton5_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlTransaction transaction = con.BeginTransaction();

                
                cmd4 = new SqlCommand("INSERT INTO phieu_nhap (mapn, ngaynhap, tongtien) VALUES (@mapn, @ngaynhap, @tongtien)", con, transaction);
                cmd4.Parameters.AddWithValue("@mapn", guna2TextBox15.Text);
                cmd4.Parameters.AddWithValue("@ngaynhap", guna2DateTimePicker2.Value.ToString("dd-MM-yyyy"));
                cmd4.Parameters.AddWithValue("@tongtien", guna2TextBox13.Text);
                cmd4.ExecuteNonQuery();

                
                cmd4 = new SqlCommand("INSERT INTO chi_tiet_phieu_nhap (mapn, masp, gianhap, soluong, ghichu) VALUES (@mapn, @masp, @gianhap, @soluong, @ghichu)", con, transaction);
                cmd4.Parameters.AddWithValue("@mapn", guna2TextBox15.Text);
                cmd4.Parameters.AddWithValue("@masp", guna2ComboBox2.Text);
                cmd4.Parameters.AddWithValue("@gianhap", guna2TextBox10.Text);
                cmd4.Parameters.AddWithValue("@soluong", guna2TextBox11.Text);
                cmd4.Parameters.AddWithValue("@ghichu", guna2TextBox8.Text);
                cmd4.ExecuteNonQuery();

                transaction.Commit();
                con.Close();
                loaddatapn1();
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


        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void guna2GradientButton4_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlTransaction transaction = con.BeginTransaction();

                
                cmd4 = new SqlCommand("UPDATE phieu_nhap SET ngaynhap = @ngaynhap, tongtien = @tongtien WHERE mapn = @mapn", con, transaction);
                cmd4.Parameters.AddWithValue("@mapn", guna2TextBox15.Text);
                cmd4.Parameters.AddWithValue("@ngaynhap", guna2DateTimePicker2.Value.ToString("dd-MM-yyyy"));
                cmd4.Parameters.AddWithValue("@tongtien", guna2TextBox13.Text);
                cmd4.ExecuteNonQuery();

                
                cmd4 = new SqlCommand("UPDATE chi_tiet_phieu_nhap SET gianhap = @gianhap, soluong = @soluong, ghichu = @ghichu WHERE mapn = @mapn AND masp = @masp", con, transaction);
                cmd4.Parameters.AddWithValue("@mapn", guna2TextBox15.Text);
                cmd4.Parameters.AddWithValue("@masp", guna2ComboBox2.Text);
                cmd4.Parameters.AddWithValue("@gianhap", guna2TextBox10.Text);
                cmd4.Parameters.AddWithValue("@soluong", guna2TextBox11.Text);
                cmd4.Parameters.AddWithValue("@ghichu", guna2TextBox8.Text);
                cmd4.ExecuteNonQuery();

                transaction.Commit();
                con.Close();
                loaddatapn1();
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


        private void guna2GradientButton3_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa bản ghi này không?", "Xác nhận xóa", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    con.Open();
                    SqlTransaction transaction = con.BeginTransaction();

                    
                    cmd4 = new SqlCommand("DELETE FROM chi_tiet_phieu_nhap WHERE mapn = @mapn AND masp = @masp", con, transaction);
                    cmd4.Parameters.AddWithValue("@mapn", guna2TextBox15.Text);
                    cmd4.Parameters.AddWithValue("@masp", guna2ComboBox2.Text);
                    cmd4.ExecuteNonQuery();

                    
                    cmd4 = new SqlCommand("DELETE FROM phieu_nhap WHERE mapn = @mapn", con, transaction);
                    cmd4.Parameters.AddWithValue("@mapn", guna2TextBox15.Text);
                    cmd4.ExecuteNonQuery();

                    transaction.Commit();
                    con.Close();
                    loaddatapn1();
                }
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


        private void guna2DateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
