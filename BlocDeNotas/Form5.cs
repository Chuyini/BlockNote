using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlocDeNotas
{
    public partial class Form5 : Form
    {
        Form1 principal;
        public Form5()
        {
            InitializeComponent();
        }

        private void Buscar_Click(object sender, EventArgs e)
        {
            int indice;
            string palabraEncontrada;
            string texto;
            string remplazador=textBox2.Text;
           


            
            if (principal.textBox1.Text.Contains(textBox1.Text))
            {
                
                indice =principal.textBox1.Text.IndexOf(textBox1.Text);
                palabraEncontrada = principal.textBox1.Text.Substring(indice,textBox1.TextLength);
                texto=principal.textBox1.Text.ToString();

                texto=texto.Remove(indice,textBox1.TextLength);

                texto = texto.Insert(indice, remplazador);

                principal.textBox1.Text =texto;
                
                MessageBox.Show(palabraEncontrada);
            }
            else
            {
                MessageBox.Show("No se encontro esa palabra o letra");
            }
        }
        public void setPrincipal(Form1 principal)
        {
            this.principal = principal;

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
