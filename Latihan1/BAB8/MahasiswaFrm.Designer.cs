namespace Latihan1.BAB8
{
    partial class MahasiswaFrm
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
            this.mahasiswadgv = new System.Windows.Forms.DataGridView();
            this._kd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._nama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._alamat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._jurusan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._kelamin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tambahbtn = new System.Windows.Forms.Button();
            this.hapusbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.alamattxt = new System.Windows.Forms.TextBox();
            this.namatxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.jurusancbx = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lakirbtn = new System.Windows.Forms.RadioButton();
            this.permrbtn = new System.Windows.Forms.RadioButton();
            this.kdlb = new System.Windows.Forms.Label();
            this.tanggaldtp = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.mahasiswadgv)).BeginInit();
            this.SuspendLayout();
            // 
            // mahasiswadgv
            // 
            this.mahasiswadgv.AllowUserToAddRows = false;
            this.mahasiswadgv.AllowUserToDeleteRows = false;
            this.mahasiswadgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mahasiswadgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this._kd,
            this._nama,
            this._alamat,
            this._jurusan,
            this._kelamin});
            this.mahasiswadgv.Location = new System.Drawing.Point(12, 193);
            this.mahasiswadgv.Name = "mahasiswadgv";
            this.mahasiswadgv.ReadOnly = true;
            this.mahasiswadgv.Size = new System.Drawing.Size(491, 245);
            this.mahasiswadgv.TabIndex = 7;
            this.mahasiswadgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.mahasiswadgv_CellClick);
            // 
            // _kd
            // 
            this._kd.DataPropertyName = "kd";
            this._kd.HeaderText = "Kd";
            this._kd.Name = "_kd";
            this._kd.ReadOnly = true;
            // 
            // _nama
            // 
            this._nama.DataPropertyName = "nama";
            this._nama.HeaderText = "Nama";
            this._nama.Name = "_nama";
            this._nama.ReadOnly = true;
            // 
            // _alamat
            // 
            this._alamat.DataPropertyName = "alamat";
            this._alamat.HeaderText = "Alamat";
            this._alamat.Name = "_alamat";
            this._alamat.ReadOnly = true;
            // 
            // _jurusan
            // 
            this._jurusan.DataPropertyName = "jurusan";
            this._jurusan.HeaderText = "Jurusan";
            this._jurusan.Name = "_jurusan";
            this._jurusan.ReadOnly = true;
            // 
            // _kelamin
            // 
            this._kelamin.DataPropertyName = "kelamin";
            this._kelamin.HeaderText = "Kelamin";
            this._kelamin.Name = "_kelamin";
            this._kelamin.ReadOnly = true;
            // 
            // tambahbtn
            // 
            this.tambahbtn.Location = new System.Drawing.Point(389, 40);
            this.tambahbtn.Name = "tambahbtn";
            this.tambahbtn.Size = new System.Drawing.Size(75, 23);
            this.tambahbtn.TabIndex = 5;
            this.tambahbtn.Text = "Simpan";
            this.tambahbtn.UseVisualStyleBackColor = true;
            this.tambahbtn.Click += new System.EventHandler(this.tambahbtn_Click);
            // 
            // hapusbtn
            // 
            this.hapusbtn.Location = new System.Drawing.Point(389, 66);
            this.hapusbtn.Name = "hapusbtn";
            this.hapusbtn.Size = new System.Drawing.Size(75, 23);
            this.hapusbtn.TabIndex = 6;
            this.hapusbtn.Text = "Hapus";
            this.hapusbtn.UseVisualStyleBackColor = true;
            this.hapusbtn.Click += new System.EventHandler(this.hapusbtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Kd";
            // 
            // alamattxt
            // 
            this.alamattxt.Location = new System.Drawing.Point(82, 68);
            this.alamattxt.Name = "alamattxt";
            this.alamattxt.Size = new System.Drawing.Size(301, 20);
            this.alamattxt.TabIndex = 1;
            // 
            // namatxt
            // 
            this.namatxt.Location = new System.Drawing.Point(82, 42);
            this.namatxt.Name = "namatxt";
            this.namatxt.Size = new System.Drawing.Size(161, 20);
            this.namatxt.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nama";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Alamat";
            // 
            // jurusancbx
            // 
            this.jurusancbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.jurusancbx.FormattingEnabled = true;
            this.jurusancbx.Location = new System.Drawing.Point(82, 94);
            this.jurusancbx.Name = "jurusancbx";
            this.jurusancbx.Size = new System.Drawing.Size(161, 21);
            this.jurusancbx.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Jurusan";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Kelamin";
            // 
            // lakirbtn
            // 
            this.lakirbtn.AutoSize = true;
            this.lakirbtn.Location = new System.Drawing.Point(82, 121);
            this.lakirbtn.Name = "lakirbtn";
            this.lakirbtn.Size = new System.Drawing.Size(64, 17);
            this.lakirbtn.TabIndex = 3;
            this.lakirbtn.TabStop = true;
            this.lakirbtn.Text = "Laki-laki";
            this.lakirbtn.UseVisualStyleBackColor = true;
            // 
            // permrbtn
            // 
            this.permrbtn.AutoSize = true;
            this.permrbtn.Location = new System.Drawing.Point(152, 121);
            this.permrbtn.Name = "permrbtn";
            this.permrbtn.Size = new System.Drawing.Size(79, 17);
            this.permrbtn.TabIndex = 4;
            this.permrbtn.TabStop = true;
            this.permrbtn.Text = "Perempuan";
            this.permrbtn.UseVisualStyleBackColor = true;
            // 
            // kdlb
            // 
            this.kdlb.AutoSize = true;
            this.kdlb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kdlb.Location = new System.Drawing.Point(79, 19);
            this.kdlb.Name = "kdlb";
            this.kdlb.Size = new System.Drawing.Size(19, 13);
            this.kdlb.TabIndex = 13;
            this.kdlb.Text = "...";
            // 
            // tanggaldtp
            // 
            this.tanggaldtp.Location = new System.Drawing.Point(82, 144);
            this.tanggaldtp.Name = "tanggaldtp";
            this.tanggaldtp.Size = new System.Drawing.Size(216, 20);
            this.tanggaldtp.TabIndex = 14;
            // 
            // MahasiswaFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 450);
            this.Controls.Add(this.tanggaldtp);
            this.Controls.Add(this.kdlb);
            this.Controls.Add(this.permrbtn);
            this.Controls.Add(this.lakirbtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.jurusancbx);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.namatxt);
            this.Controls.Add(this.alamattxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hapusbtn);
            this.Controls.Add(this.tambahbtn);
            this.Controls.Add(this.mahasiswadgv);
            this.Name = "MahasiswaFrm";
            this.Text = "MahasiswaFrm";
            this.Load += new System.EventHandler(this.MahasiswaFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mahasiswadgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView mahasiswadgv;
        private System.Windows.Forms.Button tambahbtn;
        private System.Windows.Forms.Button hapusbtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn _kd;
        private System.Windows.Forms.DataGridViewTextBoxColumn _nama;
        private System.Windows.Forms.DataGridViewTextBoxColumn _alamat;
        private System.Windows.Forms.DataGridViewTextBoxColumn _jurusan;
        private System.Windows.Forms.DataGridViewTextBoxColumn _kelamin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox alamattxt;
        private System.Windows.Forms.TextBox namatxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox jurusancbx;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton lakirbtn;
        private System.Windows.Forms.RadioButton permrbtn;
        private System.Windows.Forms.Label kdlb;
        private System.Windows.Forms.DateTimePicker tanggaldtp;
    }
}