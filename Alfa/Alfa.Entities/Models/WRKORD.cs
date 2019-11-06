using System;
using System.Collections.Generic;

namespace Alfa.Entities.Models
{
    public partial class WRKORD
    {
        public WRKORD()
        {
            this.TRACKINGs = new List<TRACKING>();
            this.WL_COMPLETE = new List<WL_COMPLETE>();
            this.WL_PLAN = new List<WL_PLAN>();
            this.WL_PROCESS = new List<WL_PROCESS>();
            this.WL_REQUEST = new List<WL_REQUEST>();
        }

        public int WRKORD_ID { get; set; }
        public int WRKORD_NO { get; set; }
        public System.DateTime WRKORD_INSERTDATE { get; set; }
        public int CREATER_ID { get; set; }
        public Nullable<int> Mold_ID { get; set; }
        public Nullable<System.DateTime> MODIFYDATE { get; set; }
        public Nullable<int> MODIFIER_ID { get; set; }
        public int Maintaintype_ID { get; set; }
        public string STATUS_ { get; set; }
        public virtual MAINTAINTYPE MAINTAINTYPE { get; set; }
        public virtual MOLD MOLD { get; set; }
        public virtual ICollection<TRACKING> TRACKINGs { get; set; }
        public virtual USER USER { get; set; }
        public virtual USER USER1 { get; set; }
        public virtual ICollection<WL_COMPLETE> WL_COMPLETE { get; set; }
        public virtual ICollection<WL_PLAN> WL_PLAN { get; set; }
        public virtual ICollection<WL_PROCESS> WL_PROCESS { get; set; }
        public virtual ICollection<WL_REQUEST> WL_REQUEST { get; set; }
    }
}
