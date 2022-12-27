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


namespace login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("SERVER=DESKTOP-9GQIJIP\\SQLEXPRESS;DATABASE=login;integrated security=true;");


        public void logear(string usuario, string contraseña)
        {

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT  nombre ,tipo_usuario FROM USUARIOS  WHERE usuario =@usuario and password =@pas", con);
                cmd.Parameters.AddWithValue("usuario", usuario);
                cmd.Parameters.AddWithValue("pas", contraseña);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count == 1) {

                    this.Hide();
                    if (dt.Rows[0][1].ToString() == "admin")
                    {
                       

                    }
                    else if (dt.Rows[0][1].ToString() == "usuario")
                    {

                        new usuario(dt.Rows[0][0].ToString()).Show();
                    }

                }
                else { MessageBox.Show("usuario y/o contraseña incorrecta "); }



            }
            catch
            

                (Exception e)
                {

                    MessageBox.Show(e.Message);
                }
                finally { con.Close(); }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            logear(textBox1.Text,this.textBox2.Text );

        }
    }
}




    



