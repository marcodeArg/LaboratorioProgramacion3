﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sexo = "M";
            if(radioButton1.Checked==true)
            {
                sexo = "F";
            }
            
            Alumnos a = new Alumnos();
            DataTable ta = a.getAll();
            dataGridView1.Rows.Clear();

            foreach(DataRow fila in ta.Rows)
            {
                if(fila[2].ToString()==sexo)
                {
                    dataGridView1.Rows.Add(fila[0], fila[1]);

                }
            }
        }
    }
}