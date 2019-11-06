
using System.Windows.Forms;
using Alfa.BusinessLayer;

namespace Alfa.WORKORDER
{
    public partial class ucIsEmirDuzen3 : UserControl
    {
        ManagerWL_PLAN managerWL_PLAN = new ManagerWL_PLAN();
        ManagerOPERATION managerOPERATION = new ManagerOPERATION();
        ManagerUser managerUser = new ManagerUser();
        
        public ucIsEmirDuzen3()
        {
            InitializeComponent();
        } 
       
    }
}
