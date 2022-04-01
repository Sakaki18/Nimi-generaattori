using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        int kertoja = 0;
        int Kertoja2 = 0;
        public Form1()
        {
            InitializeComponent();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            kertoja = kertoja + 1;
            label1.Visible = true;
            Random rnd = new Random();
            int numero = rnd.Next(1, 9999);
            int numero2 = rnd.Next(0, 20);
            int numero3 = rnd.Next(0, 21);
            String SeTeksti = Convert.ToString(numero);
            if (SeTeksti.Contains("69"))
            {
                Kertoja2 = Kertoja2 + 1;
            }
            string[] sanat = { "Ripuli", "Paska", "Uloste", "Kakka", "Auto", "Penis", "Fortnite", "Kissa", "Koira", "Ultimate", "Mega", "Super", "Hyper", "Musta", "Äänekäs", "Haastava", "Hurja", "Hirmuinen", "Kypsä", "Ilmava", "Kuuma"};
            string[] sanat2 = { "tuhooja", "mörssääjä", "haistelia", "safkaaja", "pelaaja", "nautiskelia", "jonne", "pedofiili", "Nainen", "hakkaaja", "ripuloija", "seksuaaliahdistelia", "rypyreikä", "tappaja", "riisuja","aivastelia", "bilettäjä", "homo", "rantapallo", "harrastelia", "hikeentyjä", "homostelia", };
            string[] words = { "Diarrhea", "Shit", "Excrement", "Poop", "Car", "Penis", "Fortnite", "Cat", "Dog", "Ultimate", "Mega", "Super", "Hyper", "Black", "Loud", "Challenging", "Crazy", "Terrible", "Ripe", "Airy", "´Hot" };
            string[] words2 = { "destroyer", "mortar", "sniffer", "eater", "player", "enjoyer", "jonne", "pedofile", "woman", "batterer", "diarrhea", "sexualharassment", "asshole", "killer", "undresser", "sneezer", "partyer", "gay", "beachball", "hobbyist", "sweat", "faggot", };
            if (radioButton1.Checked == true)
            {
                label1.Text = sanat[numero2] + sanat2[numero3] + SeTeksti;
            }
            if (radioButton2.Checked == true)
            {
                label1.Text = words[numero2] + words2[numero3] + SeTeksti;
            }





            label3.Text = Convert.ToString(kertoja);
            label5.Text = Convert.ToString(Kertoja2);
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Visible = false;
            label3.Text = Convert.ToString(kertoja);
            label5.Text = Convert.ToString(Kertoja2);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
