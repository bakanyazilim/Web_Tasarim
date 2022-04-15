using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Web_Tasarim_KAP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Btn_0_Km_Click(object sender, EventArgs e)
        {
            Frm_0_KM frm_0_KM = new Frm_0_KM();
            frm_0_KM.Show();
        }
    }
}
