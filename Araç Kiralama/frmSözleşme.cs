using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Araç_Kiralama
{
    public partial class frmSözleşme : Form
    {
        public frmSözleşme()
        {
            InitializeComponent();
        }
        Araç_Kiralama arac = new Araç_Kiralama();
        private void frmSözleşme_Load(object sender, EventArgs e)
        {
            string sorgu2 = "select *from araç where durumu ='BOŞ'";
            arac.Boş_Araçlar(comboAraçlar, sorgu2);
        }

        private void txtTc_TextChanged(object sender, EventArgs e)
        {
            if (txtTc.Text == "") foreach (Control item in groupBox1.Controls) if (item is TextBox) item.Text = "";
            string sorgu2 = "select *from müşteri where tc like '" + txtTc.Text + "'";
            arac.TC_Ara(txtTc,txtAdSoyad,txtTelefon,sorgu2);
        }

        private void comboAraçlar_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sorgu2 = "select *from araç where plaka  like '" + comboAraçlar.SelectedItem + "'";
            arac.CombodanGetir(comboAraçlar,txtMarka,txtSeri,txtYil,txtRenk,sorgu2);
        }
    }
}
