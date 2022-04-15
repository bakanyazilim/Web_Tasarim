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
    public partial class Frm_0_KM : Form
    {
        public Frm_0_KM()
        {
            InitializeComponent();
        }

        private void Btn_Fıat_Click(object sender, EventArgs e)
        {
            Frm_Fiat frm_Fiat = new Frm_Fiat();
            frm_Fiat.Show();  
        }

        private void Btn_Audı_Click(object sender, EventArgs e)
        {
            Frm_AUDI frm_AUDI = new Frm_AUDI();
            frm_AUDI.Show();    
        }
    }
}
