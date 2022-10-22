using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExPag32
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtdigitenum_TextChanged(object sender, EventArgs e)
        {

        }

        private void btncalcular_Click(object sender, EventArgs e)
        {

            int a;

            a = int.Parse(txtdigitenum.Text);
           
            switch (a)
            {
                case 0: txtresultado.Text = "Zero"; break;   
                case 1: txtresultado.Text = "Um"; break;
                case 2: txtresultado.Text = "Dois"; break;
                case 3: txtresultado.Text = "Três"; break;
                case 4: txtresultado.Text = "Quatro"; break;
                case 5: txtresultado.Text = "Cinco"; break;

                default: txtresultado.Text = "Fora do intervalo!!!"; break;





            }















        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lblresultado_Click(object sender, EventArgs e)
        {

        }
    }
}
