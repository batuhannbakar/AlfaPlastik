using System;
using System.Drawing;
using System.Windows.Forms;
using Alfa.BusinessLayer;
using System.Data.Entity;
using Alfa.DataAccessLayer.EntityFramework;
using System.Collections.Generic;
using System.Linq;
using Alfa.Entities.Models;

namespace Alfa.OPERATION
{
    public partial class ucOperasyonGor : UserControl
    {
        ManagerOPERATION managerOPERATION = new ManagerOPERATION();
        OperationDal dal = new OperationDal();
        Entities.Models.OPERATION o = new Entities.Models.OPERATION();
        Block ns = new Block();
        public ucOperasyonGor()
        {
            InitializeComponent();
            
        }

        #region OPERASYON LOAD KISMI
        private void ucOperasyonGor_Load(object sender, EventArgs e)
        {
            Listele();
            ToolTip tool = new ToolTip();
            tool.SetToolTip(btn_duzen_kyt, "Kaydet");
            tool.SetToolTip(btn_ekle, "KAYDET");
            tool.SetToolTip(button_Ekle, "EKLE");//MOUSE GELDİĞİNDE EKLE YAZAR.
            tool.SetToolTip(button_Sil, "SİL");//MOUSE GELDİĞİNDE SİL YAZAR.
            tool.SetToolTip(button_Duzenle, "DÜZENLE");//MOUSE GELDİĞİNDE DÜZENLE YAZAR.
            tool.SetToolTip(buton_incele, "İNCELE");
        }
        #endregion
 
        #region LİSTELEME METODU
        public void Listele()
        {
            dataGridView1.DataSource = dal.GetAll();//OPERATION TABLOSUNU LİSTELER.
            
            dataGridView1.Columns["OPERATION_ID"].Visible = false;
            dataGridView1.Columns["Operasyon_Tarihi"].Visible = false;
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
        
        #region OPERASYON Ekleme için temizleme butonu
        private void button1_Click(object sender, EventArgs e)
        {
            btn_ekle.Visible = true;
            textBox_Name.Enabled = true;
            textBox_Name.Clear();
            textBox_No.Enabled = true;
            textBox_No.Clear();
           
            btn_duzen_kyt.Visible = false;
            label4.Text = "OPERASYON EKLEME";

        }
        #endregion

        #region Düzenleme Kayıt Çekme Butonu 
        private void button_Duzenle_Click(object sender, EventArgs e)
        {
            btn_ekle.Visible = false;
            textBox_Name.Enabled = true;
            textBox_No.Enabled = true;
         
            DataGridViewRow row = dataGridView1.CurrentRow;
            //OperasyonDuzenle od = new OperasyonDuzenle();
            textBox_Name.Tag = row.Cells["OPERATION_ID"].Value;
            textBox_No.Text = this.dataGridView1.CurrentRow.Cells["Operasyon_Numarası"].Value.ToString();
            textBox_Name.Text = this.dataGridView1.CurrentRow.Cells["Operasyon_İsmi"].Value.ToString();
           
            btn_duzen_kyt.Visible = true;
            label4.Text = "OPERASYON DÜZENLEME";
            //od.ShowDialog();
        }
        #endregion

        #region SATIRA ÇİFT TIK İLE DÜZENLEME
        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            btn_ekle.Visible = false;
            textBox_Name.Enabled = true;
            textBox_No.Enabled = true;
          
            btn_duzen_kyt.Visible = true;
            label4.Text = "OPERASYON DÜZENLEME";
            DataGridViewRow row = dataGridView1.CurrentRow;
            //   OperasyonDuzenle od = new OperasyonDuzenle();
            textBox_Name.Tag = row.Cells["OPERATION_ID"].Value;
            textBox_No.Text = this.dataGridView1.CurrentRow.Cells["Operasyon_Numarası"].Value.ToString();
            textBox_Name.Text = this.dataGridView1.CurrentRow.Cells["Operasyon_İsmi"].Value.ToString();
            

            //  od.ShowDialog();
        }
        #endregion

        #region İNCELE BUTONU
        private void buton_incele_Click(object sender, EventArgs e)
        {
            btn_ekle.Visible = false;
            btn_duzen_kyt.Visible = false;
            DataGridViewRow row = dataGridView1.CurrentRow;
          
            textBox_Name.Tag = row.Cells["OPERATION_ID"].Value;
            textBox_No.Text = this.dataGridView1.CurrentRow.Cells["Operasyon_Numarası"].Value.ToString();
            textBox_No.Enabled = false;
            textBox_Name.Text = this.dataGridView1.CurrentRow.Cells["Operasyon_İsmi"].Value.ToString();
            textBox_Name.Enabled = false;
           
            label4.Text = "OPERASYON İNCELEME";
           
        }
        #endregion

        #region EKLEME İŞLEMİ
        private void btn_ekle_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox_Name.Text) && !string.IsNullOrEmpty(textBox_No.Text))
            {


                o.OPERATION_INSERTDATE = DateTime.Now;
                o.OPERATION_NAME = textBox_Name.Text;
                o.OPERATION_NO = Convert.ToInt32(textBox_No.Text);
                dal.Add(o);
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

        #region DÜZENLEME İŞLEMİ
        private void btn_duzen_kyt_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    var mevcut = context.OPERATIONs.Where(x => x.OPERATION_ID == (int)textBox_Name.Tag).FirstOrDefault();
                if (!string.IsNullOrEmpty(textBox_Name.Text) && !string.IsNullOrEmpty(textBox_No.Text))
                {
                    o.OPERATION_ID= Convert.ToInt32(dataGridView1.CurrentRow.Cells["OPERATION_ID"].Value);
                    
                    o.OPERATION_NAME = textBox_Name.Text;
                    o.OPERATION_NO = Convert.ToInt32(textBox_No.Text);
                 dal.Update(o);
               
               
                    Listele();
                    textBox_Name.Clear();
                    textBox_No.Clear();
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

        #region  SİLME İŞLEMİ
        private void button_Sil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bu satırı sil !!!", "OPERASYON SİL!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (dataGridView1.CurrentRow != null)
                {
                    o.OPERATION_ID = Convert.ToInt32(dataGridView1.CurrentRow.Cells["OPERATION_ID"].Value);
                    dal.Delete(o);
                       
                        Listele();
                   
                }
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

