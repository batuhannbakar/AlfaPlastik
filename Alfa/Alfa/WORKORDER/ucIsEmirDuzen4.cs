using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Alfa.BusinessLayer;

namespace Alfa.WORKORDER
{
    public partial class ucIsEmirDuzen4 : UserControl
    {
        ManagerWL_PLAN managerWL_PLAN = new ManagerWL_PLAN();
        ManagerOPERATION managerOPERATION = new ManagerOPERATION();
        ManagerUser managerUser = new ManagerUser();
        Block ns = new Block();
        //private static ucIsEmirDuzen4 _instance;
        //public static ucIsEmirDuzen4 Instance
        //{
        //    get
        //    {
        //        if (_instance == null)
        //            _instance = new ucIsEmirDuzen4();
        //        return _instance;
        //    }
        //}
        public ucIsEmirDuzen4()
        {
            InitializeComponent();
        }

        private void button_GERİ_Click(object sender, EventArgs e)
        {

            if (!IsEmriDuzenle.Instance.panel2.Controls.ContainsKey("ucIsEmirDuzen3"))
            {
                ucIsEmirDuzen3 emir3 = new ucIsEmirDuzen3();
                emir3.Dock = DockStyle.Fill;
                IsEmriDuzenle.Instance.panel2.Controls.Add(emir3);
               
               // IsEmriDuzenle.Instance.ProcessDuzen();
            }
            IsEmriDuzenle.Instance.panel2.Controls["ucIsEmirDuzen3"].BringToFront();

        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            ns.IntOrStringNo(e);
        }
    }
    }

