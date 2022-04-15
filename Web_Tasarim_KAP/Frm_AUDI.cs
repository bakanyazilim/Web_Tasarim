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
    public partial class Frm_AUDI : Form
    {
        public Frm_AUDI()
        {
            InitializeComponent();
        }

        private void Btn_Detaylar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ARAÇ AUDİ RS 7 DİR\n 4.0 MOTOR SEÇENEKLERİNE SAHİPTİR" +
               "\n DAHA FAZLA BİLGİ İÇİN ÜYE OLUNUZ VEYA OTURUM AÇINIZ.");
        }

        private void Btn_Detaylar2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ARAÇ AUDI RS Q8 DİR\n 4.0 MOTOR SEÇENEKLERİNE SAHİPTİR" +
               "\n DAHA FAZLA BİLGİ İÇİN ÜYE OLUNUZ VEYA OTURUM AÇINIZ.");
        }

        private void Btn_Hemen_Al_Click(object sender, EventArgs e)
        {
            Frm_Satis frm_Satis = new Frm_Satis();
            frm_Satis.Show();
        }

        private void Btn_Hemen_Al2_Click(object sender, EventArgs e)
        {
            Frm_Satis frm_Satis = new Frm_Satis();
            frm_Satis.Show();
        }
    }
}
