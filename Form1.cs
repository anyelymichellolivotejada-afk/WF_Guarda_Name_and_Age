using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Datos;
using WindowsFormsApp1.Model;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {

        DataTable table;
        Usuario datos = new Usuario();

        public Form1()
        {
            InitializeComponent();
            iniciar();
            Consultar();
                
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Guardar();
            LImpiar();

            table.Rows.Clear( );
            Consultar();

        }

        private void btnLImpiar_Click(object sender, EventArgs e)
        {
            LImpiar();

        }


        //creacion de metodos 
        private void iniciar() 
        {
            table = new DataTable();
            table.Columns.Add("Nombre");
            table.Columns.Add("Edad");
            Grilla.DataSource = table;



        }



        // tip no  hacer el codigo directo en los botones por si tiene que llamar lo en otra 
        //ocacion mejor hacerun metodo para eso 

        //metodo guardar
        private void Guardar() 
        {
            UsuarioModel modelo = new UsuarioModel()
            {
                Nombre = txtNombre.Text,
                Edad = int.Parse(txtEdad.Text)


            };
            datos.Guardar(modelo);
    
        }


        private void Consultar() 
        {
            foreach (var item in datos.consultar()) 
            {
                DataRow fila = table.NewRow();
                fila["Nombre"] = item.Nombre;
                fila["Edad"] = item.Edad;
                table.Rows.Add(fila);
            
            
            }
 
        }


        private void LImpiar ()
        {
            txtEdad.Text = "";
            txtNombre.Text = "";
        
        
        
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
