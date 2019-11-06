using Alfa.BusinessLayer;
using System;
using System.Windows.Forms;

namespace Alfa.MAINTAINTYPE
{
    public partial class BakimTipiDuzenle : Form
    {
        ManagerMAINTAINTYPE managerMAINTAINTYPE = new ManagerMAINTAINTYPE();
        public BakimTipiDuzenle()
        {
            InitializeComponent();
        }

        #region DÜZENLEME BUTONU
        private void Button_Duzenle_Click(object sender, EventArgs e)
        {   //DÜZLEME İŞLEMİ
            Entities.Models.MAINTAINTYPE ma = managerMAINTAINTYPE.Find(x => x.MAINTAINTYPE_ID == (int)textBox_Name.Tag);
            if (!string.IsNullOrEmpty(textBox_Name.Text) && !string.IsNullOrEmpty(textBox_No.Text))
            {
                ma.MAINTAINTYPE_INSERTDATE = dateTimePicker1.Value;
                ma.MAINTAINTYPE_NAME = textBox_Name.Text;
                ma.MAINTAINTYPE_NO = textBox_No.Text;

                int sonuc = managerMAINTAINTYPE.Update(ma);
                if (sonuc > 0)
                {
                    MessageBox.Show("Kayıt Güncellendi");
                    //ucBakimTipiGor._instance.Listele();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Kayıt Güncellenemedi");
                }
            }
            else
            {
                MessageBox.Show("Boş alanı doldurunuz.");
            }

        }
        #endregion

        #region DÜZENLEME LOAD KISMI 
        private void BakimTipiDuzenle_Load(object sender, EventArgs e)
        {   //MOUSE ÜZERİNE GELDİĞİNDE DÜZENLE YAZDIRIR.
            ToolTip tool = new ToolTip();
            tool.SetToolTip(Button_Duzenle, "DÜZENLE");

            this.KeyPreview = true;
        }
        #endregion

        #region ESC İLE ÇIKMA
        private void BakimTipiDuzenle_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
        #endregion
    }
}
