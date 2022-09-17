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
    public partial class Form2 : Form
    {
        Form1 principal;
        public Form2()
        {
            InitializeComponent();
            label1.Text = "Desea guardar";
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }
        public void setPrincipal(Form1 padre)
        {
            this.principal = padre;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            principal.guardarComo();
            principal.Hide();   
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            principal.Close();
            this.Close();
        }
    }
}
