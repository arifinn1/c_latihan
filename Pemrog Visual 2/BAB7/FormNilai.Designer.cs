namespace Pemrog_Visual_2.BAB7
{
    partial class FormNilai
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
            this.nilaiTxt = new System.Windows.Forms.TextBox();
            this.prosesBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.hasilLb = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.nilaiTxt, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.prosesBtn, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.hasilLb, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.label3, 1, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(330, 187);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // nilaiTxt
            // 
            this.nilaiTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nilaiTxt.Location = new System.Drawing.Point(103, 49);
            this.nilaiTxt.Name = "nilaiTxt";
            this.nilaiTxt.Size = new System.Drawing.Size(204, 20);
            this.nilaiTxt.TabIndex = 0;
            // 
            // prosesBtn
            // 
            this.prosesBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.prosesBtn.Location = new System.Drawing.Point(103, 77);
            this.prosesBtn.Name = "prosesBtn";
            this.prosesBtn.Size = new System.Drawing.Size(204, 22);
            this.prosesBtn.TabIndex = 1;
            this.prosesBtn.Text = "Proses";
            this.prosesBtn.UseVisualStyleBackColor = true;
            this.prosesBtn.Click += new System.EventHandler(this.prosesBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(23, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nilai";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // hasilLb
            // 
            this.hasilLb.AutoSize = true;
            this.hasilLb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hasilLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hasilLb.Location = new System.Drawing.Point(103, 112);
            this.hasilLb.Name = "hasilLb";
            this.hasilLb.Size = new System.Drawing.Size(204, 28);
            this.hasilLb.TabIndex = 3;
            this.hasilLb.Text = "...";
            this.hasilLb.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(23, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 28);
            this.label3.TabIndex = 4;
            this.label3.Text = "Hasil";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FormNilai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 187);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FormNilai";
            this.Text = "FormNilai";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox nilaiTxt;
        private System.Windows.Forms.Button prosesBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label hasilLb;
        private System.Windows.Forms.Label label3;
    }
}