using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExPag33
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnverificar_Click(object sender, EventArgs e)
        {

            string opcao;

            opcao = txtvalor.Text;

            switch (opcao)
            {

                case "a": txtresultado.Text = "Opção A escolhida"; break;
                case "b": txtresultado.Text = "Opção B escolhida"; break;
                case "c": txtresultado.Text = "Opção C escolhida"; break;
                default: txtresultado.Text = "Opção inválida!!"; break;


            }













        }

        private void lblinserir_Click(object sender, EventArgs e)
        {

        }
    }
}
