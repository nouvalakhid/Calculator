using System;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHitung_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtNilaiA.Text);
            int b = int.Parse(txtNilaiB.Text);

            switch (cmbOperasi.Text)
            {
                case "Penambahan": txtHasil.Text = (a + b).ToString(); break;
                case "Pengurangan": txtHasil.Text = (a - b).ToString(); break;
                case "Perkalian": txtHasil.Text = (a * b).ToString(); break;
                case "Pembagian": txtHasil.Text = (a / b).ToString(); break;
            }
        }
    }
}
