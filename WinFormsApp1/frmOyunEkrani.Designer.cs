namespace WinFormsApp1
{
    partial class frmOyunEkrani
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
            txtTahmin = new TextBox();
            btnTahmin = new Button();
            lblSonuc = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(32, 43);
            label1.Name = "label1";
            label1.Size = new Size(237, 28);
            label1.TabIndex = 0;
            label1.Text = "Tahmininizi giriniz (1-100)";
            // 
            // txtTahmin
            // 
            txtTahmin.Location = new Point(32, 90);
            txtTahmin.Name = "txtTahmin";
            txtTahmin.Size = new Size(237, 27);
            txtTahmin.TabIndex = 1;
            txtTahmin.KeyUp += txtTahmin_KeyUp;
            // 
            // btnTahmin
            // 
            btnTahmin.Location = new Point(103, 138);
            btnTahmin.Name = "btnTahmin";
            btnTahmin.Size = new Size(94, 29);
            btnTahmin.TabIndex = 2;
            btnTahmin.Text = "Tahmin Et";
            btnTahmin.UseVisualStyleBackColor = true;
            btnTahmin.Click += btnTahmin_Click;
            // 
            // lblSonuc
            // 
            lblSonuc.AutoSize = true;
            lblSonuc.Font = new Font("Segoe UI", 12F);
            lblSonuc.Location = new Point(32, 202);
            lblSonuc.Name = "lblSonuc";
            lblSonuc.Size = new Size(0, 28);
            lblSonuc.TabIndex = 3;
            lblSonuc.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // frmOyunEkrani
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(349, 353);
            Controls.Add(lblSonuc);
            Controls.Add(btnTahmin);
            Controls.Add(txtTahmin);
            Controls.Add(label1);
            Name = "frmOyunEkrani";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sayı Tahmin Oyunu";
            Activated += frmOyunEkrani_Activated;
            Load += frmOyunEkrani_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtTahmin;
        private Button btnTahmin;
        private Label lblSonuc;
    }
}
