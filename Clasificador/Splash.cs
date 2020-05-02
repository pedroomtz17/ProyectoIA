using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clasificador
{
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Incremento de barra
            progressBar1.Increment(1);
            //si llega al maximo paramos el timer
            if (progressBar1.Value == 100)
                timer1.Stop();
        }
    }
}
