namespace Project3._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value += 10;
            label5.Text = progressBar1.Value.ToString() + "%";
            if (progressBar1.Value % 20 == 10)
            {
                label1.BackColor = Color.Red;
            }
            if (progressBar1.Value % 20 == 0)
            {
                label1.BackColor = Color.Transparent;
            }
            if (progressBar1.Value == 100)
            {
                timer1.Stop();

                label5.Text = "Loading Complete!";
                label5.ForeColor = Color.Green;
                label5.Visible = true;
                progressBar1.Visible = false;

                timer2.Start();
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            progressBar2.Value += 5;
            label6.Text = progressBar2.Value.ToString() + "%";
            if (progressBar2.Value % 10 == 5)
            {
                label2.BackColor = Color.Red;
            }
            if (progressBar2.Value % 10 == 0)
            {
                label2.BackColor = Color.Transparent;
            }
            if (progressBar2.Value == 100)
            {
                timer2.Stop();
                label6.Text = "Loading Complete!";
                label6.ForeColor = Color.Green;
                label6.Visible = true;
                progressBar2.Visible = false;
                timer3.Start();
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            progressBar3.Value += 10;
            label7.Text = progressBar3.Value.ToString() + "%";
            if (progressBar3.Value % 20 == 10)
            {
                label3.BackColor = Color.Red;
            }
            if (progressBar3.Value % 20 == 0)
            {
                label3.BackColor = Color.Transparent;
            }
            if (progressBar3.Value == 100)
            {
                timer3.Stop();
                label7.Text = "Loading Complete!";
                label7.ForeColor = Color.Green;
                label7.Visible = true;
                progressBar3.Visible = false;
                timer4.Start();
            }
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            progressBar4.Value += 2;
            label8.Text = progressBar4.Value.ToString() + "%";
            if (progressBar4.Value % 2 == 1)
            {
                label4.BackColor = Color.Red;
            }
            if (progressBar4.Value % 2 == 0)
            {
                label4.BackColor = Color.Transparent;
            }
            if (progressBar4.Value == 100)
            {
                timer4.Stop();
                label8.Text = "Loading Complete!";
                label8.ForeColor = Color.Green;
                label8.Visible = true;
                progressBar4.Visible = false;
            }
            if (progressBar4.Value == 100)
            {
                MessageBox.Show("All loading complete!");
                label5.Visible = false;
                label6.Visible = false;
                label7.Visible = false;
                label8.Visible = false;
                progressBar1.Visible = true;
                progressBar2.Visible = true;
                progressBar3.Visible = true;
                progressBar4.Visible = true;
            }
        }
    }
}