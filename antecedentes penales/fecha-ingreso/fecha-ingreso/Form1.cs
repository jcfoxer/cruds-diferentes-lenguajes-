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
namespace fecha_ingreso
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

            string query = "Select *from Ingreso";
            SqlCommand comando = new SqlCommand(query, conexion);
            SqlDataAdapter data = new SqlDataAdapter(comando);
            DataTable tabla = new DataTable();
            data.Fill(tabla);
            dataGridView1.DataSource = tabla;

            conexion.Close();


        }
    }
}
