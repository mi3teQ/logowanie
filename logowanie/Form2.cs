using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        private void Form1_Load(object sender, EventArgs e)
        {
            

            foreach (string str in items)
            {
                listBox1.Items.Add(str);
            }
        }



        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            File.AppendAllText(@"C:\\Users\\Temp\\source\\repos\\mi3teQ\\logowaniee\\uczen.txt", textBox1.Text.ToString() + " " + textBox2.Text.ToString() + " " + textBox3.Text.ToString() + Environment.NewLine);
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<string> StachuPacz = File.ReadAllLines("C:\\Users\\Temp\\source\\repos\\mi3teQ\\logowaniee\\uczen.txt").ToList(); //zmien temp na usera przed oddaniem pracy

            listBox1.DataSource = StachuPacz;
           
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
    }
}
