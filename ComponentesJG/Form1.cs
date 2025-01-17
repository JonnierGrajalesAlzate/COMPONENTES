﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*Jonnier Grajales Alzate
 03/09/2024
Componentes
 */


namespace ComponentesJG
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPDF_Click(object sender, EventArgs e)
        {
            fmrPDF fmrPdf = new fmrPDF();
            fmrPdf.Show();
        }

        private void btnWMP_Click(object sender, EventArgs e)
        {
            fmrWMP fmrWmp = new fmrWMP();
            fmrWmp.Show();
        }

        private void btnWeb_Click(object sender, EventArgs e)
        {
            fmrWeb fmrNav = new fmrWeb();
            fmrNav.Show();
        }


    }
}
