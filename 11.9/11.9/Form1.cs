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
            this.Text = "Ukol 1";

            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
        }

        List<int> list1 = new List<int>();
        

     

        void Vypis(ListBox listbox, List<int> list)
        {
            listbox.Items.Clear();
            foreach (int i in list)
            {
                listbox.Items.Add(i);
            }
        }

        void Vypis(ListBox listbox, List<char> list)
        {
            listbox.Items.Clear();
            foreach (char c in list)
            {
                listbox.Items.Add(c);
            }
        }


        int DruheMax()
        {
            int max = list1[0];
            int max2 = list1[1];
            for (int i = 1; i < list1.Count(); i++)
            {
                if (list1[i] > max)
                {
                    max2 = max;
                    max = list1[i];
                }
                if (list1[i] > max2 && list1[i] < max)
                {
                    max2 = list1[i];
                }
            }

            return max2;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            try
            {
                Random rng = new Random();

                int n = int.Parse(textBox1.Text);
                list1.Clear();
                for (int i = 0; i < n; i++)
                {
                    list1.Add(rng.Next(-5, 101));
                }

                Vypis(listBox1, list1);

                button2.Visible = true;
                button3.Visible = true;
                button4.Visible = true;
                button5.Visible = true;
                button6.Visible = true;
                button7.Visible = true;
                listBox2.Items.Clear();
                listBox3.Items.Clear();
                listBox4.Items.Clear();
                label1.Text = "_";
                label2.Text = "_";
                label3.Text = "_";
            }
            catch(FormatException ex)
            {
                MessageBox.Show(ex.Message);
            }
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
            for (int i = 0; i < list1.Count(); i++)
            {
                Smazani(list1[i]);                
            }
            Vypis(listBox2, list1);
        }


        void Smazani(int cislo)
        {            
            if (Dokonale(cislo))
            {
                while (list1.Contains(cislo))
                {
                    list1.Remove(cislo);
                    //MessageBox.Show(cislo.ToString());
                }
            }
        }

        int CifernySoucet()
        {
            int cislo = list1.Max();
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
            list1.Sort();
            Vypis(listBox3, list1);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            label3.Text = Math.Round(list1.Average(),3).ToString();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            List<char> list2 = new List<char>();
          
            for(int i = 0; i < list1.Count();i++)
            {
                
                if(list1[i] >= 65 && list1[i] <= 90)
                {
                    char znak = Convert.ToChar(list1[i]);
                    list2.Add(znak);                   
                }
                else
                {
                    list2.Add('*');
                }
            }

            Vypis(listBox4, list2);
        }
    }



    
       


}

