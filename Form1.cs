namespace BotonContador
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        int numero = 0;
        private void button1_Click(object sender, EventArgs e)
        {

            numero++;

            label1.Text = (numero).ToString();




        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            numero = 0;
            label1.Text = (numero).ToString();
        }
    }
}