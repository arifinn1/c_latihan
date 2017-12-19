namespace Pemrog_Visual_2.BAB7
{
    partial class FormCalc
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
            this.hitungBtn = new System.Windows.Forms.Button();
            this.operasiCbx = new System.Windows.Forms.ComboBox();
            this.nilai1Txt = new System.Windows.Forms.TextBox();
            this.nilai2Txt = new System.Windows.Forms.TextBox();
            this.hasilLb = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.Controls.Add(this.hitungBtn, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.operasiCbx, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.nilai1Txt, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.nilai2Txt, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.hasilLb, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(284, 83);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // hitungBtn
            // 
            this.hitungBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hitungBtn.Location = new System.Drawing.Point(237, 14);
            this.hitungBtn.Name = "hitungBtn";
            this.hitungBtn.Size = new System.Drawing.Size(44, 24);
            this.hitungBtn.TabIndex = 0;
            this.hitungBtn.Text = "=";
            this.hitungBtn.UseVisualStyleBackColor = true;
            this.hitungBtn.Click += new System.EventHandler(this.hitungBtn_Click);
            // 
            // operasiCbx
            // 
            this.operasiCbx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.operasiCbx.FormattingEnabled = true;
            this.operasiCbx.Items.AddRange(new object[] {
            "+",
            "-",
            "x",
            ":"});
            this.operasiCbx.Location = new System.Drawing.Point(95, 14);
            this.operasiCbx.Name = "operasiCbx";
            this.operasiCbx.Size = new System.Drawing.Size(44, 21);
            this.operasiCbx.TabIndex = 1;
            // 
            // nilai1Txt
            // 
            this.nilai1Txt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nilai1Txt.Location = new System.Drawing.Point(3, 14);
            this.nilai1Txt.Name = "nilai1Txt";
            this.nilai1Txt.Size = new System.Drawing.Size(86, 20);
            this.nilai1Txt.TabIndex = 2;
            // 
            // nilai2Txt
            // 
            this.nilai2Txt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nilai2Txt.Location = new System.Drawing.Point(145, 14);
            this.nilai2Txt.Name = "nilai2Txt";
            this.nilai2Txt.Size = new System.Drawing.Size(86, 20);
            this.nilai2Txt.TabIndex = 3;
            // 
            // hasilLb
            // 
            this.hasilLb.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.hasilLb, 4);
            this.hasilLb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hasilLb.Location = new System.Drawing.Point(3, 41);
            this.hasilLb.Name = "hasilLb";
            this.hasilLb.Size = new System.Drawing.Size(278, 30);
            this.hasilLb.TabIndex = 4;
            this.hasilLb.Text = "0";
            this.hasilLb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormCalc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 83);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FormCalc";
            this.Text = "FormCalc";
            this.Load += new System.EventHandler(this.FormCalc_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button hitungBtn;
        private System.Windows.Forms.ComboBox operasiCbx;
        private System.Windows.Forms.TextBox nilai1Txt;
        private System.Windows.Forms.TextBox nilai2Txt;
        private System.Windows.Forms.Label hasilLb;
    }
}