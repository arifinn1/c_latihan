using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace Latihan1.BAB8
{
    public partial class MahasiswaFrm : Form
    {
        int okd, kd;

        public MahasiswaFrm()
        {
            InitializeComponent();
        }

        void Clear()
        {
            DataTable t_kd = exec_query("select (isnull(max(kd),0)+1) as kd from mahasiswa");
            kd = (int) t_kd.Rows[0][0];
            okd = -1;

            kdlb.Text = kd.ToString();
            namatxt.Text = "";
            alamattxt.Text = "";

            jurusancbx.Items.Clear();
            jurusancbx.Items.Add("Teknik Informatika");
            jurusancbx.Items.Add("Teknik Elektronika");
            jurusancbx.Items.Add("Teknik Mesin");
            jurusancbx.Text = "";
            tanggaldtp.Value = DateTime.Now;
            MessageBox.Show(tanggaldtp.Value.Date.ToString());

            lakirbtn.Checked = false;
            permrbtn.Checked = false;
        }

        SqlConnection koneksi()
        {
            string con_string = @"Data Source=ARIFIN-PC\SQLEXPRESS;Initial Catalog=db_rental;Persist Security Info=True;User ID=sa;Password=arifin";
            SqlConnection conn = new SqlConnection(con_string);
            return conn;
        }

        DataTable exec_query(string query)
        {
            DataTable ret = new DataTable();

            SqlConnection conn = koneksi();
            try
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ret);
            }
            finally
            {
                conn.Close();
            }

            return ret;
        }

        int exec_non_query(string query)
        {
            int ret = -1;

            SqlConnection conn = koneksi();
            try
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = query;
                ret = cmd.ExecuteNonQuery();
            }
            finally
            {
                conn.Close();
            }

            return ret;
        }

        void display_data()
        {

            mahasiswadgv.DataSource = exec_query("SELECT * FROM mahasiswa");
        }

        private void MahasiswaFrm_Load(object sender, EventArgs e)
        {
            Clear();
            display_data();
        }

        private void tambahbtn_Click(object sender, EventArgs e)
        {
            if (namatxt.Text.Trim() != "" && alamattxt.Text.Trim() != "" && jurusancbx.SelectedIndex > -1 && (lakirbtn.Checked || permrbtn.Checked))
            {
                if (okd == -1)
                {
                    if (exec_non_query(String.Format("INSERT INTO mahasiswa VALUES({0}, '{1}','{2}','{3}','{4}')",
                        kd, namatxt.Text.Trim(), alamattxt.Text.Trim(), jurusancbx.SelectedItem, (lakirbtn.Checked ? "Laki-laki" : "Perempuan"))) > 0)
                    {
                        MessageBox.Show("Data baru tersimpan");
                        Clear();
                        display_data();
                    }
                    else MessageBox.Show("Data gagal disimpan");
                } else
                {
                    if (exec_non_query(String.Format("UPDATE mahasiswa SET nama='{0}', alamat='{1}', jurusan='{2}', kelamin='{3}' WHERE kd={4}",
                        namatxt.Text.Trim(), alamattxt.Text.Trim(), jurusancbx.SelectedItem, (lakirbtn.Checked ? "Laki-laki" : "Perempuan"), okd)) > 0)
                    {
                        MessageBox.Show("Data berhasil diperbaharui");
                        Clear();
                        display_data();
                    }
                    else MessageBox.Show("Data gagal diperbaharui");
                }
            } else
            {
                MessageBox.Show("Lengkapi data kembali");
            }
        }

        private void hapusbtn_Click(object sender, EventArgs e)
        {
            if (okd > -1)
            {
                if (exec_non_query("DELETE FROM mahasiswa WHERE kd="+okd) > 0)
                {
                    MessageBox.Show("Data sudah terhapus");
                    Clear();
                    display_data();
                }
            }
        }

        private void mahasiswadgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                kd = (int) mahasiswadgv.Rows[e.RowIndex].Cells["_kd"].Value;
                okd = kd;
                kdlb.Text = kd.ToString();
                namatxt.Text = mahasiswadgv.Rows[e.RowIndex].Cells["_nama"].Value.ToString();
                alamattxt.Text = mahasiswadgv.Rows[e.RowIndex].Cells["_alamat"].Value.ToString();
                jurusancbx.SelectedItem = mahasiswadgv.Rows[e.RowIndex].Cells["_jurusan"].Value.ToString();
                lakirbtn.Checked = (mahasiswadgv.Rows[e.RowIndex].Cells["_kelamin"].Value.ToString() == "Laki-laki" ? true : false);
                permrbtn.Checked = !lakirbtn.Checked;
            }
        }
    }
}
