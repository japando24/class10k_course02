namespace PTB2
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            label1 = new Label();
            groupBox1 = new GroupBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            txtHeSoC = new TextBox();
            txtHeSoB = new TextBox();
            txtHeSoA = new TextBox();
            groupBox2 = new GroupBox();
            btnThoat = new Button();
            btnTiep = new Button();
            btnGiai = new Button();
            groupBox3 = new GroupBox();
            lblKetQua = new Label();
            label5 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.DarkCyan;
            label1.Location = new Point(206, 34);
            label1.Name = "label1";
            label1.Size = new Size(162, 20);
            label1.TabIndex = 0;
            label1.Text = "PHƯƠNG TRÌNH BẬC 2";
            label1.Click += label1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtHeSoC);
            groupBox1.Controls.Add(txtHeSoB);
            groupBox1.Controls.Add(txtHeSoA);
            groupBox1.Location = new Point(46, 57);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(479, 179);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Nhập các hệ số của phương trình:";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(22, 132);
            label4.Name = "label4";
            label4.Size = new Size(61, 20);
            label4.TabIndex = 3;
            label4.Text = "Hệ số c:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 84);
            label3.Name = "label3";
            label3.Size = new Size(63, 20);
            label3.TabIndex = 3;
            label3.Text = "Hệ số b:";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 41);
            label2.Name = "label2";
            label2.Size = new Size(62, 20);
            label2.TabIndex = 3;
            label2.Text = "Hệ số a:";
            // 
            // txtHeSoC
            // 
            txtHeSoC.Location = new Point(104, 129);
            txtHeSoC.Name = "txtHeSoC";
            txtHeSoC.Size = new Size(284, 27);
            txtHeSoC.TabIndex = 2;
            // 
            // txtHeSoB
            // 
            txtHeSoB.Location = new Point(104, 81);
            txtHeSoB.Name = "txtHeSoB";
            txtHeSoB.Size = new Size(284, 27);
            txtHeSoB.TabIndex = 1;
            // 
            // txtHeSoA
            // 
            txtHeSoA.Location = new Point(104, 38);
            txtHeSoA.Name = "txtHeSoA";
            txtHeSoA.Size = new Size(284, 27);
            txtHeSoA.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnThoat);
            groupBox2.Controls.Add(btnTiep);
            groupBox2.Controls.Add(btnGiai);
            groupBox2.Location = new Point(46, 251);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(479, 81);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Chọn chức năng:";
            // 
            // btnThoat
            // 
            btnThoat.Image = Properties.Resources.icon_close;
            btnThoat.ImageAlign = ContentAlignment.MiddleLeft;
            btnThoat.Location = new Point(294, 32);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(118, 43);
            btnThoat.TabIndex = 2;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnTiep
            // 
            btnTiep.Image = Properties.Resources.icon_next;
            btnTiep.ImageAlign = ContentAlignment.MiddleLeft;
            btnTiep.Location = new Point(160, 32);
            btnTiep.Name = "btnTiep";
            btnTiep.Size = new Size(112, 43);
            btnTiep.TabIndex = 1;
            btnTiep.Text = "Tiếp";
            btnTiep.UseVisualStyleBackColor = true;
            btnTiep.Click += btnTiep_Click_1;
            // 
            // btnGiai
            // 
            btnGiai.Image = Properties.Resources.icon_process;
            btnGiai.ImageAlign = ContentAlignment.MiddleLeft;
            btnGiai.Location = new Point(24, 32);
            btnGiai.Name = "btnGiai";
            btnGiai.Size = new Size(113, 43);
            btnGiai.TabIndex = 0;
            btnGiai.Text = "Giải";
            btnGiai.UseVisualStyleBackColor = true;
            btnGiai.Click += btnGiai_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(lblKetQua);
            groupBox3.Controls.Add(label5);
            groupBox3.Location = new Point(50, 343);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(475, 72);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "Kết quả:";
            groupBox3.Enter += groupBox3_Enter;
            // 
            // lblKetQua
            // 
            lblKetQua.BackColor = SystemColors.GradientInactiveCaption;
            lblKetQua.Location = new Point(6, 23);
            lblKetQua.Name = "lblKetQua";
            lblKetQua.Size = new Size(459, 41);
            lblKetQua.TabIndex = 0;
            lblKetQua.Text = "Result";
            lblKetQua.Click += lblKetQua_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(10, 28);
            label5.Name = "label5";
            label5.Size = new Size(0, 20);
            label5.TabIndex = 0;
            label5.Click += label5_Click;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(546, 450);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PTB2";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txtHeSoC;
        private TextBox txtHeSoB;
        private TextBox txtHeSoA;
        private GroupBox groupBox2;
        private Button btnThoat;
        private Button btnTiep;
        private Button btnGiai;
        private GroupBox groupBox3;
        private Label label5;
        private Label lblKetQua;
    }
}
