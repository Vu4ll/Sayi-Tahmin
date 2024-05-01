namespace WinFormsApp1
{
    public partial class frmOyunEkrani : Form
    {
        public frmOyunEkrani()
        {
            InitializeComponent();
        }

        int rnd;
        Random r;
        int tahminSayisi = 0;

        private void frmOyunEkrani_Load(object sender, EventArgs e)
        {
            r = new Random();
            rnd = r.Next(1, 101);
        }

        private void btnTahmin_Click(object sender, EventArgs e)
        {
            tahminSayisi++;

            if (txtTahmin.Text.Length < 1)
            {
                MessageBox.Show("L�tfen bir say� giriniz", "Say� girilmedi");
            }

            int tahmin = int.Parse(txtTahmin.Text);

            if (tahmin == rnd)
            {
                var cevap = MessageBox.Show($"Do�ru tahmin ettiniz! {tahminSayisi} denemede bildiniz. Tekrar oynamak ister misiniz?", "Tebrikler", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (cevap == DialogResult.No)
                {
                    this.Close();
                }
                else if (cevap == DialogResult.Yes)
                {
                    rnd = r.Next(1, 101);
                    tahminSayisi = 0;
                }
            }
            else if (tahmin > rnd)
            {
                lblSonuc.Text = "Daha k���k bir say� giriniz";
            }
            else if (tahmin < rnd)
            {
                lblSonuc.Text = "Daha b�y�k bir say� giriniz";
            }
            txtTahmin.Text = "";
            txtTahmin.Focus();
        }

        private void txtTahmin_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnTahmin.PerformClick();
            }
        }

        private void frmOyunEkrani_Activated(object sender, EventArgs e)
        {
            txtTahmin.Focus();
        }
    }
}
