﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace login
{
    public partial class usuario : Form
    {
        public usuario(string nombre)
        {
            InitializeComponent();
            


        }

        private void button1_Click(object sender, EventArgs e)
        {

            proyecto_filtrado_datos.Form1 frmusuario = new proyecto_filtrado_datos.Form1();
            frmusuario.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            antecedentes.Form1 frmantecedentes = new antecedentes.Form1();
            frmantecedentes.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            fecha_ingreso.Form1 frmfecha_ingreso = new fecha_ingreso.Form1();
            frmfecha_ingreso.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
