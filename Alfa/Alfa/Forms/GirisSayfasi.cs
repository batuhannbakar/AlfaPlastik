using System;
using System.Windows.Forms;
using Alfa.BusinessLayer;
using Alfa.Entities.Models;
using Alfa.Forms;

namespace Alfa.Forms
{
    public partial class GirisSayfasi : Form
    {
        ManagerUser managerUser = new ManagerUser();
        public GirisSayfasi()
        {
            InitializeComponent();
        }

        public static USER aktif = null;
        #region GİRİŞ BUTONU
        private void button_Giris_Click(object sender, EventArgs e)
        {
            this.Visible = false;

            if (kullanicidogrula(isim.Text,sifre.Text)!=null)
            {
                AnaSayfa ana = new AnaSayfa();
                ana.ShowDialog();
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı ya da şifre Yanlış!");
                GirisSayfasi giris = new GirisSayfasi();
                giris.ShowDialog();
            }
            if (Application.MessageLoop)
            {
                Application.Exit();
            }
            else Environment.Exit(1);
        }
        #endregion

        #region KULLANICI DOĞRULAMA KISMI
        private USER kullanicidogrula(string kisim, string ksifre)
        {
            aktif = managerUser.Find(x => x.NAME == kisim && x.PASSWORD == ksifre);
            return aktif;
        }
        #endregion

        #region GİRİŞSAYFASI LOAD KISMI
        private void GirisSayfasi_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
        }
        #endregion

        #region ESC İLE ÇIKMA
        private void GirisSayfasi_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
        #endregion

        private void sifre_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button_Giris_Click(this, new EventArgs());
            }
        }
    }

}
