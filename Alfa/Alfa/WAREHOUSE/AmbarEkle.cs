using Alfa.BusinessLayer;
using System;
using System.Windows.Forms;

namespace Alfa.WAREHOUSE
{
    public partial class AmbarEkle : Form
    {
        ManagerWAREHOUSE managerWAREHOUSE = new ManagerWAREHOUSE();
        public AmbarEkle()
        {
            InitializeComponent();
            timer1.Start();

        }
        #region AMBAR EKLEME İŞLEMİ
        private void Button_Ekle_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(textBox_Name.Text)&& !string.IsNullOrEmpty(textBox_No.Text))
            {
                Alfa.Entities.Models.WAREHOUSE w = new Entities.Models.WAREHOUSE()
                {
                    WAREHOUSE_INSERTDATE = DateTime.Now,
                    WAREHOUSE_NAME = textBox_Name.Text,
                    WAREHOUSE_NO = textBox_No.Text

                };
                int sonuc = managerWAREHOUSE.Insert(w);
                if (sonuc > 0)
                {
                    MessageBox.Show("Kayıt Eklendi");
                    textBox_Name.Clear();
                    textBox_No.Clear();
                  //  ucAmbarGor._instance.Listele();
                }
                else
                    MessageBox.Show("Hata Meydana Geldi");

            }else
            {
                MessageBox.Show("Lütfen Tüm Alanları Doldurunuz");
            }
        }
        #endregion

        #region AMBAR EKLE LOAD KISMI
        private void AmbarEkle_Load(object sender, EventArgs e)
        {
            //TARİHİ BELİRTİLEN FORMATTA TEXT OLARAK YAZAR.
            textBox_Tarih.Text = DateTime.Now.ToString("dd.MM.yyyy");
            #region TOOLTİP
            ToolTip tool = new ToolTip();
            tool.SetToolTip(Button_Ekle, "EKLE");//MOUSE GELDİĞİNDE EKLE YAZAR.
            #endregion
            this.KeyPreview = true;
        }
        #endregion

        #region ESC İLE ÇIKMA
        private void AmbarEkle_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
        #endregion
    }
}
