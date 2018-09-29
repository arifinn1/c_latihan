using System;
using System.Windows.Forms;

namespace Latihan1.BAB7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "Nama";

            comboBox1.Items.Add("Senin");
            comboBox1.Items.Add("Selasa");
            comboBox1.Items.Add("Rabu");
            comboBox1.Items.Add("Kamis");
            comboBox1.Items.Add("Jumat");
            comboBox1.Items.Add("Sabtu");
            comboBox1.Items.Add("Minggu");

            listBox1.Items.Add("Senin");
            listBox1.Items.Add("Selasa");
            listBox1.Items.Add("Rabu");
            listBox1.Items.Add("Kamis");
            listBox1.Items.Add("Jumat");
            listBox1.Items.Add("Sabtu");
            listBox1.Items.Add("Minggu");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Halo " + textBox1.Text + ", selamat hari " + comboBox1.SelectedItem);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Anda memilih hari " + listBox1.SelectedItem);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string res = radioButton1.Checked ? radioButton1.Text : 
                            (radioButton2.Checked ? radioButton2.Text :
                            (radioButton3.Checked ? radioButton3.Text : ""
                          ));

            MessageBox.Show(res);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string res = radioButton4.Checked ? radioButton4.Text :
                            (radioButton5.Checked ? radioButton5.Text :
                            (radioButton6.Checked ? radioButton6.Text : ""
                          ));

            MessageBox.Show(res);
        }
    }
}
