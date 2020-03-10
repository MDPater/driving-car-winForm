using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace K10U3_Autofahren_dePaterMax
{
    class Auto : System.Windows.Forms.Button
    {
        private int Geschwindigkeit;

        public int KMH
        {
            get { return Geschwindigkeit; }
            set
            {
                if (value > 100)
                    value = 100;
                if (value < 0)
                    value = 0;

                this.Geschwindigkeit = value;
            }
        }

        public void Fahren(Panel weg)
        {
            while ((this.Left < weg.Width - this.Width) && (this.Geschwindigkeit > 0))
            {
                this.Left++;
                Application.DoEvents();
                System.Threading.Thread.Sleep(100 - this.Geschwindigkeit);
            }
        }
    }
}
