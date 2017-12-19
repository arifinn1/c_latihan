using System;
using System.Windows.Forms;

namespace Pemrog_Visual_2.BAB7
{
    public partial class FormNilai : Form
    {
        public FormNilai()
        {
            InitializeComponent();
        }

        private void prosesBtn_Click(object sender, EventArgs e)
        {
            String hasil = "Inputkan nilai 0 - 100";

            try
            {
                if (nilaiTxt.Text.Trim() != "")
                {
                    int nilai = int.Parse(nilaiTxt.Text.Trim());

                    if (nilai >= 0 && nilai <= 100)
                    {
                        if (nilai >= 81)
                            hasil = "A";
                        else if (nilai >= 71)
                            hasil = "AB";
                        else if (nilai >= 66)
                            hasil = "B";
                        else if (nilai >= 60)
                            hasil = "BC";
                        else if (nilai >= 56)
                            hasil = "C";
                        else if (nilai >= 41)
                            hasil = "D";
                        else
                            hasil = "E";
                    }
                    
                }
            }
            catch
            { hasil = "Masukan hanya angka"; }

            hasilLb.Text = hasil;
        }
    }
}
