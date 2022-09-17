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
                archivo.WriteLine(principal.contenido);
                archivo.Close();

                principal.archivo = archivo;


                this.Hide();
                MessageBox.Show("Se ah guardado");
            }
            
        }
        public void setPrincipal(Form1 padre)
        {
            this.principal = padre;
        }
        public bool verificar()
        {
           
            TextReader listaArchivos=new StreamReader("listaArchivos.txt");
            
            List<string> lista = new List<string>();
            while(listaArchivos.ReadLine()!=null)
            {
                
                 lista.Add(listaArchivos.ReadLine());
                MessageBox.Show(listaArchivos.ReadLine());
                
                
 
            }
            listaArchivos.Close();

            if(lista.Contains(textBox1.Text))
            {
                Form3 ventana4=new Form3();
                ventana4.setPadre(principal);
                ventana4.Show();

                return ventana4.quiere;
            }
            else
            {
                TextWriter listaArchivosEscritura = new StreamWriter("listaArchivos.txt");
                foreach(var item in lista)
                {
                    listaArchivosEscritura.WriteLine(item);
                    MessageBox.Show(item);
                }
                listaArchivosEscritura.WriteLine(textBox1.Text);
                listaArchivosEscritura.Close();


            }
            return true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
