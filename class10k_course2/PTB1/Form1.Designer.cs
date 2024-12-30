namespace PTB1
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
            txtHeSoa = new TextBox();
            label3 = new Label();
            txtHeSob = new TextBox();
            label4 = new Label();
            txtKetQua = new TextBox();
            btnGiai = new Button();
            btnTiep = new Button();
            btnThoat = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("UD Digi Kyokasho NK-B", 9F, FontStyle.Bold, GraphicsUnit.Point, 128);
            label1.Location = new Point(169, 58);
            label1.Name = "label1";
            label1.Size = new Size(184, 17);
            label1.TabIndex = 0;
            label1.Text = "PHƯƠNG TRÌNH BẬC 1";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(47, 97);
            label2.Name = "label2";
            label2.Size = new Size(62, 20);
            label2.TabIndex = 1;
            label2.Text = "Hệ số a:";
            // 
            // txtHeSoa
            // 
            txtHeSoa.Location = new Point(115, 97);
            txtHeSoa.Name = "txtHeSoa";
            txtHeSoa.Size = new Size(308, 27);
            txtHeSoa.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(47, 148);
            label3.Name = "label3";
            label3.Size = new Size(63, 20);
            label3.TabIndex = 1;
            label3.Text = "Hệ số b:";
            label3.Click += label3_Click;
            // 
            // txtHeSob
            // 
            txtHeSob.Location = new Point(115, 141);
            txtHeSob.Name = "txtHeSob";
            txtHeSob.Size = new Size(308, 27);
            txtHeSob.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(47, 195);
            label4.Name = "label4";
            label4.Size = new Size(63, 20);
            label4.TabIndex = 1;
            label4.Text = "Kết quả:";
            label4.Click += label3_Click;
            // 
            // txtKetQua
            // 
            txtKetQua.Location = new Point(115, 188);
            txtKetQua.Name = "txtKetQua";
            txtKetQua.Size = new Size(308, 27);
            txtKetQua.TabIndex = 2;
            // 
            // btnGiai
            // 
            btnGiai.Image = Properties.Resources.icon_process;
            btnGiai.ImageAlign = ContentAlignment.MiddleLeft;
            btnGiai.Location = new Point(118, 238);
            btnGiai.Name = "btnGiai";
            btnGiai.Size = new Size(85, 42);
            btnGiai.TabIndex = 3;
            btnGiai.Text = "Giải";
            btnGiai.TextAlign = ContentAlignment.MiddleRight;
            btnGiai.UseVisualStyleBackColor = true;
            btnGiai.Click += btnGiai_Click;
            // 
            // btnTiep
            // 
            btnTiep.Image = Properties.Resources.icon_next;
            btnTiep.ImageAlign = ContentAlignment.MiddleLeft;
            btnTiep.Location = new Point(226, 238);
            btnTiep.Name = "btnTiep";
            btnTiep.Size = new Size(87, 42);
            btnTiep.TabIndex = 3;
            btnTiep.Text = "Tiếp";
            btnTiep.TextAlign = ContentAlignment.MiddleRight;
            btnTiep.UseVisualStyleBackColor = true;
            btnTiep.Click += btnTiep_Click;
            // 
            // btnThoat
            // 
            btnThoat.Image = Properties.Resources.icon_close;
            btnThoat.ImageAlign = ContentAlignment.TopLeft;
            btnThoat.Location = new Point(329, 238);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(94, 42);
            btnThoat.TabIndex = 3;
            btnThoat.Text = "Thoát";
            btnThoat.TextAlign = ContentAlignment.MiddleRight;
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += button1_Click;
            // 
            // Form1
            // 
            AcceptButton = btnGiai;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnThoat;
            ClientSize = new Size(486, 318);
            Controls.Add(btnThoat);
            Controls.Add(btnTiep);
            Controls.Add(btnGiai);
            Controls.Add(txtKetQua);
            Controls.Add(label4);
            Controls.Add(txtHeSob);
            Controls.Add(label3);
            Controls.Add(txtHeSoa);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtHeSoa;
        private Label label3;
        private TextBox txtHeSob;
        private Label label4;
        private TextBox txtKetQua;
        private Button btnGiai;
        private Button btnTiep;
        private Button btnThoat;
    }
}
