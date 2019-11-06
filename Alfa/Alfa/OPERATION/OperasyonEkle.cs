using Alfa.BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alfa.OPERATION
{
    public partial class OperasyonEkle : Form
    {
        ManagerOPERATION managerOPERATION = new ManagerOPERATION();
        public OperasyonEkle()
        {
            InitializeComponent();
            timer1.Start();
        }
        #region OPERASYON EKLEME İŞLEMİ
        private void Button_Ekle_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox_Name.Text) && !string.IsNullOrEmpty(textBox_No.Text))
            {
                Alfa.Entities.Models.OPERATION o = new Entities.Models.OPERATION()
                {
                    OPERATION_INSERTDATE = DateTime.Now,
                    OPERATION_NAME = textBox_Name.Text,
                    OPERATION_NO = textBox_No.Text

                };
                int sonuc = managerOPERATION.Insert(o);
                if (sonuc > 0)
                {
                    MessageBox.Show("Kayıt Eklendi");
                    textBox_Name.Clear();
                    textBox_No.Clear();
                  //  ucOperasyonGor._instance.Listele();
                    
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

        #region OPERASYON EKLE LOAD KISMI
        private void OperasyonEkle_Load(object sender, EventArgs e)
        {
            #region TOOLTİP 
            ToolTip tool = new ToolTip();
            tool.SetToolTip(Button_Ekle, "EKLE");//MOUSE GELDİĞİNDE EKLE YAZAR.
            #endregion
            this.KeyPreview = true;
        }
        #endregion

        #region TİMER 
        private void timer1_Tick(object sender, EventArgs e)
        {   //ANLIK TARİHİ ALIR BELİRTİLEN FORMATTA TEXT OLARAK YAZAR.
            DateTime dateTime = DateTime.Now;
            this.textBox_Tarih.Text = dateTime.ToString("dd.MM.yyyy hh.mm.ss");
        }
        #endregion

        #region ESC İLE ÇIKMA
        private void OperasyonEkle_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
        #endregion
    }
}
