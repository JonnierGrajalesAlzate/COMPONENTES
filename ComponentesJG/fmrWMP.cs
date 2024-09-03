using System;
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
    public partial class fmrWMP : Form
    {
        public fmrWMP()
        {
            InitializeComponent();
        }

        

        private void fmrWMP_Load(object sender, EventArgs e)
        {
            axMediaPlayer.URL = "power.MP4";
        }
    }
}
