using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace proyecto_filtrado_datos
{
    public partial class Form1 : Form
    {

        static string conexionstring = ("SERVER=DESKTOP-9GQIJIP\\SQLEXPRESS;DATABASE=personas;integrated security=true;");
        SqlConnection conexion = new SqlConnection(conexionstring);
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            conexion.Open();
            MessageBox.Show("SE ESTABLECIO LA CONEXION ");


        }
        
       

        private void button2_Click(object sender, EventArgs e)
        {

            conexion.Close();
            MessageBox.Show("SE CERRO LA CONEXION  ");



        }


        private void txt_conuslta_Click(object sender, EventArgs e)
        {

            if (txt_consulta.Text == "")

            {
                string query = "Select *from Personas";
                SqlCommand comando = new SqlCommand(query, conexion);
                SqlDataAdapter data = new SqlDataAdapter(comando);
                DataTable tabla = new DataTable();
                data.Fill(tabla);
                dataGridView1.DataSource = tabla;

            }

            else
            {

                string query = "Select *from Personas where Pais ='" + txt_consulta.Text + "'";
                SqlCommand comando = new SqlCommand(query, conexion);
                SqlDataAdapter data = new SqlDataAdapter(comando);
                DataTable tabla = new DataTable();
                data.Fill(tabla);
                dataGridView1.DataSource = tabla;


            }



        }





        private void button3_Click(object sender, EventArgs e)
        {

            string cadena = " Insert into Personas (Nombre_apellido,Edad,Pais,DNI) " + "values ('" + txt_nombre.Text + "','" + txt_edad.Text + "','" + txt_pais.Text + "','" + txt_nid.Text + "')";

            SqlCommand comando = new SqlCommand(cadena, conexion);
            comando.ExecuteNonQuery();

            MessageBox.Show("se registrocon exito ");
            txt_nombre.Text = "";
            txt_edad.Text = "";
            txt_pais.Text = "";
            txt_nid.Text = "";


        }

        private void button5_Click(object sender, EventArgs e)
        {

            int flag = 0;
            string cadena = " Delete  from Personas where Nombre_apellido ='" + txt_nombre.Text + "'";

            SqlCommand comando = new SqlCommand(cadena, conexion);
            flag = comando.ExecuteNonQuery();
            if (flag == 1)
            {
                MessageBox.Show("se realizo la eliminacion con exito");


            }
            else
            {

                MessageBox.Show("no se encontro a la persona ");
                txt_nombre.Text = "";

            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int flag = 0;
            string cadena = "update  Personas set Nombre_apellido='" + txt_nombre.Text + "' ,Edad ='" + txt_edad.Text + "',Pais='" + txt_pais.Text + "',DNI='" + txt_nid.Text + "' Where Nombre_apellido= '" + txt_nombre_actu + "'";
            SqlCommand comando = new SqlCommand(cadena, conexion);

            flag = comando.ExecuteNonQuery();


            if (flag == 1)
            {
                MessageBox.Show("se  actualizo correctamente");

            }
            else
            {
                MessageBox.Show("no se pudo realizar");

txt_nombre.Text = "";
            txt_edad.Text = "";
            txt_pais.Text = "";
            txt_nid.Text = "";


            }
            

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Close();
        }
    }

}