using Alfa.BusinessLayer;
using System;
using System.Windows.Forms;

namespace Alfa.OPERATION
{
   
    public partial class OperasyonDuzenle : Form
    {
        ManagerOPERATION managerOPERATION = new ManagerOPERATION();
        public OperasyonDuzenle()
        {
            InitializeComponent();
        }

        #region OPERASYON DÜZENLEME İŞLEMİ
        private void Button_Duzenle_Click_1(object sender, EventArgs e)
        {

            Alfa.Entities.Models.OPERATION o = managerOPERATION.Find(x => x.OPERATION_ID == (int)textBox_Name.Tag);
            if (!string.IsNullOrEmpty(textBox_Name.Text) && !string.IsNullOrEmpty(textBox_No.Text))
            {
                o.OPERATION_INSERTDATE = dateTimePicker1.Value;
                o.OPERATION_NAME = textBox_Name.Text;
                o.OPERATION_NO = textBox_No.Text;

                int sonuc = managerOPERATION.Update(o);
                if (sonuc > 0)
                {
                    MessageBox.Show("Kayıt Güncellendi");
                   // ucOperasyonGor._instance.Listele();
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

        #region OPERASYON DÜZENLEME LOAD KISMI
        private void OperasyonDuzenle_Load(object sender, EventArgs e)
        {   //DATETİMEPİCKER FORMATI DEĞİŞTİRME
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd.MM.yyyy HH:mm:ss";
            #region TOOLTİP
            ToolTip tool = new ToolTip();
            tool.SetToolTip(Button_Duzenle, "DÜZENLE");//MOUSE GELDİĞİNDE DÜZENLE YAZAR.
            #endregion
            this.KeyPreview = true;
        }
        #endregion

        #region ESC İLE ÇIKMA
        private void OperasyonDuzenle_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
        #endregion
    }
}
