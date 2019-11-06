using Alfa.BusinessLayer;
using System;
using System.Windows.Forms;

namespace Alfa.MOLD
{
    public partial class KalıpEkle : Form
    {
        ManagerMOLD managerMOLD = new ManagerMOLD();
        public KalıpEkle()
        {
            InitializeComponent();
        }
        #region KALIPEKLE LOAD KISMI
        private void KalıpEkle_Load(object sender, EventArgs e)
        {   //DATETİMEPİCKER FORMATINI DEĞİŞTİRME.
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd.MM.yyyy";

            ToolTip tool = new ToolTip();
            tool.SetToolTip(Button_Ekle, "EKLE");//MOUSE GELDİĞİNDE EKLE YAZAR.
            this.KeyPreview = true;
        }
        #endregion

        #region EKLEME İŞLEMİ
        private void Button_Ekle_Click_1(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox_Name.Text) && !string.IsNullOrEmpty(textBox_No.Text))
            {
                Alfa.Entities.Models.MOLD m = new Entities.Models.MOLD()
                {
                    MOLD_INSERTDATE = DateTime.Now,
                    MOLD_NAME = textBox_Name.Text,
                    MOLD_NO = textBox_No.Text,
                    Warehouse_ID=1039
                };
                int sonuc = managerMOLD.Insert(m);
                if (sonuc > 0)
                {
                    MessageBox.Show("Kayıt Eklendi");
                    textBox_Name.Clear();
                    textBox_No.Clear();
                   // ucKalıpGor._instance.Listele();
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

        #region ESC İLE ÇIKMA
        private void KalıpEkle_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
        #endregion
    }
}
