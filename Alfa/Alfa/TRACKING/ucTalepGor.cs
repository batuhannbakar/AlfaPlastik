using System;
using System.Windows.Forms;
using Alfa.BusinessLayer;

namespace Alfa.TRACKING
{
    public partial class ucTalepGor : UserControl
    { ManagerV_TRACKING_GRID managerV_TRACKING_GRID = new ManagerV_TRACKING_GRID();
        public static ucTalepGor _instance;
        public static ucTalepGor Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucTalepGor();
                return _instance;
            }
        }

        public ucTalepGor()
        {
            InitializeComponent();
        }

        #region TALEP LOAD KISMI
        private void ucTalepGor_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = managerV_TRACKING_GRID.List();
        }
        #endregion
    }
}
