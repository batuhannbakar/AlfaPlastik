using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Alfa.BusinessLayer;
using Alfa.DataAccessLayer.EntityFramework;
using Alfa.Entities.Models;

namespace Alfa.MAINTAINTYPE
{
    public partial class ucBakimTipiGor : UserControl
    {
      
        Entities.Models.MAINTAINTYPE M = new Entities.Models.MAINTAINTYPE();
        MaintaintypeDal dal = new MaintaintypeDal();
        Block ns = new Block();
        public ucBakimTipiGor()
        {
            InitializeComponent();
            
        }

        #region BAKIMTİPİ LOAD KISMI
        private void ucBakimTipiGor_Load(object sender, EventArgs e)
        {
           
        Listele();
            #region TOOLTİP 
            ToolTip tool = new ToolTip();
            tool.SetToolTip(btn_duzen_kyt, "Kaydet");
            tool.SetToolTip(btn_ekle, "KAYDET");
            tool.SetToolTip(button_Ekle, "EKLE");//MOUSE GELDİĞİNDE EKLE YAZAR.
            tool.SetToolTip(button_Sil, "SİL");//MOUSE GELDİĞİNDE SİL YAZAR.
            tool.SetToolTip(button_Duzenle, "DÜZENLE");//MOUSE GELDİĞİNDE DÜZENLE YAZAR.
            tool.SetToolTip(buton_incele, "İNCELE");
            #endregion
            btn_duzen_kyt.Visible = false;
        }
        #endregion

        #region LİSTELEME METODU
        public void Listele()
        {

            dataGridView1.DataSource = dal.GetAll();//MAINTAINTYPE TABLOSUNU LİSTELER
            
            dataGridView1.Columns["MAINTAINTYPE_ID"].Visible = false;
            dataGridView1.Columns["Bakım_Tipi_Tarihi"].Visible = false;
            

            //TABLONUN TASARIM AYARLARI
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.White;
            dataGridView1.BackgroundColor = Color.Gainsboro;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.Gold;
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
        }
        #endregion       

        #region EKLEME TEMİZLEME BUTONU 
        private void button_Ekle_Click(object sender, EventArgs e)
        {
            textBox_Name.Enabled = true;
            textBox_No.Enabled = true;
           
            textBox_Name.Clear();
            textBox_No.Clear();
            btn_ekle.Visible = true;
            btn_duzen_kyt.Visible = false;
            label4.Text = "BAKIM TİPİ EKLEME";
        }
        #endregion
    
        #region DÜZENELEME KAYIT ÇEKME
        private void button_Duzenle_Click(object sender, EventArgs e)
        {
            btn_ekle.Visible = false;
            btn_duzen_kyt.Visible = true;
            textBox_No.Enabled = true;
            textBox_Name.Enabled = true;
            label4.Text = "BAKIM TİPİ DÜZENLEME";
            DataGridViewRow row = dataGridView1.CurrentRow;
            textBox_Name.Tag = row.Cells["MAINTAINTYPE_ID"].Value;
            textBox_No.Text = this.dataGridView1.CurrentRow.Cells["Bakım_Tipi_Numarası"].Value.ToString();
            textBox_Name.Text = this.dataGridView1.CurrentRow.Cells["Bakım_Tipi_İsmi"].Value.ToString();
        }
        #endregion

        #region SATIRA ÇİFT TIKLAYARAK DÜZENLEME
        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            btn_ekle.Visible = false;
            textBox_No.Enabled = true;
            textBox_Name.Enabled = true;
            btn_duzen_kyt.Visible = true;
            label4.Text = "BAKIM TİPİ DÜZENLEME";
           
            DataGridViewRow row = dataGridView1.CurrentRow;
            //  BakimTipiDuzenle bd = new BakimTipiDuzenle();
            textBox_Name.Tag = row.Cells["MAINTAINTYPE_ID"].Value;
            textBox_No.Text = this.dataGridView1.CurrentRow.Cells["Bakım_Tipi_Numarası"].Value.ToString();
            textBox_Name.Text = this.dataGridView1.CurrentRow.Cells["Bakım_Tipi_İsmi"].Value.ToString();
            
            //   bd.ShowDialog();
        }
        #endregion

        #region İNCELEME BUTONU
        private void buton_incele_Click(object sender, EventArgs e)
        {
            btn_ekle.Visible = false;
            btn_duzen_kyt.Visible = false;
            label4.Text = "BAKIM TİPİ İNCELEME";
            DataGridViewRow row = dataGridView1.CurrentRow;
            //BakimTipIncele bi = new BakimTipIncele();
            textBox_Name.Tag = row.Cells["MAINTAINTYPE_ID"].Value;
            textBox_No.Text = this.dataGridView1.CurrentRow.Cells["Bakım_Tipi_Numarası"].Value.ToString();
            textBox_No.Enabled = false;
            textBox_Name.Text = this.dataGridView1.CurrentRow.Cells["Bakım_Tipi_İsmi"].Value.ToString();
            textBox_Name.Enabled = false;
           
            //bi.ShowDialog();
        }
        #endregion
        #region Ekleme işlemi
        private void btn_ekle_Click_1(object sender, EventArgs e)
        {
           
             if (!string.IsNullOrEmpty(textBox_Name.Text) && !string.IsNullOrEmpty(textBox_No.Text))
             {

                    M.MAINTAINTYPE_INSERTDATE = DateTime.Now;
                    M.MAINTAINTYPE_NAME = textBox_Name.Text;
                    M.MAINTAINTYPE_NO = Convert.ToInt32(textBox_No.Text);
                    dal.Add(M);
                    Listele();
                    textBox_Name.Clear();
                    textBox_No.Clear();                                          
             }                          
                else
                {
                    MessageBox.Show("Lütfen Tüm Alanları Doldurunuz");
                }
            }
          
        #endregion
        #region BAKIMTİPİ SİLME İşlemi
        private void button_Sil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bu satırı sil !!!", "BAKIM TİPİ SİL!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (dataGridView1.CurrentRow != null)
                {
                    M.MAINTAINTYPE_ID = Convert.ToInt32(dataGridView1.CurrentRow.Cells["MAINTAINTYPE_ID"].Value);
                    dal.Delete(M);

                    Listele();
                    
                }
            }
        }
        #endregion
        #region DÜZENLEME İşlemi

        private void btn_duzen_kyt_Click(object sender, EventArgs e)
        {
            //try
            //{
               
                if (!string.IsNullOrEmpty(textBox_Name.Text) && !string.IsNullOrEmpty(textBox_No.Text))
                {

                //var mevcut = context.MAINTAINTYPEs.Where(x => x.MAINTAINTYPE_ID == (int)textBox_Name.Tag).FirstOrDefault();
                M.MAINTAINTYPE_ID = Convert.ToInt32(dataGridView1.CurrentRow.Cells["MAINTAINTYPE_ID"].Value);
               
                M.MAINTAINTYPE_NAME = textBox_Name.Text;
                M.MAINTAINTYPE_NO = Convert.ToInt32(textBox_No.Text);
                dal.Update(M);
                Listele();
                    textBox_Name.Text = null;
                    textBox_No.Text = null;
                    btn_duzen_kyt.Visible = false;
                       
                }
                else
                {
                    MessageBox.Show("Boş alanı doldurunuz.");
                }
            //}
            //catch (Exception)
            //{

            //    MessageBox.Show("Aynı Değer Girilemez"); 
            //}
          
        }
        #endregion

      
        #region ENTER ile Textbox geçme 
        private void textBox_No_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                textBox_Name.Focus();
            }
        }

        
        #endregion
        #region SEÇİLİ SATIR GELMEMESİNİ SAĞLAYAN İŞLEM
        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridView1.Rows[0].Selected = false;
        }
        #endregion

        private void textBox_No_KeyPress(object sender, KeyPressEventArgs e)
        {
            ns.StringNo(e);
        }
    }
}

       
   
 