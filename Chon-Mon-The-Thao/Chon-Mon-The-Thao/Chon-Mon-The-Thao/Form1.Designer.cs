namespace Chon_Mon_The_Thao
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lsbInfo = new System.Windows.Forms.ListBox();
            this.lsbChoose = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.rtbKetQua = new System.Windows.Forms.TextBox();
            this.btnInputAll = new System.Windows.Forms.Button();
            this.btnInput = new System.Windows.Forms.Button();
            this.btnOutputAll = new System.Windows.Forms.Button();
            this.btnOutput = new System.Windows.Forms.Button();
            this.btnNhap = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.dtpTime = new System.Windows.Forms.DateTimePicker();
            this.cboName = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(142, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh Sách Thể Thao";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Chọn họ tên: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ngày:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(279, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Giờ: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Danh sách các môn";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(297, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Danh sách đã chọn";
            // 
            // lsbInfo
            // 
            this.lsbInfo.FormattingEnabled = true;
            this.lsbInfo.ItemHeight = 16;
            this.lsbInfo.Location = new System.Drawing.Point(42, 193);
            this.lsbInfo.Name = "lsbInfo";
            this.lsbInfo.Size = new System.Drawing.Size(147, 132);
            this.lsbInfo.TabIndex = 6;
            // 
            // lsbChoose
            // 
            this.lsbChoose.FormattingEnabled = true;
            this.lsbChoose.ItemHeight = 16;
            this.lsbChoose.Location = new System.Drawing.Point(300, 193);
            this.lsbChoose.Name = "lsbChoose";
            this.lsbChoose.Size = new System.Drawing.Size(146, 132);
            this.lsbChoose.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(39, 339);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 16);
            this.label7.TabIndex = 8;
            this.label7.Text = "Kết Quả";
            // 
            // rtbKetQua
            // 
            this.rtbKetQua.Location = new System.Drawing.Point(42, 358);
            this.rtbKetQua.Multiline = true;
            this.rtbKetQua.Name = "rtbKetQua";
            this.rtbKetQua.Size = new System.Drawing.Size(272, 118);
            this.rtbKetQua.TabIndex = 9;
            // 
            // btnInputAll
            // 
            this.btnInputAll.Location = new System.Drawing.Point(204, 202);
            this.btnInputAll.Name = "btnInputAll";
            this.btnInputAll.Size = new System.Drawing.Size(75, 25);
            this.btnInputAll.TabIndex = 10;
            this.btnInputAll.Text = ">>";
            this.btnInputAll.UseVisualStyleBackColor = true;
            this.btnInputAll.Click += new System.EventHandler(this.btnInputAll_Click);
            // 
            // btnInput
            // 
            this.btnInput.Location = new System.Drawing.Point(204, 231);
            this.btnInput.Name = "btnInput";
            this.btnInput.Size = new System.Drawing.Size(75, 25);
            this.btnInput.TabIndex = 11;
            this.btnInput.Text = ">";
            this.btnInput.UseVisualStyleBackColor = true;
            this.btnInput.Click += new System.EventHandler(this.btnInput_Click);
            // 
            // btnOutputAll
            // 
            this.btnOutputAll.Location = new System.Drawing.Point(204, 260);
            this.btnOutputAll.Name = "btnOutputAll";
            this.btnOutputAll.Size = new System.Drawing.Size(75, 25);
            this.btnOutputAll.TabIndex = 12;
            this.btnOutputAll.Text = "<<";
            this.btnOutputAll.UseVisualStyleBackColor = true;
            this.btnOutputAll.Click += new System.EventHandler(this.btnOutputAll_Click);
            // 
            // btnOutput
            // 
            this.btnOutput.Location = new System.Drawing.Point(204, 289);
            this.btnOutput.Name = "btnOutput";
            this.btnOutput.Size = new System.Drawing.Size(75, 25);
            this.btnOutput.TabIndex = 13;
            this.btnOutput.Text = "<";
            this.btnOutput.UseVisualStyleBackColor = true;
            this.btnOutput.Click += new System.EventHandler(this.btnOutput_Click);
            // 
            // btnNhap
            // 
            this.btnNhap.Location = new System.Drawing.Point(334, 358);
            this.btnNhap.Name = "btnNhap";
            this.btnNhap.Size = new System.Drawing.Size(75, 23);
            this.btnNhap.TabIndex = 14;
            this.btnNhap.Text = "Nhập";
            this.btnNhap.UseVisualStyleBackColor = true;
            this.btnNhap.Click += new System.EventHandler(this.btnNhap_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(334, 397);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 15;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(334, 435);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 16;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // dtpDate
            // 
            this.dtpDate.CustomFormat = "dd/MM/yyyy";
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDate.Location = new System.Drawing.Point(94, 114);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.RightToLeftLayout = true;
            this.dtpDate.Size = new System.Drawing.Size(151, 22);
            this.dtpDate.TabIndex = 18;
            this.dtpDate.Value = new System.DateTime(2022, 3, 14, 16, 19, 47, 0);
            // 
            // dtpTime
            // 
            this.dtpTime.Location = new System.Drawing.Point(334, 115);
            this.dtpTime.Name = "dtpTime";
            this.dtpTime.Size = new System.Drawing.Size(153, 22);
            this.dtpTime.TabIndex = 19;
            // 
            // cboName
            // 
            this.cboName.FormattingEnabled = true;
            this.cboName.Location = new System.Drawing.Point(129, 55);
            this.cboName.Name = "cboName";
            this.cboName.Size = new System.Drawing.Size(190, 24);
            this.cboName.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 515);
            this.Controls.Add(this.cboName);
            this.Controls.Add(this.dtpTime);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnNhap);
            this.Controls.Add(this.btnOutput);
            this.Controls.Add(this.btnOutputAll);
            this.Controls.Add(this.btnInput);
            this.Controls.Add(this.btnInputAll);
            this.Controls.Add(this.rtbKetQua);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lsbChoose);
            this.Controls.Add(this.lsbInfo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox lsbInfo;
        private System.Windows.Forms.ListBox lsbChoose;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox rtbKetQua;
        private System.Windows.Forms.Button btnInputAll;
        private System.Windows.Forms.Button btnInput;
        private System.Windows.Forms.Button btnOutputAll;
        private System.Windows.Forms.Button btnOutput;
        private System.Windows.Forms.Button btnNhap;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.DateTimePicker dtpTime;
        private System.Windows.Forms.ComboBox cboName;
    }
}

