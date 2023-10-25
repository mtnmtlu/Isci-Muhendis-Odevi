namespace hafta1ybs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }



        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void yas_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Personel prs1 = new Personel();
            prs1.Ad = adTxt.Text;
            prs1.Adres = adresTxt.Text;
            prs1.Yas = Convert.ToInt32(yas.Text);
            prs1.Mesai = Convert.ToInt32(mesTxt.Text);
            MessageBox.Show("Ad=" + prs1.Ad + "\nAdres=" + prs1.Adres + "\nYaþ=" + prs1.Yas);

            if (unvanTxt.Text == "Ýþçi")
            {
                MessageBox.Show(prs1.ucretHesapla().ToString());
            }
            else
            {
                prs1.ucretHesapla(1000);
            }




        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}