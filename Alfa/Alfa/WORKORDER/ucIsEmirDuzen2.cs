using System;
using System.Windows.Forms;
using Alfa.BusinessLayer;
using Alfa.Entities.Models;

namespace Alfa.WORKORDER
{
    public partial class ucIsEmirDuzen2 : UserControl
    {
        ManagerV_WRKORD_GRID managerV_WRKORD_GRID = new ManagerV_WRKORD_GRID();

        ManagerWL_PLAN managerWL_PLAN = new ManagerWL_PLAN();
        ManagerOPERATION managerOPERATION = new ManagerOPERATION();
        ManagerUser managerUser = new ManagerUser();
        Block ns = new Block();
        UcEmirGor uc = new UcEmirGor();
    

        public ucIsEmirDuzen2()
        {
            InitializeComponent();
        }

        private void ucIsEmirDuzen2_Load(object sender, EventArgs e)
        {
            this.oPERATIONTableAdapter.Fill(this.alfaPlastikDataSet.OPERATION);

            //V_WRKORD_GRID wrk = managerV_WRKORD_GRID.Find(x=>x.WRKORD_ID==(int)richTextBoxYapılacaklarNot.Tag);


        }


        private void comboBox_BakımPersonel_MouseClick(object sender, MouseEventArgs e)
        {
            comboBox_BakımPersonel.DataSource = managerUser.List();
            comboBox_BakımPersonel.DisplayMember = "NAME";
            comboBox_BakımPersonel.ValueMember = "USERS_ID";
        }

        private void comboBox_BakımPersonel_KeyPress(object sender, KeyPressEventArgs e)
        {
            ns.IntOrStringNo(e);
        }

        private void textBox_saat_KeyPress(object sender, KeyPressEventArgs e)
        {
            ns.StringNo(e);
        }
    }
}
