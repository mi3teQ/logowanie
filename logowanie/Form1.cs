namespace logowanie
{
    public partial class Form1 : Form
    {

        List<Bitmap> lista = new List<Bitmap>() {
            global::logowanie.Properties.Resources._1,
            global::logowanie.Properties.Resources._2,
            global::logowanie.Properties.Resources._3,
            global::logowanie.Properties.Resources._4,
            global::logowanie.Properties.Resources._5,
            global::logowanie.Properties.Resources._6,
            global::logowanie.Properties.Resources._7,
        };
        List<string> listahasla = new List<string>()
        { 
           "mxyxw","b5nmn","74853","cg5dd","x3deb","befhd","rc7gb3"
        };
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void label5_Click(object sender, EventArgs e)
        {
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pictureBox1.Image = lista[new Random().Next(7)];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //  listahasla[lista.Find(x =>  x.pictureBox1.Image)]==haslo;
        }
    }
}