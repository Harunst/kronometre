namespace kronometre
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
        int saniye = 0, salise = 0, saat = 0, dakika = 0;

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(saat + ":" + dakika + ":" + saniye + ":" + salise);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            saniye = 0;
            saat = 0;
            dakika = 0;
            salise = 0;
            button1.Focus();
            label6.Text = "0";
            label7.Text = "0";
            label8.Text = "0";
            label9.Text = "0";
            timer1.Stop();
            listBox1.Items.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            listBox1.Items.Add(saat + ":" + dakika + ":" + saniye + ":" + salise);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            salise++;
            if(salise==60)
            {
                salise= 0;
                saniye++;

            }
            if(saniye==60)
            {
                saniye= 0;
                dakika++;

            }
            if (dakika == 60)
            {
                dakika = 0;
                saat++;
            }
            label6.Text = saat.ToString();
            label7.Text = dakika.ToString();
            label8.Text = saniye.ToString();
            label9.Text=salise.ToString();
        }   
    }
}