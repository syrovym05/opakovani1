using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace _11._9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.CenterToScreen();
            this.ShowIcon = false;
        }

        List<int> listek = new List<int>();
        Random rng = new Random();

     

        void Vypis(ListBox listbox)
        {
            listbox.Items.Clear();
            foreach (int i in listek)
            {
                listbox.Items.Add(i);
            }
        }


        int DruheMax()
        {
            int max = listek[0];
            int max2 = listek[1];
            for (int i = 1; i < listek.Count(); i++)
            {
                if (listek[i] > max)
                {
                    max2 = max;
                    max = listek[i];
                }
                if (listek[i] > max2 && listek[i] < max)
                {
                    max2 = listek[i];
                }
            }

            return max2;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            int n = int.Parse(textBox1.Text);
            listek.Clear();
            for (int i = 0; i < n; i++)
            {
                listek.Add(rng.Next(-5,101));
            }

            Vypis(listBox1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = DruheMax().ToString();
        }

        bool Dokonale(int x)
        {
            int soucet = 1;
            for (int i = 2; i <= x / 2; i++)
            {
                if (x % i == 0)
                {
                    soucet += i;
                }
            }

           // MessageBox.Show(soucet.ToString());
            return soucet == x ? true : false;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listek.Count(); i++)
            {
                int cislo = listek[i];
                if (Dokonale(cislo))
                {
                    while (listek.Contains(cislo))
                    {
                        listek.Remove(cislo);
                        MessageBox.Show(cislo.ToString());
                    }
                }
            }
            Vypis(listBox2);
            
        }

        int CifernySoucet()
        {
            int cislo = listek.Max();
            int soucet = 0;
            while(cislo >0)
            {
                soucet += cislo % 10;
                cislo /= 10;
            }

            return soucet;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            label2.Text = CifernySoucet().ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            listek.Sort();
            Vypis(listBox3);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            label3.Text = listek.Average().ToString();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            List<char> list2 = listek;
              
        }
    }



    
       


}

