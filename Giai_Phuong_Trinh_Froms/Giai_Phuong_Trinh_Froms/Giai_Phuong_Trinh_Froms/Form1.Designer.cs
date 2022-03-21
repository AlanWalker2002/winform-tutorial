namespace Giai_Phuong_Trinh_Froms
{
    partial class Form1
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
            this.txba = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txbb = new System.Windows.Forms.TextBox();
            this.txbc = new System.Windows.Forms.TextBox();
            this.btnGiai = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbPhuongTrinhBac1 = new System.Windows.Forms.RadioButton();
            this.rdbPhuongTrinhBac2 = new System.Windows.Forms.RadioButton();
            this.txbKetQua = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txba
            // 
            this.txba.Location = new System.Drawing.Point(100, 183);
            this.txba.Name = "txba";
            this.txba.Size = new System.Drawing.Size(113, 22);
            this.txba.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(73, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Giải Phương Trình";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nhập a: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nhập b: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 259);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Nhập c: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 295);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Kết quả: ";
            // 
            // txbb
            // 
            this.txbb.Location = new System.Drawing.Point(100, 217);
            this.txbb.Name = "txbb";
            this.txbb.Size = new System.Drawing.Size(113, 22);
            this.txbb.TabIndex = 6;
            // 
            // txbc
            // 
            this.txbc.Location = new System.Drawing.Point(100, 253);
            this.txbc.Name = "txbc";
            this.txbc.Size = new System.Drawing.Size(113, 22);
            this.txbc.TabIndex = 7;
            // 
            // btnGiai
            // 
            this.btnGiai.Location = new System.Drawing.Point(221, 182);
            this.btnGiai.Name = "btnGiai";
            this.btnGiai.Size = new System.Drawing.Size(87, 23);
            this.btnGiai.TabIndex = 8;
            this.btnGiai.Text = "Giải";
            this.btnGiai.UseVisualStyleBackColor = true;
            this.btnGiai.Click += new System.EventHandler(this.btnGiai_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(221, 217);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(87, 23);
            this.btnXoa.TabIndex = 9;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(221, 253);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(87, 23);
            this.btnThoat.TabIndex = 10;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbPhuongTrinhBac2);
            this.groupBox1.Controls.Add(this.rdbPhuongTrinhBac1);
            this.groupBox1.Location = new System.Drawing.Point(12, 77);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(296, 100);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mời bạn chọn";
            // 
            // rdbPhuongTrinhBac1
            // 
            this.rdbPhuongTrinhBac1.AutoSize = true;
            this.rdbPhuongTrinhBac1.Location = new System.Drawing.Point(15, 32);
            this.rdbPhuongTrinhBac1.Name = "rdbPhuongTrinhBac1";
            this.rdbPhuongTrinhBac1.Size = new System.Drawing.Size(144, 20);
            this.rdbPhuongTrinhBac1.TabIndex = 0;
            this.rdbPhuongTrinhBac1.TabStop = true;
            this.rdbPhuongTrinhBac1.Text = "Phương Trình Bậc 1";
            this.rdbPhuongTrinhBac1.UseVisualStyleBackColor = true;
            this.rdbPhuongTrinhBac1.CheckedChanged += new System.EventHandler(this.rdbPhuongTrinhBac1_CheckedChanged_1);
            // 
            // rdbPhuongTrinhBac2
            // 
            this.rdbPhuongTrinhBac2.AutoSize = true;
            this.rdbPhuongTrinhBac2.Location = new System.Drawing.Point(15, 58);
            this.rdbPhuongTrinhBac2.Name = "rdbPhuongTrinhBac2";
            this.rdbPhuongTrinhBac2.Size = new System.Drawing.Size(144, 20);
            this.rdbPhuongTrinhBac2.TabIndex = 1;
            this.rdbPhuongTrinhBac2.TabStop = true;
            this.rdbPhuongTrinhBac2.Text = "Phương Trình Bậc 2";
            this.rdbPhuongTrinhBac2.UseVisualStyleBackColor = true;
            this.rdbPhuongTrinhBac2.CheckedChanged += new System.EventHandler(this.rdbPhuongTrinhBac2_CheckedChanged_1);
            // 
            // txbKetQua
            // 
            this.txbKetQua.Location = new System.Drawing.Point(101, 289);
            this.txbKetQua.Name = "txbKetQua";
            this.txbKetQua.Size = new System.Drawing.Size(207, 22);
            this.txbKetQua.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 351);
            this.Controls.Add(this.txbKetQua);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnGiai);
            this.Controls.Add(this.txbc);
            this.Controls.Add(this.txbb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txba);
            this.Name = "Form1";
            this.Text = "Bài 1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txba;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbb;
        private System.Windows.Forms.TextBox txbc;
        private System.Windows.Forms.Button btnGiai;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbPhuongTrinhBac2;
        private System.Windows.Forms.RadioButton rdbPhuongTrinhBac1;
        private System.Windows.Forms.TextBox txbKetQua;
    }
}

