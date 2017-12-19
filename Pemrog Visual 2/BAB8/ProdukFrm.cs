using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Pemrog_Visual_2.BAB8
{
    public partial class ProdukFrm : Form
    {
        MySqlConnection MyConn;
        MySqlCommand MyComm;
        MySqlDataAdapter MyAdapter;
        string StrConn = "server=localhost;user=root;database=p_visual;port=3306;password=;";

        public ProdukFrm()
        {
            InitializeComponent();
            Clear();
        }

        private int ExecNonQuery(string query)
        {
            int ret = -1;
            
            try
            {
                MyConn = new MySqlConnection(StrConn);
                MyComm = new MySqlCommand(query, MyConn);
                MyConn.Open();
                ret = MyComm.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                MyConn.Close();
            }

            return ret;
        }

        private DataTable ExecQuery(string query)
        {
            DataTable ret = null;

            try
            {
                MyConn = new MySqlConnection(StrConn);
                MyComm = new MySqlCommand(query, MyConn);
                MyConn.Open();
                MyAdapter = new MySqlDataAdapter();
                MyAdapter.SelectCommand = MyComm;
                ret = new DataTable();
                MyAdapter.Fill(ret);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                MyConn.Close();
            }

            return ret;
        }

        private void Clear()
        {
            txt_id.Text = string.Empty;
            txt_nama.Text = string.Empty;
            txt_kategori.Text = string.Empty;
            txt_merek.Text = string.Empty;
            txt_jumlah.Text = string.Empty;
            txt_harga.Text = string.Empty;
            dgv_mahasiswa.DataSource = ExecQuery("select * from produk;");
        }

        private void btn_simpan_Click(object sender, EventArgs e)
        {
           string Query = "insert into produk(id,nama,kategori,merek,jumlah,harga) values(" + 
                txt_id.Text.Trim() + ",'" + 
                txt_nama.Text.Trim() + "','" +
                txt_kategori.Text.Trim() + "','" +
                txt_merek.Text.Trim() + "','" +
                txt_jumlah.Text.Trim() + "','" +
                txt_harga.Text.Trim() + "');";

            MessageBox.Show(ExecNonQuery(Query) + " Produk berhasil disimpan");
            Clear();
        }

        private void dgv_mahasiswa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                txt_id.Text = dgv_mahasiswa.Rows[e.RowIndex].Cells[0].Value.ToString();
                txt_nama.Text = dgv_mahasiswa.Rows[e.RowIndex].Cells[1].Value.ToString();
                txt_kategori.Text = dgv_mahasiswa.Rows[e.RowIndex].Cells[2].Value.ToString();
                txt_merek.Text = dgv_mahasiswa.Rows[e.RowIndex].Cells[3].Value.ToString();
                txt_jumlah.Text = dgv_mahasiswa.Rows[e.RowIndex].Cells[4].Value.ToString();
                txt_harga.Text = dgv_mahasiswa.Rows[e.RowIndex].Cells[5].Value.ToString();
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            string Query = "update produk set " +
                "nama='" + txt_nama.Text.Trim() +
                "', kategori='" + txt_kategori.Text.Trim() +
                "', merek='" + txt_merek.Text.Trim() +
                "', jumlah=" + txt_jumlah.Text.Trim() +
                ", harga=" + txt_harga.Text.Trim() +
                " where id=" + txt_id.Text.Trim() + ";";

            MessageBox.Show(ExecNonQuery(Query) + " Produk berhasil diupdate");
            Clear();
        }

        private void btn_hapus_Click(object sender, EventArgs e)
        {
            if (txt_id.Text != "")
            {
                if (MessageBox.Show("Yakin ingin menghapus produk dengan id " + txt_id.Text, "Hapus Data", MessageBoxButtons.YesNo) == DialogResult.Yes )
                {
                    string Query = "delete from produk where id=" + txt_id.Text.Trim() + ";";

                    MessageBox.Show(ExecNonQuery(Query) + " Produk berhasil dihapus");
                    Clear();
                }
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            Clear();
        }
    }
}
