﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComponentesJG
{
    public partial class fmrPDF : Form
    {
        public fmrPDF()
        {
            InitializeComponent();
        }

        private void fmrPDF_Load(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            axPDF.src = openFileDialog1.FileName;
        }
    }
}
