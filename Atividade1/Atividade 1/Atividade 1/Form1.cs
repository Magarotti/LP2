using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCal_Click(object sender, EventArgs e)
        {
            double R, A, V;

            R = Convert.ToDouble(txtRaio.Text);
            A = Convert.ToDouble(txtAlt.Text);

            V = 3.14 * (R * R) * A;

            txtVol.Text = Convert.ToString(V);
        }

        private void txtRaio_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
