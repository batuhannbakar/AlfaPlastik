using Alfa.BusinessLayer;
using System;
using System.Windows.Forms;

namespace Alfa.MAINTAINTYPE
{
    public partial class BakimTipiEkle : Form
    {
        ManagerMAINTAINTYPE managerMAINTAINTYPE = new ManagerMAINTAINTYPE();
        public BakimTipiEkle()
        {
            InitializeComponent();
            timer1.Start();
        }
        #region EKLME BUTONU 
        private void Button_Ekle_Click(object sender, EventArgs e)
        {   //EKLEME İŞLEMİ
            if (!string.IsNullOrEmpty(textBox_Name.Text) && !string.IsNullOrEmpty(textBox_No.Text))
            {
                Alfa.Entities.Models.MAINTAINTYPE ma = new Entities.Models.MAINTAINTYPE()
                {
                    MAINTAINTYPE_INSERTDATE = DateTime.Now,
                    MAINTAINTYPE_NAME = textBox_Name.Text,
                    MAINTAINTYPE_NO = textBox_No.Text

                };
                int sonuc = managerMAINTAINTYPE.Insert(ma);
                if (sonuc > 0)
                {
                    MessageBox.Show("Kayıt Eklendi");
                    textBox_Name.Clear();
                    textBox_No.Clear();
                    //ucBakimTipiGor._instance.Listele();
                    
                }
                else
                    MessageBox.Show("Hata Meydana Geldi");

            }
            else
            {
                MessageBox.Show("Lütfen Tüm Alanları Doldurunuz");
            }
        }
        #endregion

        #region EKLEME LOAD KISMI
        private void BakimTipiEkle_Load(object sender, EventArgs e)
        {
           //MOUSE ÜSTÜNE GELDİĞİNDE EKLE YAZAR
            ToolTip tool = new ToolTip();
            tool.SetToolTip(Button_Ekle, "EKLE");

            this.KeyPreview = true;
        }
        #endregion

        #region TİMER
        private void timer1_Tick(object sender, EventArgs e)
        {   //ANLIK SAATİ ALIR TEXTBOX'A TEXT HALİNDE YAZAR.
            DateTime dateTime = DateTime.Now;
            this.textBox_Tarih.Text=dateTime.ToString();
        }
        #endregion

        #region ESC İLE ÇIKMA
        private void BakimTipiEkle_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
        #endregion
    }
}
