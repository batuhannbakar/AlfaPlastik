using Alfa.BusinessLayer;
using Alfa.Entities.Models;
using System;
using System.Windows.Forms;

namespace Alfa.WORKORDER
{
    public partial class ucIsEmir4 : UserControl
    {
    
        public ucIsEmir4()
        {
            InitializeComponent();
        }
        ManagerWL_COMPLETE managerWL_COMPLETE = new ManagerWL_COMPLETE();
        ManagerWRKORD managerWRKORD = new ManagerWRKORD();
        Block ns = new Block();

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            richTextBox3.Enabled = true;
        }
        #region TAMAMLANMA AŞAMASI LOAD KISMI
        private void ucIsEmir4_Load(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                richTextBox3.Enabled = true;
            }
            else { richTextBox3.Enabled = false; }
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd.MM.yyyy";
            ToolTip tool = new ToolTip();

            tool.SetToolTip(button_OK, "KAYDET");//MOUSE GELDİĞİNDE KAYDET YAZAR.

        }
        #endregion

        #region COMPLETE TABLOSU GÜNCELLEME BUTONU
        private void button_OK_Click(object sender, EventArgs e)
        {
            if (IsEmriEkle.id != null)
            {
                WL_COMPLETE wL4 = managerWL_COMPLETE.Find(x => x.WRKID == IsEmriEkle.id);
                wL4.COMPLETION_DATE = dateTimePicker1.Value;
                wL4.COMPLETION_TİME = TimeSpan.FromHours(dateTimePicker2.Value.Hour);
                wL4.DELIVERY_TYPE = comboBox1.Text;
                wL4.DELIVERY_NOTE = richTextBox_Teslim.Text;
                
                int sonuc = managerWL_COMPLETE.Update(wL4);
                if (sonuc > 0)
                {
                    UcEmirGor uc = new UcEmirGor();
                    MessageBox.Show("Kayıt Eklendi");
                    if (IsEmriEkle.id != null)
                    {
                        WRKORD w = managerWRKORD.Find(x => x.WRKORD_ID == IsEmriEkle.id);

                        w.STATUS_ = "TAMAMLANDI";
                        IsEmriEkle.Instance.comboBox5.Text = "TAMAMLANDI";
                        uc.Listele();
                        managerWRKORD.Update(w);
                    }
                  
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

        #region PROCESS AŞAMASINA GİTME KISMI
        private void button_GERİ_Click_1(object sender, EventArgs e)
        {
            ucIsEmir3 uc3 = new ucIsEmir3();
            uc3.BringToFront();
            //if (!IsEmriEkle.Instance.panel2.Controls.ContainsKey("ucIsEmir3"))
            //{
            //    ucIsEmir3 emir3 = new ucIsEmir3();
            //    emir3.Dock = DockStyle.Fill;
            //    IsEmriEkle.Instance.panel2.Controls.Add(emir3);

            //}
            //IsEmriEkle.Instance.panel2.Controls["ucIsEmir3"].BringToFront();

            #endregion
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            ns.IntOrStringNo(e);
        }
    }
}
