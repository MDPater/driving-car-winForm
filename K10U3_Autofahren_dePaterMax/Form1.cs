using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace K10U3_Autofahren_dePaterMax
{
    public partial class Form1 : Form
    {
        Auto PKW = new Auto();

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            PKW.Left = 0;
            this.Text = "Geschwindigkeit: " + PKW.KMH.ToString();
        }

        private void buttonFahren_Click(object sender, EventArgs e)
        {
            PKW.Fahren(panelStrasse);
        }

        private void buttonLangsamer_Click(object sender, EventArgs e)
        {
            PKW.KMH -= 10;
            this.Text = "Geschwindigkeit: " + PKW.KMH.ToString();
        }

        private void buttonSchneller_Click(object sender, EventArgs e)
        {
            PKW.KMH += 10;
            this.Text = "Geschwindigkeit: " + PKW.KMH.ToString();
        }

        private void buttonBeenden_Click(object sender, EventArgs e)
        {
            PKW.KMH = 0;
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PKW.KMH = 50;
            PKW.Location = new Point(0, panelStrasse.Height - 20);
            PKW.Size = new Size(50, 20);
            PKW.Text = "PKW";
            PKW.BackColor = Color.Red;
            panelStrasse.Controls.Add(PKW);
            this.Text = "Geschwindigkeit: " + PKW.KMH.ToString();
        }
    }
}
