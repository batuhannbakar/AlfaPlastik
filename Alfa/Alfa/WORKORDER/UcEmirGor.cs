using System;
using System.Drawing;
using System.Windows.Forms;
using Alfa.Entities.Models;

namespace Alfa.WORKORDER
{
    public partial class UcEmirGor : UserControl
    {
        WorkorderDal dal = new WorkorderDal();
        WRKORD w = new WRKORD();
        Ucisemir2Dal dal2 = new Ucisemir2Dal();
      
        #region LİSTELEME
        public void Listele()
        {
            dataGridView1.DataSource = dal.GetAll();
            dataGridView1.Columns["WRKORD_ID"].Visible = false;
            dataGridView1.Columns["USERS_ID"].Visible = false;
            dataGridView1.Columns["REQUEST_BY"].Visible = false;
            dataGridView1.Columns["MAINTAIN_PERSON"].Visible = false;
            //TABLO TASARIMI
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.White;
            dataGridView1.BackgroundColor = Color.Gainsboro;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.Gold;
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;

        }
        #endregion

        public UcEmirGor()
        {
            InitializeComponent();
            
        }
        #region EmirGör Load
        private void UcEmirGor_Load(object sender, EventArgs e)
        {
            ToolTip tool = new ToolTip();
            tool.SetToolTip(button_Ekle, "EKLE");
            tool.SetToolTip(button_Sil, "SİL");
            tool.SetToolTip(button_Duzenle, "DÜZENLE");
            Listele();
        }
        #endregion
        public void btn_ekle()
        {
            IsEmriEkle isemriekle = new IsEmriEkle();
            int index = dataGridView1.Rows.Count - 1;
            isemriekle.TBX_İsEmriNo.Text = Convert.ToString(Convert.ToInt32(dataGridView1.Rows[index].Cells["İş_Emri_No"].Value)+1);
            isemriekle.ShowDialog();

        }
        #region ekleme butonu tıklama
        private void button_Ekle_Click_1(object sender, EventArgs e)
        {
            btn_ekle();
        }
        #endregion
        #region SİLME İŞLEMİ
        private void button_Sil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bu satırı sil !!!", "EMİR SİL!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (dataGridView1.CurrentRow != null)
                {
                        w.WRKORD_ID= Convert.ToInt32(dataGridView1.CurrentRow.Cells["WRKORD_ID"].Value);
                        dal.Delete(w);
                        Listele();
                } 
            }           
        }
        #endregion
        #region düzenleme butonu tıklama    
        public void DuzenGetir()
        {
            IsEmriDuzenle isemriduzenle = new IsEmriDuzenle();

            DataGridViewRow row = dataGridView1.CurrentRow;

            isemriduzenle.TBX_İsEmriNo.Tag = row.Cells["WRKORD_ID"].Value;
            isemriduzenle.TBX_İsEmriNo.Text = this.dataGridView1.CurrentRow.Cells["İş_Emri_No"].Value.ToString();
            isemriduzenle.cmb_statü.Text = this.dataGridView1.CurrentRow.Cells["Statü"].Value.ToString();
            isemriduzenle.dtp_Tarih.Value = (DateTime)(this.dataGridView1.CurrentRow.Cells["İş_Emri_Tarihi"].Value);
            isemriduzenle.textBox_Kullanici.Text = this.dataGridView1.CurrentRow.Cells["KULLANICI"].Value.ToString();
            isemriduzenle.comboBox_BakimTipi.Text = this.dataGridView1.CurrentRow.Cells["Bakım_Tipi"].Value.ToString();
            isemriduzenle.comboBox_Ka.Text = this.dataGridView1.CurrentRow.Cells["Kalıp_Adı"].Value.ToString();
            isemriduzenle.comboBox_Ambar.Text = this.dataGridView1.CurrentRow.Cells["Kalıp_Yeri"].Value.ToString();
            isemriduzenle.comboBox_Kn.Text = this.dataGridView1.CurrentRow.Cells["Kalıp_No"].Value.ToString();
            isemriduzenle.ucIsEmirDuzen11.comboBox_Öncelik.Tag = row.Cells["WRKORD_ID"].Value;
            isemriduzenle.ucIsEmirDuzen11.comboBox_Öncelik.Text = dataGridView1.CurrentRow.Cells["PRIORITY"].Value.ToString();
            isemriduzenle.ucIsEmirDuzen11.comboBox1.Text = dataGridView1.CurrentRow.Cells["Talep_Eden"].Value.ToString();
            isemriduzenle.ucIsEmirDuzen11.dateTimePicker3.Value = (DateTime)(dataGridView1.CurrentRow.Cells["REQUEST_DATE"].Value);
            isemriduzenle.ucIsEmirDuzen11.dateTimePicker2.Value = (DateTime)(dataGridView1.CurrentRow.Cells["PLANNED_START_DATE"].Value);
            isemriduzenle.ucIsEmirDuzen11.rTB.Text = dataGridView1.CurrentRow.Cells["WRK_NOTE"].Value.ToString();
            isemriduzenle.ucIsEmirDuzen21.comboBox_BakımPersonel.Tag = row.Cells["WRKORD_ID"].Value;
            isemriduzenle.ucIsEmirDuzen21.richTextBox_TalepNot.Text = dataGridView1.CurrentRow.Cells["WRK_NOTE"].Value.ToString();
            isemriduzenle.ucIsEmirDuzen21.textBox_tarih.Text = (dataGridView1.CurrentRow.Cells["PLANNED_START_DATE"].Value.ToString());
            isemriduzenle.ucIsEmirDuzen21.richTextBoxYapılacaklarNot.Text = dataGridView1.CurrentRow.Cells["TO_DO_NOTE"].Value.ToString();
            isemriduzenle.ucIsEmirDuzen21.comboBox_BakımPersonel.Text = dataGridView1.CurrentRow.Cells["Bakım_Personeli"].Value.ToString();
            isemriduzenle.ucIsEmirDuzen21.textBox_saat.Text = dataGridView1.CurrentRow.Cells["PLANNED_TİME"].Value.ToString();
            isemriduzenle.ucIsEmirDuzen21.dateTimePicker1.Text = dataGridView1.CurrentRow.Cells["ESTIMATED_START_DATE"].Value.ToString();
            isemriduzenle.ucIsEmirDuzen31.richTextBox_yapılan.Tag = row.Cells["WRKORD_ID"].Value;
            isemriduzenle.ucIsEmirDuzen31.richTextBox_isemir.Text = dataGridView1.CurrentRow.Cells["WRK_NOTE"].Value.ToString();
            isemriduzenle.ucIsEmirDuzen31.richTextBox_yapilacak.Text = dataGridView1.CurrentRow.Cells["TO_DO_NOTE"].Value.ToString();
            isemriduzenle.ucIsEmirDuzen31.richTextBox_yapılan.Text = dataGridView1.CurrentRow.Cells["PROCESS_NOTE"].Value.ToString();
            isemriduzenle.ucIsEmirDuzen41.richTextBox_Teslim.Tag = row.Cells["WRKORD_ID"].Value;
            isemriduzenle.ucIsEmirDuzen41.richTextBox2.Text = dataGridView1.CurrentRow.Cells["PROCESS_NOTE"].Value.ToString();
            isemriduzenle.ucIsEmirDuzen41.richTextBox_Teslim.Text = dataGridView1.CurrentRow.Cells["DELIVERY_NOTE"].Value.ToString();
            isemriduzenle.ucIsEmirDuzen41.comboBox1.Text = dataGridView1.CurrentRow.Cells["DELIVERY_TYPE"].Value.ToString();
            isemriduzenle.ucIsEmirDuzen41.dateTimePicker1.Text = dataGridView1.CurrentRow.Cells["COMPLETION_DATE"].Value.ToString();
            isemriduzenle.ucIsEmirDuzen41.dateTimePicker2.Text = dataGridView1.CurrentRow.Cells["COMPLETION_TİME"].Value.ToString();



            if (dataGridView1.CurrentRow.Cells["OPE1"].Value != null)
            {
                isemriduzenle.ucIsEmirDuzen21.checkBox2.Checked = true;
                isemriduzenle.ucIsEmirDuzen31.textBox1.Visible = true;
                isemriduzenle.ucIsEmirDuzen31.checkBox2.Visible = true;
                isemriduzenle.ucIsEmirDuzen31.textBox1.Text = dataGridView1.CurrentRow.Cells["OPE1"].Value.ToString();
                if (dataGridView1.CurrentRow.Cells["OPE1_DATE"].Value !=null)
                {
                    isemriduzenle.ucIsEmirDuzen31.textBox1.Visible = true;
                    isemriduzenle.ucIsEmirDuzen31.textBox1.Text= dataGridView1.CurrentRow.Cells["OPE1"].Value.ToString();
                    isemriduzenle.ucIsEmirDuzen31.checkBox2.Visible = true;
                    isemriduzenle.ucIsEmirDuzen31.checkBox2.Checked = true;
                }
            }
            if (dataGridView1.CurrentRow.Cells["OPE2"].Value != null)
            {
                isemriduzenle.ucIsEmirDuzen21.checkBox3.Checked = true;
                isemriduzenle.ucIsEmirDuzen31.textBox2.Visible = true;
                isemriduzenle.ucIsEmirDuzen31.checkBox3.Visible = true;
                isemriduzenle.ucIsEmirDuzen31.textBox2.Text = dataGridView1.CurrentRow.Cells["OPE2"].Value.ToString();
                if (dataGridView1.CurrentRow.Cells["OPE2_DATE"].Value != null)
                {
                    isemriduzenle.ucIsEmirDuzen31.textBox2.Visible = true;
                    isemriduzenle.ucIsEmirDuzen31.textBox2.Text = dataGridView1.CurrentRow.Cells["OPE2"].Value.ToString();
                    isemriduzenle.ucIsEmirDuzen31.checkBox3.Visible = true;
                    isemriduzenle.ucIsEmirDuzen31.checkBox3.Checked = true;
                }
            }
            if (dataGridView1.CurrentRow.Cells["OPE3"].Value != null)
            {
                isemriduzenle.ucIsEmirDuzen21.checkBox4.Checked = true;
                isemriduzenle.ucIsEmirDuzen31.textBox3.Visible = true;
                isemriduzenle.ucIsEmirDuzen31.checkBox4.Visible = true;
                isemriduzenle.ucIsEmirDuzen31.textBox3.Text = dataGridView1.CurrentRow.Cells["OPE3"].Value.ToString();
                if (dataGridView1.CurrentRow.Cells["OPE3_DATE"].Value != null)
                {
                    isemriduzenle.ucIsEmirDuzen31.textBox3.Visible = true;
                    isemriduzenle.ucIsEmirDuzen31.textBox3.Text = dataGridView1.CurrentRow.Cells["OPE3"].Value.ToString();
                    isemriduzenle.ucIsEmirDuzen31.checkBox4.Visible = true;
                    isemriduzenle.ucIsEmirDuzen31.checkBox4.Checked = true;
                }
            }
            if (dataGridView1.CurrentRow.Cells["OPE4"].Value != null)
            {
                isemriduzenle.ucIsEmirDuzen21.checkBox5.Checked = true;
                isemriduzenle.ucIsEmirDuzen31.textBox4.Visible = true;
                isemriduzenle.ucIsEmirDuzen31.checkBox5.Visible = true;
                isemriduzenle.ucIsEmirDuzen31.textBox4.Text = dataGridView1.CurrentRow.Cells["OPE4"].Value.ToString();
                if (dataGridView1.CurrentRow.Cells["OPE4_DATE"].Value != null)
                {
                    isemriduzenle.ucIsEmirDuzen31.textBox4.Visible = true;
                    isemriduzenle.ucIsEmirDuzen31.textBox4.Text = dataGridView1.CurrentRow.Cells["OPE4"].Value.ToString();
                    isemriduzenle.ucIsEmirDuzen31.checkBox5.Visible = true;
                    isemriduzenle.ucIsEmirDuzen31.checkBox5.Checked = true;
                }
            }
            if (dataGridView1.CurrentRow.Cells["OPE5"].Value != null)
            {
                isemriduzenle.ucIsEmirDuzen21.checkBox6.Checked = true;
                isemriduzenle.ucIsEmirDuzen31.textBox5.Visible = true;
                isemriduzenle.ucIsEmirDuzen31.checkBox6.Visible = true;
                isemriduzenle.ucIsEmirDuzen31.textBox5.Text = dataGridView1.CurrentRow.Cells["OPE5"].Value.ToString();
                if (dataGridView1.CurrentRow.Cells["OPE5_DATE"].Value != null)
                {
                    isemriduzenle.ucIsEmirDuzen31.textBox5.Visible = true;
                    isemriduzenle.ucIsEmirDuzen31.textBox5.Text = dataGridView1.CurrentRow.Cells["OPE5"].Value.ToString();
                    isemriduzenle.ucIsEmirDuzen31.checkBox6.Visible = true;
                    isemriduzenle.ucIsEmirDuzen31.checkBox6.Checked = true;
                }
            }
            if (dataGridView1.CurrentRow.Cells["OPE6"].Value != null)
            {
                isemriduzenle.ucIsEmirDuzen21.checkBox7.Checked = true;
                isemriduzenle.ucIsEmirDuzen31.textBox6.Visible = true;
                isemriduzenle.ucIsEmirDuzen31.checkBox7.Visible = true;
                isemriduzenle.ucIsEmirDuzen31.textBox6.Text = dataGridView1.CurrentRow.Cells["OPE6"].Value.ToString();
                if (dataGridView1.CurrentRow.Cells["OPE6_DATE"].Value != null)
                {
                    isemriduzenle.ucIsEmirDuzen31.textBox6.Visible = true;
                    isemriduzenle.ucIsEmirDuzen31.textBox6.Text = dataGridView1.CurrentRow.Cells["OPE6"].Value.ToString();
                    isemriduzenle.ucIsEmirDuzen31.checkBox7.Visible = true;
                    isemriduzenle.ucIsEmirDuzen31.checkBox7.Checked = true;
                }
            }
            if (dataGridView1.CurrentRow.Cells["OPE7"].Value != null)
            {
                isemriduzenle.ucIsEmirDuzen21.checkBox8.Checked = true;
                isemriduzenle.ucIsEmirDuzen31.textBox7.Visible = true;
                isemriduzenle.ucIsEmirDuzen31.checkBox8.Visible = true;
                isemriduzenle.ucIsEmirDuzen31.textBox7.Text = dataGridView1.CurrentRow.Cells["OPE7"].Value.ToString();
                if (dataGridView1.CurrentRow.Cells["OPE7_DATE"].Value != null)
                {
                    isemriduzenle.ucIsEmirDuzen31.textBox7.Visible = true;
                    isemriduzenle.ucIsEmirDuzen31.textBox7.Text = dataGridView1.CurrentRow.Cells["OPE7"].Value.ToString();
                    isemriduzenle.ucIsEmirDuzen31.checkBox8.Visible = true;
                    isemriduzenle.ucIsEmirDuzen31.checkBox8.Checked = true;
                }
            }
            if (dataGridView1.CurrentRow.Cells["OPE8"].Value != null)
            {
                isemriduzenle.ucIsEmirDuzen21.checkBox9.Checked = true;
                isemriduzenle.ucIsEmirDuzen31.textBox8.Visible = true;
                isemriduzenle.ucIsEmirDuzen31.checkBox9.Visible = true;
                isemriduzenle.ucIsEmirDuzen31.textBox8.Text = dataGridView1.CurrentRow.Cells["OPE8"].Value.ToString();
                if (dataGridView1.CurrentRow.Cells["OPE8_DATE"].Value != null)
                {
                    isemriduzenle.ucIsEmirDuzen31.textBox8.Visible = true;
                    isemriduzenle.ucIsEmirDuzen31.textBox8.Text = dataGridView1.CurrentRow.Cells["OPE8"].Value.ToString();
                    isemriduzenle.ucIsEmirDuzen31.checkBox9.Visible = true;
                    isemriduzenle.ucIsEmirDuzen31.checkBox9.Checked = true;
                }
            }
          

            isemriduzenle.ShowDialog();
        }
        private void button_Duzenle_Click(object sender, EventArgs e)
        {
            DuzenGetir();

        }
        #endregion

        #region satırın seçili gelmemesi işlemi
        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
           dataGridView1.Rows[0].Selected = false;
        }
        #endregion

       
    }


}

