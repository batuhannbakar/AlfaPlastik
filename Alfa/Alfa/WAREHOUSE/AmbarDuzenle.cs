using Alfa.BusinessLayer;
using System;
using System.Windows.Forms;

namespace Alfa.WAREHOUSE
{
    public partial class AmbarDuzenle : Form
    {
        ManagerWAREHOUSE managerWAREHOUSE = new ManagerWAREHOUSE();
        public AmbarDuzenle()
        {
            InitializeComponent();
        }
        #region AMBAR DÜZENLEME İŞLEMİ
        private void Button_Duzenle_Click_1(object sender, EventArgs e)
        {
            Alfa.Entities.Models.WAREHOUSE w = managerWAREHOUSE.Find(x => x.WAREHOUSE_ID == (int)textBox_Name.Tag);
            if (!string.IsNullOrEmpty(textBox_Name.Text) && !string.IsNullOrEmpty(textBox_No.Text))
            {
                w.WAREHOUSE_INSERTDATE = dateTimePicker1.Value;
                w.WAREHOUSE_NAME = textBox_Name.Text;
                w.WAREHOUSE_NO = textBox_No.Text;

                int sonuc = managerWAREHOUSE.Update(w);
                if (sonuc > 0)
                {
                    MessageBox.Show("Kayıt Güncellendi");
                   // ucAmbarGor._instance.Listele();
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

        #region AMBAR DÜZENLE LOAD KISMI
        private void AmbarDuzenle_Load(object sender, EventArgs e)
        {   //DATETİMEPİCKER FORMATI DEĞİŞTİRME.
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd.MM.yyyy";

            ToolTip tool = new ToolTip();
            tool.SetToolTip(Button_Duzenle, "DÜZENLE");//MOUSE GELDİĞİNDE DÜZENLE YAZAR.

            this.KeyPreview = true;
        }
        #endregion

        #region ESC İLE ÇIKMA
        private void AmbarDuzenle_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
        #endregion

       
    }
}
