using Alfa.BusinessLayer;
using System;
using System.Windows.Forms;

namespace Alfa.MOLD
{
    public partial class KalıpDuzenle : Form
    { ManagerMOLD managerMOLD = new ManagerMOLD();
        public KalıpDuzenle()
        {
            InitializeComponent();
        }
        #region KALIP DÜZENLEME
        private void Button_Duzenle_Click_1(object sender, EventArgs e)
        {
            Alfa.Entities.Models.MOLD m = managerMOLD.Find(x => x.MOLD_ID == (int)textBox_Name.Tag);
            if (!string.IsNullOrEmpty(textBox_Name.Text) && !string.IsNullOrEmpty(textBox_No.Text))
            {
                m.MOLD_INSERTDATE = dateTimePicker1.Value;
                m.MOLD_NAME = textBox_Name.Text;
                m.MOLD_NO = textBox_No.Text;

                int sonuc = managerMOLD.Update(m);
                if (sonuc > 0)
                {
                    MessageBox.Show("Kayıt Güncellendi");
                   // ucKalıpGor._instance.Listele();
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

        #region KALIP DÜZENLEME LOAD KISMI
        private void KalıpDuzenle_Load(object sender, EventArgs e)
        {
            ToolTip tool = new ToolTip();
            tool.SetToolTip(Button_Duzenle, "DÜZENLE");
            this.KeyPreview = true;
        }
        #endregion

        #region ESC İLE ÇIKMA
        private void KalıpDuzenle_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
        #endregion

    }
}
