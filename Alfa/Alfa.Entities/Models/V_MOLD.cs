using System;
using System.Collections.Generic;

namespace Alfa.Entities.Models
{
    public partial class V_MOLD
    {
        public int MOLD_ID { get; set; }
        public int KALIP_Numarası { get; set; }
        public string KALIP_Adı { get; set; }
        public System.DateTime MOLD_INSERTDATE { get; set; }
        public Nullable<int> Warehouse_ID { get; set; }
        public string Kalıp_Yeri { get; set; }
    }
}
