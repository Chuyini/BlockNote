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
using System.Threading;

namespace BlocDeNotas
{
     partial class GuardarArchivo : Form
    {
         
        Form1 principal;
        
        public GuardarArchivo()
        {
            InitializeComponent();
            

        }

        private void GuardarArchivo_Load(object sender, EventArgs e)
        {

        }
        //Guarda el nombre del archivo
        private void button1_Click(object sender, EventArgs e)
        {
            
            if (textBox1 == null)
            {
                textBox1.Text = "predeterminado.txt";
                principal.nombreArchivo = textBox1.Text;
            }

            if(verificar()==true)
            {
                TextWriter archivo = new StreamWriter(textBox1.Text + ".txt");

                principal.nombreArchivo = textBox1.Text;
                principal.toolStripStatusLabel2.Text = principal.nombreArchivo;
                archivo.WriteLine(principal.contenido);
                archivo.Close();
                principal.archivo = archivo;
                this.Hide();
                principal.toolStripStatusLabel1.Text = "Archivo guardado...";
               
                
            }
            else
            {
                this.Hide();
            }
            
        }
        public void setPrincipal(Form1 padre)
        {
            this.principal = padre;
        }
        public bool verificar()
        {
           
            StreamReader listaArchivos=new StreamReader("listaArchivos.txt");
            
            while(listaArchivos.ReadLine()!=null)
            {

                if (listaArchivos.ReadLine()==textBox1.Text)
                {
                    Form3 ventana4 = new Form3();
                    ventana4.setPadre(principal);
                    ventana4.Show();
                    listaArchivos.Close();

                    return ventana4.quiere;
                }
               

            }
            listaArchivos.Close();
            TextWriter listaArchivosEscritura = File.AppendText("listaArchivos.txt");
            listaArchivosEscritura.WriteLine(textBox1.Text);
            listaArchivosEscritura.Close();

            return true;    




        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
