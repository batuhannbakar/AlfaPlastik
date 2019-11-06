using System;
using System.Collections.Generic;

namespace Alfa.Entities.Models
{
    public partial class WL_PROCESS
    {
        public int PROCESS_ID { get; set; }
        public int WRKID { get; set; }
        public string PROCESS_NOTE { get; set; }
        public Nullable<int> OPE1_ID { get; set; }
        public Nullable<System.DateTime> OPE1_DATE { get; set; }
        public Nullable<int> OPE2_ID { get; set; }
        public Nullable<System.DateTime> OPE2_DATE { get; set; }
        public Nullable<int> OPE3_ID { get; set; }
        public Nullable<System.DateTime> OPE3_DATE { get; set; }
        public Nullable<int> OPE4_ID { get; set; }
        public Nullable<System.DateTime> OPE4_DATE { get; set; }
        public Nullable<int> OPE5_ID { get; set; }
        public Nullable<System.DateTime> OPE5_DATE { get; set; }
        public Nullable<int> OPE6_ID { get; set; }
        public Nullable<System.DateTime> OPE6_DATE { get; set; }
        public Nullable<int> OPE7_ID { get; set; }
        public Nullable<System.DateTime> OPE7_DATE { get; set; }
        public Nullable<int> OPE8_ID { get; set; }
        public Nullable<System.DateTime> OPE8_DATE { get; set; }
        public virtual OPERATION OPERATION { get; set; }
        public virtual OPERATION OPERATION1 { get; set; }
        public virtual OPERATION OPERATION2 { get; set; }
        public virtual OPERATION OPERATION3 { get; set; }
        public virtual OPERATION OPERATION4 { get; set; }
        public virtual OPERATION OPERATION5 { get; set; }
        public virtual OPERATION OPERATION6 { get; set; }
        public virtual OPERATION OPERATION7 { get; set; }
        public virtual WRKORD WRKORD { get; set; }
    }
}
