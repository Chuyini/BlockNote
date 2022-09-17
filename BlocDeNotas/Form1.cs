using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace BlocDeNotas
{
    public partial class Form1 : Form
    {
        
        GuardarArchivo ventana2 = new GuardarArchivo();
        Form2 ventana3= new Form2();
        public TextWriter archivo;
        public string nombreArchivo;
        public string contenido;
        

        
        



        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripProgressBar1_Click(object sender, EventArgs e)
        {

        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            guardarComo();
            this.Hide();
            textBox1.Text = "";
            this.Show();
        }

        private void guardarToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (archivo == null)
            {
                guardarComo();
                
            }
            else
            {
                guardar();
                
            }
            
        }
        public void guardar()
        {
            TextWriter archivCreate = new StreamWriter(nombreArchivo + ".txt");
            archivCreate.WriteLine(textBox1.Text);
            archivCreate.Close();
        }

        private void guardarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            guardarComo();
        }

        public void guardarComo()
        {
            contenido = textBox1.Text;
            ventana2.Show();
            ventana2.setPrincipal(this);

        }

        public void salir()
        {
            contenido = textBox1.Text;
            ventana3.Show();
            ventana3.setPrincipal(this);

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(archivo==null)
            {

                salir();
            }
            else
            {
                this.Close();

            }
        }

        private void toolStripProgressBar1_Click_1(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
