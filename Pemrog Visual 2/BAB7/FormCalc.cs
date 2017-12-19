using System;
using System.Windows.Forms;

namespace Pemrog_Visual_2.BAB7
{
    public partial class FormCalc : Form
    {
        public FormCalc()
        {
            InitializeComponent();
        }

        private void hitungBtn_Click(object sender, EventArgs e)
        {
            float n1 = 0, n2 = 0, hasil = 0;
            String op = operasiCbx.Text;

            try
            {
                n1 = float.Parse(nilai1Txt.Text.Trim());
                n2 = float.Parse(nilai2Txt.Text.Trim());
                hasil = (op == "+" ? n1+n2 : (op == "-" ? n1-n2 : (op == "x" ? n1*n2 : n1/n2)));

                hasilLb.Text = hasil.ToString();
            }
            catch
            {
                hasilLb.Text = "Masukan hanya angka";
            }
        }

        private void FormCalc_Load(object sender, EventArgs e)
        {
            operasiCbx.SelectedIndex = 0;
        }
    }
}
