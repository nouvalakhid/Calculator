namespace WindowsFormsApp3
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblOperasi = new System.Windows.Forms.Label();
            this.lblNilaiA = new System.Windows.Forms.Label();
            this.lblNilaiB = new System.Windows.Forms.Label();
            this.lblHasil = new System.Windows.Forms.Label();
            this.cmbOperasi = new System.Windows.Forms.ComboBox();
            this.txtNilaiA = new System.Windows.Forms.TextBox();
            this.txtNilaiB = new System.Windows.Forms.TextBox();
            this.txtHasil = new System.Windows.Forms.TextBox();
            this.btnHitung = new System.Windows.Forms.Button();
            this.SuspendLayout();


            this.lblOperasi.AutoSize = true;
            this.lblOperasi.Location = new System.Drawing.Point(20, 22);
            this.lblOperasi.Name = "lblOperasi";
            this.lblOperasi.Size = new System.Drawing.Size(45, 13);
            this.lblOperasi.TabIndex = 0;
            this.lblOperasi.Text = "Operasi";


            this.lblNilaiA.AutoSize = true;
            this.lblNilaiA.Location = new System.Drawing.Point(20, 62);
            this.lblNilaiA.Name = "lblNilaiA";
            this.lblNilaiA.Size = new System.Drawing.Size(40, 13);
            this.lblNilaiA.TabIndex = 1;
            this.lblNilaiA.Text = "Nilai A";


            this.lblNilaiB.AutoSize = true;
            this.lblNilaiB.Location = new System.Drawing.Point(20, 90);
            this.lblNilaiB.Name = "lblNilaiB";
            this.lblNilaiB.Size = new System.Drawing.Size(40, 13);
            this.lblNilaiB.TabIndex = 2;
            this.lblNilaiB.Text = "Nilai B";


            this.lblHasil.AutoSize = true;
            this.lblHasil.Location = new System.Drawing.Point(20, 118);
            this.lblHasil.Name = "lblHasil";
            this.lblHasil.Size = new System.Drawing.Size(31, 13);
            this.lblHasil.TabIndex = 3;
            this.lblHasil.Text = "Hasil";


            this.cmbOperasi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOperasi.FormattingEnabled = true;
            this.cmbOperasi.Items.AddRange(new object[] {
            "Penambahan",
            "Pengurangan",
            "Perkalian",
            "Pembagian"});
            this.cmbOperasi.Location = new System.Drawing.Point(80, 19);
            this.cmbOperasi.Name = "cmbOperasi";
            this.cmbOperasi.Size = new System.Drawing.Size(150, 21);
            this.cmbOperasi.TabIndex = 4;


            this.txtNilaiA.Location = new System.Drawing.Point(80, 59);
            this.txtNilaiA.Name = "txtNilaiA";
            this.txtNilaiA.Size = new System.Drawing.Size(150, 20);
            this.txtNilaiA.TabIndex = 5;


            this.txtNilaiB.Location = new System.Drawing.Point(80, 87);
            this.txtNilaiB.Name = "txtNilaiB";
            this.txtNilaiB.Size = new System.Drawing.Size(150, 20);
            this.txtNilaiB.TabIndex = 6;


            this.txtHasil.Location = new System.Drawing.Point(80, 115);
            this.txtHasil.Name = "txtHasil";
            this.txtHasil.ReadOnly = true;
            this.txtHasil.Size = new System.Drawing.Size(150, 20);
            this.txtHasil.TabIndex = 7;


            this.btnHitung.Location = new System.Drawing.Point(80, 148);
            this.btnHitung.Name = "btnHitung";
            this.btnHitung.Size = new System.Drawing.Size(90, 25);
            this.btnHitung.TabIndex = 8;
            this.btnHitung.Text = "Hitung";
            this.btnHitung.UseVisualStyleBackColor = true;
            this.btnHitung.Click += new System.EventHandler(this.btnHitung_Click);


            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 195);
            this.Controls.Add(this.btnHitung);
            this.Controls.Add(this.txtHasil);
            this.Controls.Add(this.txtNilaiB);
            this.Controls.Add(this.txtNilaiA);
            this.Controls.Add(this.cmbOperasi);
            this.Controls.Add(this.lblHasil);
            this.Controls.Add(this.lblNilaiB);
            this.Controls.Add(this.lblNilaiA);
            this.Controls.Add(this.lblOperasi);
            this.Name = "Form1";
            this.Text = "Aplikasi Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        private System.Windows.Forms.Label lblOperasi;
        private System.Windows.Forms.Label lblNilaiA;
        private System.Windows.Forms.Label lblNilaiB;
        private System.Windows.Forms.Label lblHasil;
        private System.Windows.Forms.ComboBox cmbOperasi;
        private System.Windows.Forms.TextBox txtNilaiA;
        private System.Windows.Forms.TextBox txtNilaiB;
        private System.Windows.Forms.TextBox txtHasil;
        private System.Windows.Forms.Button btnHitung;
    }
}
