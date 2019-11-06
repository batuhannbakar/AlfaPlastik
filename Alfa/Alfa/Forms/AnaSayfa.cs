using System;
using System.Windows.Forms;
using Alfa.OPERATION;
using Alfa.MOLD;
using Alfa.WORKORDER;
using Alfa.WAREHOUSE;
using Alfa.MAINTAINTYPE;
using Alfa.TRACKING;
using Alfa.BusinessLayer;
using Alfa.DataAccessLayer.EntityFramework;
using Alfa.Entities.Models;

namespace Alfa.Forms
{
    public partial class AnaSayfa : Form
    {
        AlfaPlastikContext context = new AlfaPlastikContext();
       

        public AnaSayfa()
        {
            InitializeComponent();
            ucgiris1.BringToFront();
        }

        #region ANASAYFA LOAD KISMI
        private void AnaSayfa_Load(object sender, EventArgs e)
        {
            lblKullanici.Text = GirisSayfasi.aktif.NAME;//giriş yapan kullanıcıyı ıd'sinden adını labele çekme.
            lblTarih.Text = DateTime.Now.ToString();//labele anlık tarihi çekme.
           
           WindowState = FormWindowState.Maximized;//formu tam ekranda açma.
            this.KeyPreview = true;//esc'yi etkinleştirme.
        }
        #endregion
     
        

    
        #region İŞEMRİNE GİTME BUTONU
        private void işEmirleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
            ucEmirGor1.Listele();
            ucEmirGor1.BringToFront();
        }
        #endregion

        
        #region AMBARLAR(WAREHOUSE) TABLOSUNU GÖRÜNTÜLME KISMI
        private void ambarlarToolStripMenuItem_Click(object sender, EventArgs e)
        {

            ucAmbarGor1.Listele();
            ucAmbarGor1.btn_duzen_kyt.Visible = false;
            ucAmbarGor1.textBox_Name.Clear();
            ucAmbarGor1.textBox_No.Clear();
            ucAmbarGor1.textBox_Name.Enabled = true;
            ucAmbarGor1.textBox_No.Enabled = true;
            ucAmbarGor1.button_EKLE.Visible = true;
            
            ucAmbarGor1.label4.Text = "AMBAR EKLEME";
            ucAmbarGor1.BringToFront();
        }
        #endregion

        #region KALIPLAR(MOLD) TABLOSUNU GÖRÜNTÜLEME KISMI
        private void kalıplarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            ucKalıpGor1.btn_duzen_kyt.Visible = false;
            ucKalıpGor1.textBox_No.Clear();
            ucKalıpGor1.textBox_Name.Clear();
            ucKalıpGor1.textBox_Name.Enabled = true;
            ucKalıpGor1.textBox_No.Enabled = true;
            ucKalıpGor1.btn_ekle.Visible = true;
            
            ucKalıpGor1.label4.Text = "KALIP EKLEME";
            ucKalıpGor1.Listele();
            ucKalıpGor1.BringToFront();
           
        }
        #endregion
       
        #region OPERASYONLAR(OPERATION) TABLOSUNU GÖRÜNTÜLEME KISMI
        private void operasyonlarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            ucOperasyonGor1.btn_duzen_kyt.Visible = false;
            ucOperasyonGor1.textBox_Name.Clear();
            ucOperasyonGor1.textBox_No.Clear();
            ucOperasyonGor1.textBox_Name.Enabled = true;
            ucOperasyonGor1.textBox_No.Enabled = true;
            ucOperasyonGor1.btn_ekle.Visible = true;
          
            ucOperasyonGor1.label4.Text = "OPERASYON EKLEME";
            ucOperasyonGor1.BringToFront();
        }
        #endregion

        #region BAKIMTİPİ(MAİNTAİNTYPE) TABLOSUNU GÖRÜNTÜLEME KISMI
        private void bakımTipiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            ucBakimTipiGor1.btn_duzen_kyt.Visible = false;
            ucBakimTipiGor1.textBox_Name.Clear();
            ucBakimTipiGor1.textBox_No.Clear();
            ucBakimTipiGor1.textBox_Name.Enabled = true;
            ucBakimTipiGor1.textBox_No.Enabled = true;
            ucBakimTipiGor1.btn_ekle.Visible = true;
           
            ucBakimTipiGor1.label4.Text = "BAKIM TİPİ EKLEME";
            ucBakimTipiGor1.BringToFront();
        }
        #endregion

        #region ESC İLE SAYFAYI KAPATMA
        private void AnaSayfa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
        #endregion

        #region TAKİP KISMINA GİTME BUTONU
        private void takipToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!panel1.Controls.Contains(ucTalepGor.Instance))
            {
                panel1.Controls.Add(ucTalepGor.Instance);
                ucTalepGor.Instance.Dock = DockStyle.Fill;
                ucTalepGor.Instance.BringToFront();
            }
            else
                ucTalepGor.Instance.BringToFront();
        }
        #endregion

        
    }
}
