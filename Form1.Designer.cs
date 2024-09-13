namespace nguyenVanTan_Buoi3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            txtcd = new TextBox();
            txtcr = new TextBox();
            btnnhap = new Button();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            txtmasv = new TextBox();
            txthoten = new TextBox();
            txtsdt = new TextBox();
            txtgioitinh = new TextBox();
            btnnhap2 = new Button();
            dtpngaysinh = new DateTimePicker();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(121, 68);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 0;
            label1.Text = "Chiều dài :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(121, 120);
            label2.Name = "label2";
            label2.Size = new Size(72, 15);
            label2.TabIndex = 1;
            label2.Text = "Chiều rộng :";
            // 
            // txtcd
            // 
            txtcd.Location = new Point(224, 68);
            txtcd.Name = "txtcd";
            txtcd.Size = new Size(100, 23);
            txtcd.TabIndex = 2;
            // 
            // txtcr
            // 
            txtcr.Location = new Point(223, 117);
            txtcr.Name = "txtcr";
            txtcr.Size = new Size(100, 23);
            txtcr.TabIndex = 3;
            // 
            // btnnhap
            // 
            btnnhap.Location = new Point(381, 112);
            btnnhap.Name = "btnnhap";
            btnnhap.Size = new Size(75, 23);
            btnnhap.TabIndex = 4;
            btnnhap.Text = "Nhập";
            btnnhap.UseVisualStyleBackColor = true;
            btnnhap.Click += btnnhap_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(120, 195);
            label3.Name = "label3";
            label3.Size = new Size(10, 15);
            label3.TabIndex = 5;
            label3.Text = " ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(114, 235);
            label4.Name = "label4";
            label4.Size = new Size(50, 15);
            label4.TabIndex = 6;
            label4.Text = "Họ Tên :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(114, 271);
            label5.Name = "label5";
            label5.Size = new Size(66, 15);
            label5.TabIndex = 7;
            label5.Text = "Ngày sinh :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(114, 303);
            label6.Name = "label6";
            label6.Size = new Size(36, 15);
            label6.TabIndex = 8;
            label6.Text = "SĐT  :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(114, 340);
            label7.Name = "label7";
            label7.Size = new Size(60, 15);
            label7.TabIndex = 9;
            label7.Text = "Giới Tính :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(114, 203);
            label8.Name = "label8";
            label8.Size = new Size(82, 15);
            label8.TabIndex = 10;
            label8.Text = "Mã Sinh Viên :";
            // 
            // txtmasv
            // 
            txtmasv.Location = new Point(233, 200);
            txtmasv.Name = "txtmasv";
            txtmasv.Size = new Size(100, 23);
            txtmasv.TabIndex = 11;
            // 
            // txthoten
            // 
            txthoten.Location = new Point(233, 234);
            txthoten.Name = "txthoten";
            txthoten.Size = new Size(100, 23);
            txthoten.TabIndex = 12;
            // 
            // txtsdt
            // 
            txtsdt.Location = new Point(233, 295);
            txtsdt.Name = "txtsdt";
            txtsdt.Size = new Size(100, 23);
            txtsdt.TabIndex = 14;
            // 
            // txtgioitinh
            // 
            txtgioitinh.Location = new Point(233, 332);
            txtgioitinh.Name = "txtgioitinh";
            txtgioitinh.Size = new Size(100, 23);
            txtgioitinh.TabIndex = 15;
            // 
            // btnnhap2
            // 
            btnnhap2.Location = new Point(487, 271);
            btnnhap2.Name = "btnnhap2";
            btnnhap2.Size = new Size(75, 23);
            btnnhap2.TabIndex = 16;
            btnnhap2.Text = "Nhập 2";
            btnnhap2.UseVisualStyleBackColor = true;
            btnnhap2.Click += btnnhap2_Click;
            // 
            // dtpngaysinh
            // 
            dtpngaysinh.Location = new Point(233, 263);
            dtpngaysinh.Name = "dtpngaysinh";
            dtpngaysinh.Size = new Size(200, 23);
            dtpngaysinh.TabIndex = 17;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dtpngaysinh);
            Controls.Add(btnnhap2);
            Controls.Add(txtgioitinh);
            Controls.Add(txtsdt);
            Controls.Add(txthoten);
            Controls.Add(txtmasv);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(btnnhap);
            Controls.Add(txtcr);
            Controls.Add(txtcd);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtcd;
        private TextBox txtcr;
        private Button btnnhap;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox txtmasv;
        private TextBox txthoten;
        private TextBox txtsdt;
        private TextBox txtgioitinh;
        private Button btnnhap2;
        private DateTimePicker dtpngaysinh;
    }
}
