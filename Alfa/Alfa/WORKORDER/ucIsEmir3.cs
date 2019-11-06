using Alfa.BusinessLayer;
using Alfa.Entities.Models;
using System;
using System.Drawing;
using System.Windows.Forms;


namespace Alfa.WORKORDER
{
    public partial class ucIsEmir3 : UserControl
    {
        
        ManagerWL_PROCESS managerWL_PROCESS = new ManagerWL_PROCESS();
        ManagerWRKORD managerWRKORD = new ManagerWRKORD();
        ManagerMOLD managerMOLD = new ManagerMOLD();
        UcEmirGor uc = new UcEmirGor();
        public ucIsEmir3()
        {
            InitializeComponent();
           
        }
        #region PROCESS AŞAMASI LOAD KISMI
        private void ucIsEmir3_Load(object sender, EventArgs e)
        {
            //checkedListBox_Listele.DataSource = managerOPE_EXC.List();
            //checkedListBox_Listele.ValueMember = "OPE_ID";
            //checkedListBox_Listele.DisplayMember = "OPE_NAME";     
            ToolTip tool = new ToolTip();
          
            tool.SetToolTip(button_OK, "KAYDET");//MOUSE GELDİĞİNDE KAYDET YAZAR.
        }
        #endregion
        #region PROCESS TABLOSUNU GÜNCELLEME KISMI

        public void checkkontrol()
        {
            if (checkBox1.Checked == true)
            {
                if (IsEmriEkle.id != null)
                {
                    WRKORD w = managerWRKORD.Find(x => x.WRKORD_ID == IsEmriEkle.id);
                   
                    Entities.Models.MOLD wrh = managerMOLD.Find(z => z.MOLD_ID == (int)IsEmriEkle.Instance.comboBox_Kn.SelectedValue);
                    w.STATUS_ = "DEVAM EDİYOR";
                    IsEmriEkle.Instance.comboBox5.Text = "DEVAM EDİYOR";

            
                    IsEmriEkle.Instance.comboBox_Ambar.Text = "KALIPHANE";

                    wrh.Warehouse_ID = Convert.ToInt32(IsEmriEkle.Instance.comboBox_Ambar.SelectedValue);
                   
                    managerMOLD.Update(wrh);
                    managerWRKORD.Update(w);
                }
            }
            else
            {
                if (IsEmriEkle.id != null)
                {
                    WRKORD w = managerWRKORD.Find(x => x.WRKORD_ID == IsEmriEkle.id);

                    w.STATUS_ = "BAŞLAMADI";
                    IsEmriEkle.Instance.comboBox5.Text = "BAŞLAMADI";


                    managerWRKORD.Update(w);
                }
            }
        }
        private void checkBox1_Click(object sender, EventArgs e)
        {
            checkkontrol();
            
        }
        private void button_OK_Click(object sender, EventArgs e)
        {
            if (IsEmriEkle.id != null)
            {
                WRKORD w = managerWRKORD.Find(x => x.WRKORD_ID == IsEmriEkle.id);
                WL_PROCESS wL3 = managerWL_PROCESS.Find(x => x.WRKID == IsEmriEkle.id);
                wL3.PROCESS_NOTE = richTextBox_yapılan.Text;
                if (checkBox2.Checked == true)
                {

                    wL3.OPE1_DATE = DateTime.Now;
                }
                if (checkBox3.Checked == true)
                {

                    wL3.OPE2_DATE = DateTime.Now;
                }
                if (checkBox4.Checked == true)
                {

                    wL3.OPE3_DATE = DateTime.Now;
                }
                if (checkBox5.Checked == true)
                {

                    wL3.OPE4_DATE = DateTime.Now;
                }
                if (checkBox6.Checked == true)
                {

                    wL3.OPE5_DATE = DateTime.Now;
                }
                if (checkBox7.Checked == true)
                {

                    wL3.OPE6_DATE = DateTime.Now;
                }
                if (checkBox8.Checked == true)
                {

                    wL3.OPE7_DATE = DateTime.Now;
                }
                if (checkBox9.Checked == true)
                {

                    wL3.OPE8_DATE = DateTime.Now;
                }

                int sonuc = managerWL_PROCESS.Update(wL3);
               
                managerWRKORD.Update(w);
                if (sonuc > 0)
                {
                    MessageBox.Show("Kayıt Eklendi");
                    uc.Listele();
                    IsEmriEkle.Instance.button5.Enabled = true;
                    IsEmriEkle.Instance.button5.BackColor = Color.Gold;
                   
                    IsEmriEkle.Instance.ucIsEmir41.richTextBox2.Text = richTextBox_yapılan.Text;
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

       
       
       
    }
}
