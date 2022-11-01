using System.Collections.Generic;
using System;
using System.Security.Cryptography.X509Certificates;
using logowanie.Properties;
using System.Reflection;
using System.Resources;

namespace logowanie
{
    public partial class Form1 : Form
    {


        List<String> lista = new List<string>() {
            "Image1",
            "Image2",
            "Image3",
            "Image4",
            "Image5",
            "Image6",
            "Image7"
        };
        class listahasla
        {
           static public string Key1 = "mxyxw";
           static public string Key2 = "b5nmn"; 
           static public string Key3 = "74853";
           static public string Key4 = "cg5dd";
           static public string Key5 = "x3deb";
           static public string Key6 = "befhd"; 
           static public string Key7 = "rc7gb3";
        
        };

        public string CaptchaHandler = "";

        public Form1()
        {
            InitializeComponent();
            //e
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void label5_Click(object sender, EventArgs e)
        {
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var rnd = new Random();
            int indexRandom = rnd.Next(lista.Count);

            ResourceManager rm = Resources.ResourceManager;
            Bitmap myImage = (Bitmap)rm.GetObject(lista[indexRandom]);

            pictureBox1.Image = myImage;


            if (lista[indexRandom] == "Image1") { CaptchaHandler = listahasla.Key1; }
            if (lista[indexRandom] == "Image2") { CaptchaHandler = listahasla.Key2; }
            if (lista[indexRandom] == "Image3") { CaptchaHandler = listahasla.Key3; }
            if (lista[indexRandom] == "Image4") { CaptchaHandler = listahasla.Key4; }
            if (lista[indexRandom] == "Image5") { CaptchaHandler = listahasla.Key5; }
            if (lista[indexRandom] == "Image6") { CaptchaHandler = listahasla.Key6; }
            if (lista[indexRandom] == "Image7") { CaptchaHandler = listahasla.Key7; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //listahasla[lista.Find(x =>  x.pictureBox1.Image)];
            //listahasla[lista.Find(x => x.pictureBox1.Image)] == 
            if (textBox1.Text == "admin" && textBox2.Text == "Qwerty1@34" && textBox3.Text == CaptchaHandler) {
                this.Hide();
                Form2 f2 = new Form2();  
                f2.ShowDialog();

            }
           
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var rnd = new Random();
            int indexRandom = rnd.Next(lista.Count);

            ResourceManager rm = Resources.ResourceManager;
            Bitmap myImage = (Bitmap)rm.GetObject(lista[indexRandom]);

            pictureBox1.Image = myImage;
            if (lista[indexRandom] == "Image1") { CaptchaHandler = listahasla.Key1; }
            if (lista[indexRandom] == "Image2") { CaptchaHandler = listahasla.Key2; }
            if (lista[indexRandom] == "Image3") { CaptchaHandler = listahasla.Key3; }
            if (lista[indexRandom] == "Image4") { CaptchaHandler = listahasla.Key4; }
            if (lista[indexRandom] == "Image5") { CaptchaHandler = listahasla.Key5; }
            if (lista[indexRandom] == "Image6") { CaptchaHandler = listahasla.Key6; }
            if (lista[indexRandom] == "Image7") { CaptchaHandler = listahasla.Key7; }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "admin" && textBox2.Text == "Qwerty1@34" && textBox3.Text == CaptchaHandler)
            {
                this.Hide();
                Form3 f3 = new Form3();
                f3.ShowDialog();

            }
        }
    }
}