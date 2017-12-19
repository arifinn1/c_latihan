using System;
using MySql.Data.MySqlClient;

namespace Pemrog_Visual_2.BAB8
{
    class Produk_Serv
    {
        static string exec_query(string query)
        {
            string ret;
            try
            {
                string strConn = "server=localhost;user=root;database=p_visual;port=3306;password=;";
                MySqlConnection MyConn = new MySqlConnection(strConn);
                MySqlCommand MyComm = new MySqlCommand(query, MyConn);
                MySqlDataReader MyReader;
                MyConn.Open();
                MyReader = MyComm.ExecuteReader();
                MyConn.Close();

                ret = "success";
            }
            catch (Exception ex)
            {
                ret = ex.Message;
            }
            return ret;
        }

        static string simpan_data()
        {
            string ret = exec_query("insert into produk(id,nama,kategori,merek,jumlah, harga) values(1,'Marjan Syrup With Milk','Syrup','Marjan',12,15000);");
            return (ret=="success" ? "Data berhasil disimpan" : ret);
        }

        static string ubah_data()
        {
            string ret = exec_query("update produk set nama='Marjan Coco Berry Mint Squash', jumlah=10 where id=1;");
            return (ret == "success" ? "Data berhasil diubah" : ret);
        }

        static string hapus_data()
        {
            string ret = exec_query("delete from produk where id=1;");
            return (ret == "success" ? "Data berhasil dihapus" : ret);
        }

        public static void Main()
        {
            Console.WriteLine(simpan_data());
            Console.WriteLine(ubah_data());
            Console.WriteLine(hapus_data());
            Console.ReadKey();
        }
    }
}
