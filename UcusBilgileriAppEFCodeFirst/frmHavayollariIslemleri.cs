using BLL;
using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace UcusBilgileriAppEFCodeFirst
{
    public partial class frmHavayollariIslemleri : Form
    {

        SqlConnection cn = null;
        public string id_havayolu = null;
        Havayolu ha;

        public frmHavayollariIslemleri()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                HavayoluBL hbl = new HavayoluBL();
                ha = new Havayolu();

                ha.Id_Havayolu = txtHavayoluID.Text.Trim();
                ha.Havayolu_Adi = txtHavayoluAdi.Text.Trim();
                ha.Id_Ucak = null;
                //ha.Id_Ucak = txtIdUcak.Text.Trim();

                if (id_havayolu == null)
                {
                    MessageBox.Show(hbl.Ekle(ha) ? "Başarılı" : "Başarısız");
                    Temizle();
                }
                else
                {
                    MessageBox.Show(hbl.Guncelle(ha) ? "Güncelleme Başarılı" : "Güncelleme Başarısız");

                    id_havayolu = null;
                    Temizle();
                }
            }
            catch (SqlException ex)
            {
                switch (ex.Number)
                {
                    default:
                        MessageBox.Show("Veritabanı Hatası" + ex.Number);
                        break;
                }
            }

        }
        void Temizle()
        {
            foreach (Control item in this.Controls["pnlText"].Controls)
            {
                item.Text = string.Empty;
            }
            btnEkle.Text = "Ekle";
            id_havayolu = null;
            txtHavayoluID.Enabled = true;

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            DialogResult cvp = MessageBox.Show("Kayıt Silinecek. Eminminisiniz?", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


            if (cvp == DialogResult.Yes)
            {
                HavayoluBL hbl = new HavayoluBL();
                hbl.Sil(ha);

                MessageBox.Show("Silme Başarılı!");
                Temizle();
                hbl.Dispose();
            }
            else
            {
                MessageBox.Show("İşlem İptal Edildi!");
                Temizle();

            }
        }
        private void btnVazgec_Click(object sender, EventArgs e)
        {
            Temizle();
        }
    }
}
