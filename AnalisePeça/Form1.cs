using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnalisePeça
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        
        private void label1_Click(object sender, EventArgs e)

              
        {
            Peca peca1 = new Peca();
            string oleo = Convert.ToString(peca1.calcOleo(1.072, 1.348, 1.999, 2.005));
            label1.Text = oleo;
        }
    }
}
