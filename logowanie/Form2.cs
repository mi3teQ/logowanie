using System;
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
       
        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            File.AppendAllText(@"C:\Users\TEMP\source\repos\logowanieee\uczen.txt", textBox1.Text.ToString() + " " + textBox2.Text.ToString() + " " + textBox3.Text.ToString() + Environment.NewLine);
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.DataSource = File.ReadAllLines("C:\\Users\\TEMP\\source\\repos\\logowanieee\\uczen.txt");

           
        }
    }
}
