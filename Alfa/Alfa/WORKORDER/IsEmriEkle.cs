
using Alfa.BusinessLayer;
using Alfa.DataAccessLayer.EntityFramework;
using Alfa.Entities.Models;
using Alfa.Forms;
using System;

using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Alfa.WORKORDER
{
    public partial class IsEmriEkle : Form
    {
        #region nesneler
        AlfaPlastikContext context = new AlfaPlastikContext();
        Block ns = new Block();
        ManagerMOLD managerMOLD = new ManagerMOLD();
        WorkorderDal dal = new WorkorderDal();
        ManagerWL_PROCESS managerWL_PROCESS = new ManagerWL_PROCESS();
        ManagerV_WRKORD_GRID managerV_WRKORD_GRID = new ManagerV_WRKORD_GRID();
        UcisemirDal dal1 = new UcisemirDal();
        Ucisemir2Dal dal2 = new Ucisemir2Dal();
        Ucisemir3Dal dal3 = new Ucisemir3Dal();
        Ucisemir4Dal dal4 = new Ucisemir4Dal();
        UcEmirGor uc = new UcEmirGor();
        WRKORD w = new WRKORD();
        WL_REQUEST wL1 = new WL_REQUEST();
        WL_PLAN wL2 = new WL_PLAN();
        WL_PROCESS wL3 = new WL_PROCESS();
        WL_COMPLETE wL4 = new WL_COMPLETE();
        UcEmirGor emirGor = new UcEmirGor();
        #endregion

        #region INSTANCE
        private static IsEmriEkle _instance;
        public static IsEmriEkle Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new IsEmriEkle();
                return _instance;
            }
        }
        #endregion
       
      
      
        public IsEmriEkle()
        {   
            InitializeComponent();                               
        }
        #region işEmriEkleme Formu Load Kısmı
        private void IsEmriEkle_Load_1(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'alfaPlastikDataSet.WAREHOUSE' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.wAREHOUSETableAdapter.Fill(this.alfaPlastikDataSet.WAREHOUSE);
            // TODO: Bu kod satırı 'alfaPlastikDataSet.MOLD' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.mOLDTableAdapter.Fill(this.alfaPlastikDataSet.MOLD);
            // TODO: Bu kod satırı 'alfaPlastikDataSet.MAINTAINTYPE' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.mAINTAINTYPETableAdapter.Fill(this.alfaPlastikDataSet.MAINTAINTYPE);
            var date = DateTime.Now;
            var hm = new DateTime(date.Hour);

            ucIsEmir1.BringToFront();

            _instance = this;//UCLER ARASI GEÇİŞ İÇİN YAZILDI.
            lblKullanici.Text = GirisSayfasi.aktif.NAME;//GİRİŞ YAPAN KULLANICININ ADINI LABELE YAZAR.
            lblTarih.Text = DateTime.Now.ToString();
            textBox_Kullanici.Text = GirisSayfasi.aktif.NAME;
            WindowState = FormWindowState.Maximized;

            #region TOOLTİP
            ToolTip tool = new ToolTip();
            tool.SetToolTip(buttoncikis, "ÇIKIŞ");
            tool.SetToolTip(button9, "KAYDET");
            #endregion
            this.KeyPreview = true;
            //BUTONLARI GRİ YAPMA.
            button_PLANLAMA.BackColor = Color.Silver;
            button_PROSES.BackColor = Color.Silver;
            button5.BackColor = Color.Silver;

        }
        #endregion

        #region TİMER
        private void timer1_Tick_1(object sender, EventArgs e)
        {
           
            DateTime dt = DateTime.Now;
            textBox1.Text = dt.ToShortTimeString();
            textBox3.Text = dt.ToShortDateString();
        }
        #endregion

        #region TALEP BUTONUNDAN TALEP AŞAMASINA GİTME
        private void button_TALEP_Click_1(object sender, EventArgs e)
        {
            ucIsEmir1.BringToFront();
           
        }
        #endregion

        #region PLANLAM BUTONUNDAN PLANLAMA AŞAMASINA GİTME
        private void button_PLANLAMA_Click_1(object sender, EventArgs e)
        {
            ucIsEmir21.BringToFront();
          
        }
        #endregion
        public void opelist()
        { 
            V_WRKORD_GRID wrk = managerV_WRKORD_GRID.Find(y => y.WRKORD_ID == id);

            WL_PROCESS wl3 = managerWL_PROCESS.Find(y => y.WRKID == id);

            if (ucIsEmir21.checkBox2.Checked == true)
            {
                ucIsEmir31.textBox1.Text = wrk.OPE1.ToString();
            }
            if (ucIsEmir21.checkBox3.Checked == true)
            {
                ucIsEmir31.textBox2.Text = wrk.OPE2.ToString();
            }
            if (ucIsEmir21.checkBox4.Checked == true)
            {
                ucIsEmir31.textBox3.Text = wrk.OPE3.ToString();
            }
            if (ucIsEmir21.checkBox5.Checked == true)
            {
                ucIsEmir31.textBox4.Text = wrk.OPE4.ToString();
            }
            if (ucIsEmir21.checkBox6.Checked == true)
            {
                ucIsEmir31.textBox5.Text = wrk.OPE5.ToString();
            }
            if (ucIsEmir21.checkBox7.Checked == true)
            {
                ucIsEmir31.textBox6.Text = wrk.OPE6.ToString();
            }
            if (ucIsEmir21.checkBox8.Checked == true)
            {
                ucIsEmir31.textBox7.Text = wrk.OPE7.ToString();
            }
            if (ucIsEmir21.checkBox9.Checked == true)
            {

                ucIsEmir31.textBox8.Text = wrk.OPE8.ToString();
            }
        }
        #region PROSES BUTONUNDAN PROSES AŞAMASINA GİTME
        private void button_PROSES_Click(object sender, EventArgs e) 
        {
            ucIsEmir31.BringToFront();

            opelist();
       
        }
        #endregion

        #region TAMAMLANMA AŞAMASINA GİTME KISMI
        private void button5_Click(object sender, EventArgs e) 
        {
            ucIsEmir41.BringToFront();
   
        }
        #endregion

        public void IsEmri()
        {
            if (!string.IsNullOrEmpty(comboBox_BakimTipi.Text) && !string.IsNullOrEmpty(comboBox_Ka.Text) && !string.IsNullOrEmpty(comboBox_Kn.Text) && !string.IsNullOrEmpty(TBX_İsEmriNo.Text) && !string.IsNullOrEmpty(ucIsEmir1.comboBox1.Text) && !string.IsNullOrEmpty(ucIsEmir1.comboBox_Öncelik.Text) && !string.IsNullOrEmpty(ucIsEmir1.dateTimePicker3.Text) && !string.IsNullOrEmpty(ucIsEmir1.dateTimePicker2.Text) && !string.IsNullOrEmpty(ucIsEmir1.richTextBox_not.Text))
            {
                Entities.Models.MOLD m = managerMOLD.Find(a => a.MOLD_ID == (int)comboBox_Kn.SelectedValue);
               
                w.WRKORD_INSERTDATE = DateTime.Now;
                w.CREATER_ID = GirisSayfasi.aktif.USERS_ID;
                w.Mold_ID = (int)comboBox_Ka.SelectedValue;
                w.Mold_ID = (int)comboBox_Kn.SelectedValue;
                m.Warehouse_ID = (int)comboBox_Ambar.SelectedValue;

                w.Maintaintype_ID = (int)comboBox_BakimTipi.SelectedValue;
                w.STATUS_ = comboBox5.Text;

                w.WRKORD_NO = Convert.ToInt32(TBX_İsEmriNo.Text);
                managerMOLD.Update(m);
                dal.Add(w);
                if (w.WRKORD_ID == 0)
                {
                    MessageBox.Show("Hatalı Kayıt");
                }
                else
                {
                    IdAta();
                    DefaultAta();
                  
                    dal1.Add(wL1);
                    dal2.Add(wL2);
                    dal3.Add(wL3);
                    dal4.Add(wL4);
                    TalepEkle();
                    dal1.Update(wL1);

                    emirGor.Listele();
                    button9.Visible = false;

                    ucIsEmir1.label7.Text = w.WRKORD_INSERTDATE.ToString();
                    ucIsEmir1.label7.Visible = true;


                    button_PLANLAMA.BackColor = Color.Gold;
                    button_PLANLAMA.Enabled = true;

                    ucIsEmir21.richTextBox_TalepNot.Text = ucIsEmir1.richTextBox_not.Text;
                    ucIsEmir21.textBox_tarih.Text = ucIsEmir1.dateTimePicker2.Text;
                    ucIsEmir31.richTextBox_isemir.Text = ucIsEmir1.richTextBox_not.Text;
                }
            }
            else
            {
                MessageBox.Show("Boş Alan Bırakılamaz");

               
            }
        }
        public void TalepEkle()
        {
            if (!string.IsNullOrEmpty(ucIsEmir1.comboBox1.Text) && !string.IsNullOrEmpty(ucIsEmir1.comboBox_Öncelik.Text) && !string.IsNullOrEmpty(ucIsEmir1.dateTimePicker3.Text) && !string.IsNullOrEmpty(ucIsEmir1.dateTimePicker2.Text) && !string.IsNullOrEmpty(ucIsEmir1.richTextBox_not.Text))
            {
              
                wL1.REQUEST_BY = (int)ucIsEmir1.comboBox1.SelectedValue;
                wL1.PRIORITY = ucIsEmir1.comboBox_Öncelik.Text;
                wL1.REQUEST_DATE = ucIsEmir1.dateTimePicker3.Value;
                wL1.REQUEST_BY_NAME = ucIsEmir1.comboBox1.Text;
                wL1.PLANNED_START_DATE = ucIsEmir1.dateTimePicker2.Value;
                wL1.WRK_NOTE = ucIsEmir1.richTextBox_not.Text;
            }
        }
        public void IdAta()
        {
            id = w.WRKORD_ID;
            wL1.WRKID = w.WRKORD_ID;
            wL2.WRKID = w.WRKORD_ID;
            wL3.WRKID = w.WRKORD_ID;
            wL4.WRKID = w.WRKORD_ID;
        }
        public void DefaultAta()
        {
            wL2.ESTIMATED_START_DATE = DateTime.Now;
            wL2.MAINTAIN_PERSON = 5;
            wL2.MAINTAIN_PERSON_NAME = "A";
            wL2.PLANNED_TİME = 1;
            wL2.TO_DO_NOTE = "YAPILACAKLAR";
            wL3.PROCESS_NOTE = ".";
            wL4.COMPLETION_DATE = DateTime.Now;
            wL4.COMPLETION_TİME = TimeSpan.FromHours(1);
            wL4.DELIVERY_TYPE = "TESLİM TİPİ";
            wL4.DELIVERY_NOTE = "TESLİM NOTU";
        }
        #region İŞEMRİ İNSERT KISMI
        //ekleme
        public static int id;
        private void button9_Click(object sender, EventArgs e)
        {

                IsEmri();
        }
        #endregion
 

        
        #region TEMİZLEME METODU
        public void Temizleme()
        {
            ucIsEmir1.richTextBox_not.Clear();
            ucIsEmir1.comboBox_Öncelik.SelectedItem = null;
            ucIsEmir1.dateTimePicker2.Text = null;
            ucIsEmir1.dateTimePicker3.Text = null;
            ucIsEmir21.comboBox_BakımPersonel.SelectedItem = null;
            ucIsEmir21.textBox_tarih.Text = null;
            ucIsEmir21.dateTimePicker1.Text = null;
            ucIsEmir21.textBox_saat.Text = null;
            ucIsEmir21.richTextBoxYapılacaklarNot.Clear();
            ucIsEmir21.richTextBox_TalepNot.Clear();
            ucIsEmir31.richTextBox_isemir.Clear();
            ucIsEmir31.richTextBox_yapilacak.Clear();
            ucIsEmir31.richTextBox_yapılan.Clear();
            ucIsEmir31.checkBox1.Checked = false;
            ucIsEmir41.richTextBox2.Clear();
            ucIsEmir41.richTextBox_Teslim.Clear();
            ucIsEmir41.richTextBox3.Clear();
            ucIsEmir41.comboBox1.SelectedItem = null;
            ucIsEmir41.dateTimePicker1.Text = null;

        }
        #endregion
        #region ÇIKIŞ BUTONU İLE ÇIKMA KISMI
        private void buttoncikis_Click_1(object sender, EventArgs e)
        {

            emirGor.Listele();
            Close();
            
            
        }
        #endregion
        #region ESC İLE ÇIKMA KISMI 
        private void IsEmriEkle_KeyDown(object sender, KeyEventArgs e)//ESC İLE ÇIKMA 
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
             
            }
        }
        #endregion
        #region ÇIKIŞ YAPILDIĞINDA TÜM İÇERİĞİ TEMİZLE
        private void IsEmriEkle_FormClosed(object sender, FormClosedEventArgs e)
        {
            Temizleme();
        }

        #endregion

        private void TBX_İsEmriNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            ns.StringNo(e);
        }

        private void comboBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            ns.IntOrStringNo(e);
        }

        private void textBox_Kullanici_KeyPress(object sender, KeyPressEventArgs e)
        {
            ns.IntOrStringNo(e);
        }
    }
}




