using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Alfa.BusinessLayer;
using Alfa.DataAccessLayer.EntityFramework;
using Alfa.Entities.Models;

namespace Alfa.WAREHOUSE
{
    public partial class ucAmbarGor : UserControl
    {
        WarehouseDal dal = new WarehouseDal();
        Block ns = new Block();
        Entities.Models.WAREHOUSE w = new Entities.Models.WAREHOUSE();
        V_MOLD ML = new V_MOLD();
       
        public ucAmbarGor()
        {
            InitializeComponent();

           
        }

        #region AMBAR LOAD KISMI
        private void ucAmbarGor_Load(object sender, EventArgs e)
        {
            Listele();
            ToolTip tool = new ToolTip();
            tool.SetToolTip(button_EKLE, "Kaydet");
            tool.SetToolTip(btn_duzen_kyt, "KAYDET");
            tool.SetToolTip(btn_ekle, "EKLE");//MOUSE GELDİĞİNDE EKLE YAZAR.
            tool.SetToolTip(btn_sil, "SİL");//MOUSE GELDİĞİNDE SİL YAZAR.
            tool.SetToolTip(btn_duzen, "DÜZENLE");//MOUSE GELDİĞİNDE DÜZENLE YAZAR.
            tool.SetToolTip(btn_incele, "İNCELE");
        }
        #endregion

        #region Listeleme METODU
        public void Listele()
        {
            dataGridView1.DataSource =dal.GetAll();//WAREHOUSE TABLOSUNU LİSTELER.
            
            
            dataGridView1.Columns["WAREHOUSE_ID"].Visible = false;
            dataGridView1.Columns["Ambar_Tarihi"].Visible = false;
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

        #region  Ekleme Butonu
        private void btn_ekle_Click_1(object sender, EventArgs e)
        {
            button_EKLE.Visible = true;
            textBox_Name.Enabled = true;
            textBox_Name.Clear();
            textBox_No.Enabled = true;
            textBox_No.Clear();
           
            btn_duzen_kyt.Visible = false;

            label4.Text = "AMBAR EKLEME";

        }

        #endregion

        #region DÜZENLEME KAYITLARINI ÇEKME
        private void btn_duzen_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                button_EKLE.Visible = false;
                textBox_No.Enabled = true;
                textBox_Name.Enabled = true;
               
                DataGridViewRow row = dataGridView1.CurrentRow;
                //AmbarDuzenle ad = new AmbarDuzenle();
                textBox_Name.Tag = row.Cells["WAREHOUSE_ID"].Value;
                textBox_No.Text = this.dataGridView1.CurrentRow.Cells["Ambar_Numarası"].Value.ToString();
                textBox_Name.Text = this.dataGridView1.CurrentRow.Cells["Ambar_İsmi"].Value.ToString();
               
                btn_duzen_kyt.Visible = true;
                label4.Text = "AMBAR DÜZENLEME";
                //ad.ShowDialog();
            }
        }
        #endregion

        #region İNCELEME BUTONU
        private void btn_incele_Click(object sender, EventArgs e)
        {
            button_EKLE.Visible = false;
            btn_duzen_kyt.Visible = false;
            DataGridViewRow row = dataGridView1.CurrentRow;
            // AmbarIncele ai = new AmbarIncele();
            textBox_Name.Tag = row.Cells["WAREHOUSE_ID"].Value;
            textBox_No.Text = this.dataGridView1.CurrentRow.Cells["Ambar_Numarası"].Value.ToString();
            textBox_No.Enabled = false;
            textBox_Name.Text = this.dataGridView1.CurrentRow.Cells["Ambar_İsmi"].Value.ToString();
            textBox_Name.Enabled = false;
           
            label4.Text = "AMBAR İNCELEME";
            // ai.ShowDialog();
        }
        #endregion

        #region Ekleme işlemi
        private void button_EKLE_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox_Name.Text) && !string.IsNullOrEmpty(textBox_No.Text))
            {

                w.WAREHOUSE_INSERTDATE = DateTime.Now;
                w.WAREHOUSE_NAME = textBox_Name.Text;
                w.WAREHOUSE_NO = Convert.ToInt32(textBox_No.Text);
                dal.Add(w);
                        
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

        #region SATIRA ÇİFT TIK İLE DÜZENLEME 
        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            button_EKLE.Visible = false;
            textBox_No.Enabled = true;
            textBox_Name.Enabled = true;
           
            label4.Text = "AMBAR DÜZENLEME";
            DataGridViewRow row = dataGridView1.CurrentRow;
            //AmbarDuzenle ad = new AmbarDuzenle();
            textBox_Name.Tag = row.Cells["WAREHOUSE_ID"].Value;
            textBox_No.Text = this.dataGridView1.CurrentRow.Cells["Ambar_Numarası"].Value.ToString();
            textBox_Name.Text = this.dataGridView1.CurrentRow.Cells["Ambar_İsmi"].Value.ToString();
            
            btn_duzen_kyt.Visible = true;
            //ad.ShowDialog();
        }

        #endregion

        #region Düzenleme İşlemi

        private void btn_duzen_kyt_Click(object sender, EventArgs e)
        {
            //try
            //{
               
                if (!string.IsNullOrEmpty(textBox_Name.Text) && !string.IsNullOrEmpty(textBox_No.Text))
                {
                    w.WAREHOUSE_ID = Convert.ToInt32(dataGridView1.CurrentRow.Cells["WAREHOUSE_ID"].Value);
                   
                    w.WAREHOUSE_NAME = textBox_Name.Text;
                    w.WAREHOUSE_NO = Convert.ToInt32(textBox_No.Text);
                dal.Update(w);
                    textBox_Name.Clear();
                    textBox_No.Clear();
                    btn_duzen_kyt.Visible = false;
                    Listele();
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

        #region AMBAR Silme İŞLEMİ

        private void btn_sil_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bu satırı sil !!!", "AMBAR SİL!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (dataGridView1.CurrentRow != null)
                {
                    w.WAREHOUSE_ID = Convert.ToInt32(dataGridView1.CurrentRow.Cells["WAREHOUSE_ID"].Value);
                    //var itemToRemove = context.WAREHOUSEs.SingleOrDefault(x => x.WAREHOUSE_ID == ware_id);
                    //var sonuc = context.MOLDs.Any(y => y.Warehouse_ID == ware_id);
                    //if (sonuc == true)
                    //{
                    //MessageBox.Show("Kayıt Silinemez");

                    //}
                    //else
                    //{
                    dal.Delete(w);
                    
                    Listele();
                }
                    //}
     
                //}
            }     
        }
        #endregion


        #region ENTER ile Textbox geçme 
        private void textBox_No_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
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
