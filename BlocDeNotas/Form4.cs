using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlocDeNotas
{
    public partial class Form4 : Form
    {
        Form1  principal;
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) 
        {

            
            try
            {
                TextReader archivoLectura = new StreamReader(textBox1.Text + ".txt");
                principal.textBox1.Text = archivoLectura.ReadToEnd();
                principal.nombreArchivo = textBox1.Text;
                archivoLectura.Close();
                principal.toolStripStatusLabel2.Text=principal.nombreArchivo;
                this.Close();
                

            }
            catch (FileNotFoundException )
            {
                MessageBox.Show("Ese archvo no existe");
                

            }


             

           

        }
        public void setPrincipal(Form1 principal)
        {
            this.principal = principal;
        }
    }
}
