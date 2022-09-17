using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlocDeNotas
{
    public partial class Form3 : Form
    {
        Form1 principal;
        public bool quiere;
        public Form3()
        {
            InitializeComponent();
            label1.Text = "Desea sobreescribir?";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            quiere= true;
        }
        public void setPadre( Form1 padre)
        {
            this.principal = padre;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            quiere = false;
        }
    }
}
