using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace logowanie
{

    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        List<string> items = new List<string>();
        public static string path = @"C:\\Users\\Administrator\\source\\repos\\mi3teQ\\logowanie\\uczen.txt";
        private void Form1_Load(object sender, EventArgs e)
        {
            

            foreach (string str in items)
            {
                listBox1.Items.Add(str);
            }//alexiej sudzikow to pedzio i gej i ma fajna mame :DDDDDDDD
        }



        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            File.AppendAllText(path, textBox1.Text.ToString() + " " + textBox2.Text.ToString() + " " + textBox3.Text.ToString() + Environment.NewLine);
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<string> lwords = File.ReadAllText(path).Split(' ', '\n').ToList(); //zmien temp na usera przed oddaniem pracy

            //listBox1.DataSource = lwords;


            listBox1.Items.Clear();
                foreach (string line in File.ReadLines(path))
                {
                    listBox1.Items.Add(line);
                }
            if (comboBox1.SelectedIndex == 0)
            {
                if (comboBox2.SelectedIndex == 0)
                {
                    listBox1.Items.Clear();
                    for (int i = 0; i < lwords.Count; i += 3)
                    {
                        if (string.Equals(lwords[i], (textBox4.Text)))
                        {
                            listBox1.Items.Add(lwords[i] + " " + lwords[i + 1] + " " + lwords[i + 2]);
                        }
                    }
                }
                else if (comboBox2.SelectedIndex == 1)
                {
                    listBox1.Items.Clear();
                    for (int i = 0; i < lwords.Count; i += 3)
                    {
                        if (lwords[i].Contains(textBox4.Text))
                        {
                            listBox1.Items.Add(lwords[i] + " " + lwords[i + 1] + " " + lwords[i + 2]);
                        }
                    }
                }
                else if (comboBox2.SelectedIndex == 2)
                {
                    listBox1.Items.Clear();
                    for (int i = 0; i < lwords.Count; i += 3)
                    {
                        if (lwords[i].StartsWith(textBox4.Text))
                        {
                            listBox1.Items.Add(lwords[i] + " " + lwords[i + 1] + " " + lwords[i + 2]);
                        }
                    }
                }
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                if (comboBox2.SelectedIndex == 0)
                {
                    listBox1.Items.Clear();
                    for (int i = 1; i < lwords.Count; i += 3)
                    {
                        if (string.Equals(lwords[i], (textBox4.Text)))
                        {
                            listBox1.Items.Add(lwords[i - 1] + " " + lwords[i] + " " + lwords[i + 1]);
                        }
                    }
                }
                else if (comboBox2.SelectedIndex == 1)
                {
                    listBox1.Items.Clear();
                    for (int i = 1; i < lwords.Count; i += 3)
                    {
                        if (lwords[i].Contains(textBox4.Text))
                        {
                            listBox1.Items.Add(lwords[i - 1] + " " + lwords[i] + " " + lwords[i + 1]);
                        }
                    }
                }
                else if (comboBox2.SelectedIndex == 2)
                {
                    listBox1.Items.Clear();
                    for (int i = 1; i < lwords.Count; i += 3)
                    {
                        if (lwords[i].StartsWith(textBox4.Text))
                        {
                            listBox1.Items.Add(lwords[i - 1] + " " + lwords[i] + " " + lwords[i + 1]);
                        }
                    }
                }
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                if (comboBox2.SelectedIndex == 0)
                {
                    listBox1.Items.Clear();
                    for (int i = 2; i < lwords.Count; i += 3)
                    {
                        if (string.Equals(lwords[i], (textBox4.Text)))
                        {
                            listBox1.Items.Add(lwords[i - 2] + " " + lwords[i - 1] + " " + lwords[i]);
                        }
                    }
                }
                else if (comboBox2.SelectedIndex == 1)
                {
                    listBox1.Items.Clear();
                    for (int i = 2; i < lwords.Count; i += 3)
                    {
                        if (lwords[i].Contains(textBox4.Text))
                        {
                            listBox1.Items.Add(lwords[i - 2] + " " + lwords[i - 1] + " " + lwords[i]);
                        }
                    }
                }
                else if (comboBox2.SelectedIndex == 2)
                {
                    listBox1.Items.Clear();
                    for (int i = 2; i < lwords.Count; i += 3)
                    {
                        if (lwords[i].StartsWith(textBox4.Text))
                        {
                            listBox1.Items.Add(lwords[i - 2] + " " + lwords[i - 1] + " " + lwords[i]);
                        }
                    }
                }
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

            /*if(comboBox2.SelectedText == "Rozpoczyna sie")
            {

                listBox1.Items.Clear();

                foreach (string str in items)
                {
                if (str.StartsWith(textBox1.Text, StringComparison.CurrentCultureIgnoreCase))
                {
                        listBox1.Items.Add(str);
                    }

                }
            }*/

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
