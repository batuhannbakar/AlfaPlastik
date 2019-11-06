using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Alfa.BusinessLayer;
using Alfa.DataAccessLayer.EntityFramework;
using Alfa.Entities.Models;

namespace Alfa.MOLD
{
    public partial class ucKalıpGor : UserControl
    {
        MoldDal dal = new MoldDal();
        Block ns = new Block();
        Entities.Models.MOLD m= new Entities.Models.MOLD();
        public ucKalıpGor()
        {
            InitializeComponent();
            
            
        }
        #region KALIP LOAD KISMI 
        private void ucKalıpGor_Load_1(object sender, EventArgs e)
        {
            Listele();
            this.wAREHOUSETableAdapter.Fill(this.alfaPlastikDataSet.WAREHOUSE);
            btn_duzen_kyt.Visible = false;
            ToolTip tool = new ToolTip();
            tool.SetToolTip(btn_duzen_kyt, "Kaydet");
            tool.SetToolTip(btn_ekle, "KAYDET");
            tool.SetToolTip(button_Ekle, "EKLE");//MOUSE GELDİĞİNDE EKLE YAZAR.
            tool.SetToolTip(button_Sil, "SİL");//MOUSE GELDİĞİNDE SİL YAZAR.
            tool.SetToolTip(button_Duzenle, "DÜZENLE");//MOUSE GELDİĞİNDE DÜZENLE YAZAR.
            tool.SetToolTip(button_İncele, "İNCELE");
        }
        #endregion

        #region LİSTELEME METODU
        public void Listele()
        {

            dataGridView1.DataSource = dal.GetAll();//MOLD TABLOSUNU LİSTELER

            dataGridView1.Columns["MOLD_ID"].Visible = false;
            dataGridView1.Columns["Warehouse_ID"].Visible=false;
            dataGridView1.Columns["MOLD_INSERTDATE"].Visible = false;
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
        

        #region KALLIP Ekleme için temizleme Butonu
        private void button_Ekle_Click(object sender, EventArgs e)
        {
            btn_ekle.Visible = true;
            textBox_Name.Enabled = true;
            textBox_Name.Clear();
            textBox_No.Enabled = true;
            textBox_No.Clear();
            CMB_AMBAR.Text = null;
            CMB_AMBAR.Enabled = true;
            btn_duzen_kyt.Visible = false;
            label4.Text = "KALIP EKLEME";

        }
        #endregion

        #region KALIP Düzenleme Kayıt Çekme Butonu
        private void button_Duzenle_Click(object sender, EventArgs e)
        {
            btn_ekle.Visible = false;
            textBox_No.Enabled = true;
            textBox_Name.Enabled = true;
           
            CMB_AMBAR.Enabled = true;
            DataGridViewRow row = dataGridView1.CurrentRow;
            //KalıpDuzenle kd = new KalıpDuzenle();
            textBox_Name.Tag = row.Cells["MOLD_ID"].Value;
            textBox_No.Text = this.dataGridView1.CurrentRow.Cells["KALIP_Numarası"].Value.ToString();
            textBox_Name.Text = this.dataGridView1.CurrentRow.Cells["KALIP_Adı"].Value.ToString();
          
            CMB_AMBAR.Text = dataGridView1.CurrentRow.Cells["Kalıp_Yeri"].Value.ToString();
            btn_duzen_kyt.Visible = true;
            label4.Text = "KALIP DÜZENLEME";
            //kd.ShowDialog();
        }
        #endregion

        #region SATIRA ÇİFT TIK İLE DÜZENLEME
        private void dataGridView1_CellMouseDoubleClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            btn_ekle.Visible = false;
            textBox_No.Enabled = true;
            textBox_Name.Enabled = true;
          
            btn_duzen_kyt.Visible = true;
            CMB_AMBAR.Enabled = true;
            label4.Text = "KALIP DÜZENLEME";
            DataGridViewRow row = dataGridView1.CurrentRow;
            // KalıpDuzenle kd = new KalıpDuzenle();
            textBox_Name.Tag = row.Cells["MOLD_ID"].Value;
            textBox_No.Text = this.dataGridView1.CurrentRow.Cells["KALIP_Numarası"].Value.ToString();
            textBox_Name.Text = this.dataGridView1.CurrentRow.Cells["KALIP_Adı"].Value.ToString();
           
            CMB_AMBAR.Text=dataGridView1.CurrentRow.Cells["Kalıp_Yeri"].Value.ToString();
            //  kd.ShowDialog();
        }

        #endregion

        #region İnceleme Butonu
        public void Examine()
        {
            btn_ekle.Visible = false;
            btn_duzen_kyt.Visible = false;
            DataGridViewRow row = dataGridView1.CurrentRow;
            textBox_Name.Tag = row.Cells["MOLD_ID"].Value;
            textBox_No.Text = this.dataGridView1.CurrentRow.Cells["KALIP_Numarası"].Value.ToString();
            textBox_No.Enabled = false;
            textBox_Name.Text = this.dataGridView1.CurrentRow.Cells["KALIP_Adı"].Value.ToString();
            textBox_Name.Enabled = false;
          
            CMB_AMBAR.Text = dataGridView1.CurrentRow.Cells["Kalıp_Yeri"].Value.ToString();
            CMB_AMBAR.Enabled = false;
            
            label4.Text = "KALIP İNCELEME";
        }
        private void button_İncele_Click(object sender, EventArgs e)
        {

            Examine();
        }
        #endregion

        #region Düzeneleme İşlemi
        public void Updatee()
        {
            //try
            //{
            //    var mevcut = context.MOLDs.Where(x => x.MOLD_ID == (int)textBox_Name.Tag).FirstOrDefault();
            if (!string.IsNullOrEmpty(textBox_Name.Text) && !string.IsNullOrEmpty(textBox_No.Text))
            {
                m.MOLD_ID = Convert.ToInt32(dataGridView1.CurrentRow.Cells["MOLD_ID"].Value);
               
                m.MOLD_NAME = textBox_Name.Text;
                m.MOLD_NO = Convert.ToInt32(textBox_No.Text);
                m.Warehouse_ID = (int)CMB_AMBAR.SelectedValue;
                dal.Update(m);
                Listele();
                textBox_Name.Clear();
                textBox_No.Clear();
                CMB_AMBAR.Text = null;
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
        private void btn_duzen_kyt_Click(object sender, EventArgs e)
        {
            Updatee();
        }
        #endregion

        #region EKLEME İŞLEMİ
        public void İnsert()
        {

            if (!string.IsNullOrEmpty(textBox_Name.Text) && !string.IsNullOrEmpty(textBox_No.Text))
            {

                m.MOLD_INSERTDATE = DateTime.Now;
                m.MOLD_NAME = textBox_Name.Text;
                m.MOLD_NO = Convert.ToInt32(textBox_No.Text);
                m.Warehouse_ID = (int)CMB_AMBAR.SelectedValue;
                dal.Add(m);
                Listele();
                CMB_AMBAR.Text = null;
                textBox_Name.Clear();
                textBox_No.Clear();
            }
        }
        private void btn_ekle_Click(object sender, EventArgs e)
        {
            İnsert();
        }


        #endregion

        #region KALIP Silme İşlemi
        public void Delete()
        {
            if (MessageBox.Show("Bu satırı sil !!!", "KALIP SİL!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                if (dataGridView1.CurrentRow != null)
                {
                    m.MOLD_ID = Convert.ToInt32(dataGridView1.CurrentRow.Cells["MOLD_ID"].Value);
                    dal.Delete(m);

                    Listele();

                }
            }
        }
        private void button_Sil_Click(object sender, EventArgs e)
        {
            Delete();
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

        private void CMB_AMBAR_KeyPress(object sender, KeyPressEventArgs e)
        {
            ns.IntOrStringNo(e);
        }
    }
}


