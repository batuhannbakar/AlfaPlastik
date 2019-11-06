using System;
using System.Collections.Generic;

namespace Alfa.Entities.Models
{
    public partial class V_TRACKING_GRID
    {
        public int TRACKING_ID { get; set; }
        public Nullable<int> WRKID { get; set; }
        public string TRACKING_NOTE { get; set; }
        public string TRACKING_STATUS { get; set; }
        public Nullable<System.DateTime> TRACKING_INSERTDATE { get; set; }
        public int CREATER_ID { get; set; }
        public Nullable<int> Mold_ID { get; set; }
        public Nullable<System.DateTime> MODIFY_DATE { get; set; }
        public Nullable<int> MODIFIER_ID { get; set; }
    }
}
