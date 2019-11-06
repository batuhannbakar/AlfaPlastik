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
    public partial class IsEmriDuzenle : Form
    {
        #region nesneler
        AlfaPlastikContext context = new AlfaPlastikContext();
        Block ns = new Block();
        WRKORD w = new WRKORD();
        WL_REQUEST wL1 = new WL_REQUEST();
        WL_PLAN wL2 = new WL_PLAN();
        WL_PROCESS wL3 = new WL_PROCESS();
        WL_COMPLETE wL4 = new WL_COMPLETE();
        UcEmirGor emirGor = new UcEmirGor();
        Ucisemir2Dal dal2 = new Ucisemir2Dal();
       
        #endregion
       
        #region İNSTANCE
        private static IsEmriDuzenle _instance;
        public static IsEmriDuzenle Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new IsEmriDuzenle();
                return _instance;
            }
        }
        #endregion
        public IsEmriDuzenle()
        {
            InitializeComponent();
        }
        public void opelist()
        {
            V_WRKORD_GRID wrko = managerV_WRKORD_GRID.Find(x => x.WRKORD_ID == (int)TBX_İsEmriNo.Tag);

            ucIsEmirDuzen21.comboBox1.Text = wrko.OPE1;
            ucIsEmirDuzen21.comboBox2.Text = wrko.OPE2;
            ucIsEmirDuzen21.comboBox3.Text = wrko.OPE3;
            ucIsEmirDuzen21.comboBox4.Text = wrko.OPE4;
            ucIsEmirDuzen21.comboBox5.Text = wrko.OPE5;
            ucIsEmirDuzen21.comboBox6.Text = wrko.OPE6;
            ucIsEmirDuzen21.comboBox7.Text = wrko.OPE7;
            ucIsEmirDuzen21.comboBox8.Text = wrko.OPE8;
            
        }
        #region Managerler
        ManagerWRKORD managerWRKORD = new ManagerWRKORD();
        ManagerWL_PLAN managerWL_PLAN = new ManagerWL_PLAN();
        ManagerWL_PROCESS managerWL_PROCESS = new ManagerWL_PROCESS();
        ManagerWL_REQUEST managerWL_REQUEST = new ManagerWL_REQUEST();
        ManagerMOLD managerMOLD = new ManagerMOLD();
        ManagerMAINTAINTYPE managerMAINTAINTYPE = new ManagerMAINTAINTYPE();
        ManagerWAREHOUSE managerWAREHOUSE = new ManagerWAREHOUSE();
        ManagerWL_COMPLETE managerWL_COMPLETE = new ManagerWL_COMPLETE();
        ManagerV_WRKORD_GRID managerV_WRKORD_GRID = new ManagerV_WRKORD_GRID();
        #endregion

        #region LOAD
        private void IsEmriDuzenle_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'alfaPlastikDataSet.WAREHOUSE' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.wAREHOUSETableAdapter.Fill(this.alfaPlastikDataSet.WAREHOUSE);
            // TODO: Bu kod satırı 'alfaPlastikDataSet.MAINTAINTYPE' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.mAINTAINTYPETableAdapter.Fill(this.alfaPlastikDataSet.MAINTAINTYPE);
            lblKullanici.Text = GirisSayfasi.aktif.NAME;
            lblTarih.Text = DateTime.Now.ToString();

            
            ucIsEmirDuzen11.BringToFront();
            WindowState = FormWindowState.Maximized;

            this.KeyPreview = true;
            if (comboBox_BakimTipi.SelectedValue == null)
            {
                MessageBox.Show("KIRMIZI ALANLARDA SEÇİM YAPMAK ZORUNDASINIZ!");
            }
            ToolTip tool = new ToolTip();
            tool.SetToolTip(buttoncikis, "ÇIKIŞ");
            tool.SetToolTip(BTN_G1, "KAYDET");
        }
        #endregion
      
        #region aşamaları getirme
        private void button_TALEP_Click(object sender, EventArgs e)
        {

            ucIsEmirDuzen11.BringToFront();
            BTN_G1.Visible = true;
        }

        private void button_PLANLAMA_Click(object sender, EventArgs e)
        {
            ucIsEmirDuzen21.BringToFront();
            
            
          // PlanDuzen();
        }

        private void button_PROSES_Click(object sender, EventArgs e)
        {
            ucIsEmirDuzen31.BringToFront();
            
           
          //  ProcessDuzen();
             }

        private void buttoncikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Tamamlanma_Click(object sender, EventArgs e)
        {
            
                ucIsEmirDuzen41.BringToFront();
           // TamamlanmaDuzen();
            }
        #endregion

        #region ESC ile Çıkış
        private void IsEmriDuzenle_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Escape)
            {
                ucIsEmirDuzen21.checkBox2.Checked = false;
                ucIsEmirDuzen21.checkBox3.Checked = false;
                ucIsEmirDuzen21.checkBox4.Checked = false;
                ucIsEmirDuzen21.checkBox5.Checked = false;
                ucIsEmirDuzen21.checkBox6.Checked = false;
                ucIsEmirDuzen21.checkBox7.Checked = false;
                ucIsEmirDuzen21.checkBox8.Checked = false;
                ucIsEmirDuzen21.checkBox9.Checked = false;
                
                this.Close();
            }
        }
        #endregion

        #region Güncelleme Butonu
        private void BTN_G1_Click(object sender, EventArgs e)
        {
            
            V_WRKORD_GRID work = managerV_WRKORD_GRID.Find(y => y.WRKORD_ID == IsEmriEkle.id);

            WRKORD wrk = managerWRKORD.Find(x => x.WRKORD_ID == (int)TBX_İsEmriNo.Tag);
            WL_REQUEST wl1 = managerWL_REQUEST.Find(y => y.WRKID == (int)ucIsEmirDuzen11.comboBox_Öncelik.Tag);
            WL_PLAN wl2 = managerWL_PLAN.Find(w => w.WRKID == (int)ucIsEmirDuzen21.comboBox_BakımPersonel.Tag);
            WL_PROCESS wl3 = managerWL_PROCESS.Find(z => z.WRKID == (int)ucIsEmirDuzen31.richTextBox_yapılan.Tag);
            WL_COMPLETE wl4 = managerWL_COMPLETE.Find(q => q.WRKID == (int)ucIsEmirDuzen41.richTextBox_Teslim.Tag);
            Entities.Models.MOLD m = managerMOLD.Find(a => a.MOLD_ID == (int)comboBox_Kn.SelectedValue);


            if (!string.IsNullOrEmpty(TBX_İsEmriNo.Text))
            {
                if (comboBox_Ambar.SelectedValue != null)
            {
                m.Warehouse_ID = (int)(comboBox_Ambar.SelectedValue);
            }
            if (ucIsEmirDuzen11.comboBox1.SelectedValue != null)
            {
                wl1.REQUEST_BY = (int)(ucIsEmirDuzen11.comboBox1.SelectedValue);
            }
            if (comboBox_BakimTipi.SelectedValue != null)
            {
                wrk.Maintaintype_ID = (int)(comboBox_BakimTipi.SelectedValue);
            }
            if(comboBox_Ka.SelectedValue != null && comboBox_Kn.SelectedValue != null)
            { 
               
                wrk.Mold_ID = (int)(comboBox_Ka.SelectedValue);
                wrk.Mold_ID = (int)(comboBox_Kn.SelectedValue);
            }
                wrk.WRKORD_NO = Convert.ToInt32(TBX_İsEmriNo.Text);
              
                
                wrk.WRKORD_INSERTDATE = dtp_Tarih.Value;
                wrk.STATUS_ = cmb_statü.Text;
                wrk.MODIFIER_ID = GirisSayfasi.aktif.USERS_ID;
                wrk.MODIFYDATE = DateTime.Now;
                wl1.PRIORITY = ucIsEmirDuzen11.comboBox_Öncelik.Text;
                wl1.REQUEST_DATE = ucIsEmirDuzen11.dateTimePicker2.Value;
                wl1.PLANNED_START_DATE = ucIsEmirDuzen11.dateTimePicker3.Value;
                wl1.WRK_NOTE = ucIsEmirDuzen11.rTB.Text;
               
               wl2.MAINTAIN_PERSON = Convert.ToInt32(ucIsEmirDuzen21.comboBox_BakımPersonel.Tag);
               wl2.MAINTAIN_PERSON_NAME = ucIsEmirDuzen21.comboBox_BakımPersonel.Text;
               wl2.ESTIMATED_START_DATE = ucIsEmirDuzen21.dateTimePicker1.Value;
               wl2.PLANNED_TİME = Convert.ToInt32(ucIsEmirDuzen21.textBox_saat.Text);
               wl2.TO_DO_NOTE = ucIsEmirDuzen21.richTextBoxYapılacaklarNot.Text;
              
               wl3.PROCESS_NOTE = ucIsEmirDuzen31.richTextBox_yapılan.Text;

            


                if (ucIsEmirDuzen21.checkBox2.Checked == true)
                {

                    ucIsEmirDuzen31.textBox1.Visible = true;
                    ucIsEmirDuzen31.checkBox2.Visible = true;
                    wl3.OPE1_ID = (int)ucIsEmirDuzen21.comboBox1.SelectedValue;
                    managerWL_PROCESS.Update(wl3);
       
                }


                if (ucIsEmirDuzen21.checkBox3.Checked == true)
                {

                    ucIsEmirDuzen31.textBox2.Visible = true;
                    ucIsEmirDuzen31.checkBox3.Visible = true;
                    wl3.OPE2_ID = (int)ucIsEmirDuzen21.comboBox2.SelectedValue;

                }



                if (ucIsEmirDuzen21.checkBox4.Checked == true)
                {

                    ucIsEmirDuzen31.textBox3.Visible = true;
                    ucIsEmirDuzen31.checkBox4.Visible = true;
                    wl3.OPE3_ID = (int)ucIsEmirDuzen21.comboBox3.SelectedValue;

                }



                if (ucIsEmirDuzen21.checkBox5.Checked == true)
                {

                    ucIsEmirDuzen31.textBox4.Visible = true;
                    ucIsEmirDuzen31.checkBox5.Visible = true;
                    wl3.OPE4_ID = (int)ucIsEmirDuzen21.comboBox4.SelectedValue;

                }



                if (ucIsEmirDuzen21.checkBox6.Checked == true)
                {

                    ucIsEmirDuzen31.textBox5.Visible = true;
                    ucIsEmirDuzen31.checkBox6.Visible = true;
                    wl3.OPE5_ID = (int)ucIsEmirDuzen21.comboBox5.SelectedValue;

                }



                if (ucIsEmirDuzen21.checkBox7.Checked == true)
                {

                    ucIsEmirDuzen31.textBox6.Visible = true;
                    ucIsEmirDuzen31.checkBox7.Visible = true;
                    wl3.OPE6_ID = (int)ucIsEmirDuzen21.comboBox6.SelectedValue;

                }



                if (ucIsEmirDuzen21.checkBox8.Checked == true)
                {

                    ucIsEmirDuzen31.textBox7.Visible = true;
                    ucIsEmirDuzen31.checkBox8.Visible = true;
                    wl3.OPE7_ID = (int)ucIsEmirDuzen21.comboBox7.SelectedValue;

                }



                if (ucIsEmirDuzen21.checkBox9.Checked == true)
                {

                    ucIsEmirDuzen31.textBox8.Visible = true;
                    ucIsEmirDuzen31.checkBox9.Visible = true;
                    wl3.OPE8_ID = (int)ucIsEmirDuzen21.comboBox8.SelectedValue;

                }


                if (ucIsEmirDuzen31.checkBox2.Checked == true) 
                {
                    wl3.OPE1_DATE = DateTime.Now;
                }
                if (ucIsEmirDuzen31.checkBox3.Checked == true)
                {
                    wl3.OPE2_DATE = DateTime.Now;
                }
                if (ucIsEmirDuzen31.checkBox4.Checked == true)
                {
                    wl3.OPE3_DATE = DateTime.Now;
                }
                if (ucIsEmirDuzen31.checkBox5.Checked == true)
                {
                    wl3.OPE4_DATE = DateTime.Now;
                }
                if (ucIsEmirDuzen31.checkBox6.Checked == true)
                {
                    wl3.OPE5_DATE = DateTime.Now;
                }
                if (ucIsEmirDuzen31.checkBox7.Checked == true)
                {
                    wl3.OPE6_DATE = DateTime.Now;
                }
                if (ucIsEmirDuzen31.checkBox8.Checked == true)
                {
                    wl3.OPE7_DATE = DateTime.Now;
                }
                if (ucIsEmirDuzen31.checkBox9.Checked == true)
                {
                    wl3.OPE8_DATE = DateTime.Now;
                }


                wl4.DELIVERY_TYPE = ucIsEmirDuzen41.comboBox1.Text;
                    wl4.DELIVERY_NOTE = ucIsEmirDuzen41.richTextBox_Teslim.Text;
                    wl4.COMPLETION_TİME = ucIsEmirDuzen41.dateTimePicker2.Value.TimeOfDay;
                    wl4.COMPLETION_DATE = ucIsEmirDuzen41.dateTimePicker1.Value;
               
                managerMOLD.Update(m);
                int sonuc = managerWRKORD.Update(wrk);
                    managerWL_REQUEST.Update(wl1);
                    managerWL_PLAN.Update(wl2);
                    managerWL_PROCESS.Update(wl3);
                    managerWL_COMPLETE.Update(wl4);
                   
                    if (sonuc >= 0)
                    {
                        MessageBox.Show("Kayıt Güncellendi");

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

        #region ComboBoxa tıklandığında listeleme
        private void comboBox_BakimTipi_MouseClick(object sender, MouseEventArgs e)
        {
            comboBox_BakimTipi.DataSource = managerMAINTAINTYPE.List();
            comboBox_BakimTipi.DisplayMember = "MAINTAINTYPE_NAME";
            comboBox_BakimTipi.ValueMember = "MAINTAINTYPE_ID";
            comboBox_BakimTipi.BackColor = Color.Gainsboro;
            comboBox_BakimTipi.ForeColor = Color.Black;
            comboBox_BakimTipi.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Regular);
        }
        private void comboBox_Ambar_MouseClick(object sender, MouseEventArgs e)
        {
            comboBox_Ambar.DataSource = managerWAREHOUSE.List();
            comboBox_Ambar.DisplayMember = "WAREHOUSE_NAME";
            comboBox_Ambar.ValueMember = "WAREHOUSE_ID";
        }
        private void comboBox_Kn_MouseClick(object sender, MouseEventArgs e)
        {
            comboBox_Kn.DataSource = managerMOLD.List();
            comboBox_Kn.DisplayMember = "MOLD_NO";
            comboBox_Kn.ValueMember = "MOLD_ID";
            comboBox_Ka.DataSource = comboBox_Kn.DataSource;
            comboBox_Ka.DisplayMember = "MOLD_NAME";
            comboBox_Ka.ValueMember = "MOLD_ID";
            comboBox_Ka.BackColor = Color.Gainsboro;
            comboBox_Ka.ForeColor = Color.Black;
            comboBox_Kn.BackColor = Color.Gainsboro;
            comboBox_Kn.ForeColor = Color.Black;
            comboBox_Ka.Font = new Font("Microsoft Sans Serif" ,8,FontStyle.Regular);
            comboBox_Kn.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Regular);
        }
        private void comboBox_Ka_MouseClick(object sender, MouseEventArgs e)
        {
            comboBox_Ka.DataSource = managerMOLD.List();
            comboBox_Ka.DisplayMember = "MOLD_NAME";
            comboBox_Ka.ValueMember = "MOLD_ID";
            comboBox_Kn.DataSource = comboBox_Ka.DataSource;
            comboBox_Kn.DisplayMember = "MOLD_NO";
            comboBox_Kn.ValueMember = "MOLD_ID";
            comboBox_Ka.BackColor = Color.Gainsboro;
            comboBox_Ka.ForeColor = Color.Black;
            comboBox_Kn.BackColor = Color.Gainsboro;
            comboBox_Kn.ForeColor = Color.Black;
            comboBox_Ka.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Regular);
            comboBox_Kn.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Regular);
        }

       
            
        #endregion
        private void comboBox_Ka_KeyPress(object sender, KeyPressEventArgs e)
        {
            ns.IntOrStringNo(e);
        }
        
        private void TBX_İsEmriNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            ns.StringNo(e);
        }
        
        
        
        private void button_PLANLAMA_Click_1(object sender, EventArgs e)
        {
                    ucIsEmirDuzen21.BringToFront();
                    opelist();
        }


        private void button_PROSES_Click_1(object sender, EventArgs e)
        {
          

            ucIsEmirDuzen31.BringToFront();
           
        }

        private void btn_Tamamlanma_Click_1(object sender, EventArgs e)
        {
            ucIsEmirDuzen41.BringToFront();
        }

       

        private void button_TALEP_Click_1(object sender, EventArgs e)
        {
            ucIsEmirDuzen11.BringToFront();
        }

        private void textBox_Kullanici_KeyPress(object sender, KeyPressEventArgs e)
        {
            ns.IntOrStringNo(e);
        }
    }
}
