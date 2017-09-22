using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HextoDec
{
    public partial class btnConv : Form
    {
        public btnConv()
        {
            InitializeComponent();
        }

        private void rbDecHex_CheckedChanged(object sender, EventArgs e)
        {
            this.Text = "Decimal to Hex";
        }

        private void rbHexDec_CheckedChanged(object sender, EventArgs e)
        {
            this.Text = "Hex to Decimal";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string value = txtVal.Text;
            if (rbDecHex.Checked==true)
            {
                int val = Convert.ToInt32(value);
                string hexvalue = val.ToString("X");
                txtShow.Text = hexvalue;
            }
            else if (rbHexDec.Checked == true)
            {
                
                int val = Convert.ToInt32(value, 16);
                txtShow.Text = Convert.ToString(val);
            }
        }
    }
}
