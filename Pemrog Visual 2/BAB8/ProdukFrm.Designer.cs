namespace Pemrog_Visual_2.BAB8
{
    partial class ProdukFrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_simpan = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_hapus = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.dgv_mahasiswa = new System.Windows.Forms.DataGridView();
            this._id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._nama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._kategori = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._merek = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._jumlah = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._harga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.txt_nama = new System.Windows.Forms.TextBox();
            this.txt_kategori = new System.Windows.Forms.TextBox();
            this.txt_merek = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_jumlah = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_harga = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_mahasiswa)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.dgv_mahasiswa, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.txt_id, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.txt_nama, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.txt_kategori, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.txt_merek, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label3, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label4, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label5, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.txt_jumlah, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.label6, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.txt_harga, 2, 6);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 10;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(518, 374);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel1.SetColumnSpan(this.tableLayoutPanel2, 4);
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.00062F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.00062F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.00062F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.99813F));
            this.tableLayoutPanel2.Controls.Add(this.btn_simpan, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btn_update, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btn_hapus, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.btn_clear, 3, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 198);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(518, 28);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // btn_simpan
            // 
            this.btn_simpan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_simpan.Location = new System.Drawing.Point(3, 3);
            this.btn_simpan.Name = "btn_simpan";
            this.btn_simpan.Size = new System.Drawing.Size(123, 22);
            this.btn_simpan.TabIndex = 0;
            this.btn_simpan.Text = "SIMPAN";
            this.btn_simpan.UseVisualStyleBackColor = true;
            this.btn_simpan.Click += new System.EventHandler(this.btn_simpan_Click);
            // 
            // btn_update
            // 
            this.btn_update.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_update.Location = new System.Drawing.Point(132, 3);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(123, 22);
            this.btn_update.TabIndex = 1;
            this.btn_update.Text = "UPDATE";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_hapus
            // 
            this.btn_hapus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_hapus.Location = new System.Drawing.Point(261, 3);
            this.btn_hapus.Name = "btn_hapus";
            this.btn_hapus.Size = new System.Drawing.Size(123, 22);
            this.btn_hapus.TabIndex = 2;
            this.btn_hapus.Text = "HAPUS";
            this.btn_hapus.UseVisualStyleBackColor = true;
            this.btn_hapus.Click += new System.EventHandler(this.btn_hapus_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_clear.Location = new System.Drawing.Point(390, 3);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(125, 22);
            this.btn_clear.TabIndex = 3;
            this.btn_clear.Text = "CLEAR";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // dgv_mahasiswa
            // 
            this.dgv_mahasiswa.AllowUserToAddRows = false;
            this.dgv_mahasiswa.AllowUserToDeleteRows = false;
            this.dgv_mahasiswa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_mahasiswa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_mahasiswa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this._id,
            this._nama,
            this._kategori,
            this._merek,
            this._jumlah,
            this._harga});
            this.tableLayoutPanel1.SetColumnSpan(this.dgv_mahasiswa, 4);
            this.dgv_mahasiswa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_mahasiswa.Location = new System.Drawing.Point(0, 226);
            this.dgv_mahasiswa.Margin = new System.Windows.Forms.Padding(0);
            this.dgv_mahasiswa.Name = "dgv_mahasiswa";
            this.dgv_mahasiswa.ReadOnly = true;
            this.dgv_mahasiswa.Size = new System.Drawing.Size(518, 148);
            this.dgv_mahasiswa.TabIndex = 1;
            this.dgv_mahasiswa.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_mahasiswa_CellClick);
            // 
            // _id
            // 
            this._id.DataPropertyName = "id";
            this._id.HeaderText = "ID";
            this._id.Name = "_id";
            this._id.ReadOnly = true;
            this._id.Width = 43;
            // 
            // _nama
            // 
            this._nama.DataPropertyName = "nama";
            this._nama.HeaderText = "Nama";
            this._nama.Name = "_nama";
            this._nama.ReadOnly = true;
            this._nama.Width = 60;
            // 
            // _kategori
            // 
            this._kategori.DataPropertyName = "kategori";
            this._kategori.HeaderText = "Kategori";
            this._kategori.Name = "_kategori";
            this._kategori.ReadOnly = true;
            this._kategori.Width = 71;
            // 
            // _merek
            // 
            this._merek.DataPropertyName = "merek";
            this._merek.HeaderText = "Merek";
            this._merek.Name = "_merek";
            this._merek.ReadOnly = true;
            this._merek.Width = 62;
            // 
            // _jumlah
            // 
            this._jumlah.DataPropertyName = "jumlah";
            this._jumlah.HeaderText = "Jumlah";
            this._jumlah.Name = "_jumlah";
            this._jumlah.ReadOnly = true;
            this._jumlah.Width = 65;
            // 
            // _harga
            // 
            this._harga.DataPropertyName = "harga";
            this._harga.HeaderText = "Harga";
            this._harga.Name = "_harga";
            this._harga.ReadOnly = true;
            this._harga.Width = 61;
            // 
            // txt_id
            // 
            this.txt_id.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_id.Location = new System.Drawing.Point(153, 18);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(312, 20);
            this.txt_id.TabIndex = 2;
            // 
            // txt_nama
            // 
            this.txt_nama.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_nama.Location = new System.Drawing.Point(153, 46);
            this.txt_nama.Name = "txt_nama";
            this.txt_nama.Size = new System.Drawing.Size(312, 20);
            this.txt_nama.TabIndex = 3;
            // 
            // txt_kategori
            // 
            this.txt_kategori.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_kategori.Location = new System.Drawing.Point(153, 74);
            this.txt_kategori.Name = "txt_kategori";
            this.txt_kategori.Size = new System.Drawing.Size(312, 20);
            this.txt_kategori.TabIndex = 4;
            // 
            // txt_merek
            // 
            this.txt_merek.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_merek.Location = new System.Drawing.Point(153, 102);
            this.txt_merek.Name = "txt_merek";
            this.txt_merek.Size = new System.Drawing.Size(312, 20);
            this.txt_merek.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(53, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 28);
            this.label1.TabIndex = 7;
            this.label1.Text = "ID Produk";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(53, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 28);
            this.label2.TabIndex = 8;
            this.label2.Text = "Nama";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(53, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 28);
            this.label3.TabIndex = 9;
            this.label3.Text = "Kategori";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(53, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 28);
            this.label4.TabIndex = 10;
            this.label4.Text = "Merek";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(53, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 28);
            this.label5.TabIndex = 11;
            this.label5.Text = "Jumlah";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_jumlah
            // 
            this.txt_jumlah.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_jumlah.Location = new System.Drawing.Point(153, 130);
            this.txt_jumlah.Name = "txt_jumlah";
            this.txt_jumlah.Size = new System.Drawing.Size(312, 20);
            this.txt_jumlah.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Location = new System.Drawing.Point(53, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 28);
            this.label6.TabIndex = 13;
            this.label6.Text = "Harga";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_harga
            // 
            this.txt_harga.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_harga.Location = new System.Drawing.Point(153, 158);
            this.txt_harga.Name = "txt_harga";
            this.txt_harga.Size = new System.Drawing.Size(312, 20);
            this.txt_harga.TabIndex = 14;
            // 
            // ProdukFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 374);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ProdukFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form Produk";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_mahasiswa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btn_simpan;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_hapus;
        private System.Windows.Forms.DataGridView dgv_mahasiswa;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.TextBox txt_nama;
        private System.Windows.Forms.TextBox txt_kategori;
        private System.Windows.Forms.TextBox txt_merek;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.DataGridViewTextBoxColumn _id;
        private System.Windows.Forms.DataGridViewTextBoxColumn _nama;
        private System.Windows.Forms.DataGridViewTextBoxColumn _kategori;
        private System.Windows.Forms.DataGridViewTextBoxColumn _merek;
        private System.Windows.Forms.DataGridViewTextBoxColumn _jumlah;
        private System.Windows.Forms.DataGridViewTextBoxColumn _harga;
        private System.Windows.Forms.TextBox txt_jumlah;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_harga;
    }
}