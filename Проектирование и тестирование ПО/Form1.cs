using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BL;
using ClassLibrary1;
using System.Windows.Forms;

namespace Проектирование_и_тестирование_ПО
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string surname = textBox1.Text;
            string name = textBox2.Text;
            string secondName = textBox3.Text;




            if (tabControl.SelectedIndex == 0 )
            {
                double oklad = Convert.ToDouble(textBox4.Text);
                double premiya = Convert.ToDouble(textBox5.Text);
                int categoria = Convert.ToInt32(textBox6.Text);
                Enginering a = new Enginering(1, surname, name, secondName, oklad, premiya, categoria);
                double b = a.Calc(oklad, premiya, categoria);
                label2.Text = Convert.ToString(b);

            }
            else if (tabControl.SelectedIndex == 1)
            {
                int countDetail = Convert.ToInt32(textBox7.Text);
                int countPerson = Convert.ToInt32(textBox8.Text);
                int Razr = Convert.ToInt32(textBox9.Text);

                Worker g = new Worker(1, surname, name, secondName, countDetail, countPerson, Razr);
                double f = g.Calc(countDetail, countPerson, Razr);
                label15.Text = Convert.ToString(f);
            }
            else
            {
                int countSdelka = Convert.ToInt32(textBox10.Text);
                double summDetail = Convert.ToDouble(textBox11.Text);
                double okladMin = Convert.ToDouble(textBox12.Text);
                Manager c = new Manager(1, surname, name, secondName, countSdelka, summDetail, okladMin);
                double d = c.Calc(countSdelka, summDetail, okladMin);
                label20.Text = Convert.ToString(d);
            }
        }




        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
 
