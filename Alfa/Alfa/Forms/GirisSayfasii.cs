using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AlfaPlastik
{
    public partial class GirisSayfasi : Form
    {
        public GirisSayfasi()
        {
            InitializeComponent();
        }

        public User user;
        private UserProvider islem;


        private void button_Giris_Click(object sender, EventArgs e)
        {
            islem = new UserProvider();
            user = islem.getUser(isim.Text, sifre.Text);

            if (user != null)
            {
                AnaSayfa ana = new AnaSayfa();
                ana.ShowDialog();
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı ya da şifre Yanlış!");
            }


            this.Hide();


            if (System.Windows.Forms.Application.MessageLoop)
            {
                // Use this since we are a WinForms app
                System.Windows.Forms.Application.Exit();
            }
            else
            {
                // Use this since we are a console app
                System.Environment.Exit(1);
            }

        }

        private void GirisSayfasi_Load(object sender, EventArgs e)
        {

        }
    }

}
