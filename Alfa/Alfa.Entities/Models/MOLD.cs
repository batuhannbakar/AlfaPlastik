using System;
using System.Collections.Generic;

namespace Alfa.Entities.Models
{
    public partial class MOLD
    {
        public MOLD()
        {
            this.TRACKINGs = new List<TRACKING>();
            this.WRKORDs = new List<WRKORD>();
        }

        public int MOLD_ID { get; set; }
        public System.DateTime MOLD_INSERTDATE { get; set; }
        public int MOLD_NO { get; set; }
        public string MOLD_NAME { get; set; }
        public int Warehouse_ID { get; set; }
        public virtual WAREHOUSE WAREHOUSE { get; set; }
        public virtual ICollection<TRACKING> TRACKINGs { get; set; }
        public virtual ICollection<WRKORD> WRKORDs { get; set; }
    }
}
