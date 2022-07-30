using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Semana2Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            est1.Text=("Farid Ernesto Claros Arias");
            est2.Text = ("Ana Patricia Gaitan");
            est3.Text = ("Elias Guevara");
            est4.Text = ("Xiomara Machado");
            est5.Text = ("Cristian Nolasco");
            est6.Text = ("Carin Sanchez");
        }

        private void est1_Click(object sender, EventArgs e)
        {

        }
    }
}
