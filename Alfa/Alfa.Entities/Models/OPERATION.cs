using System;
using System.Collections.Generic;

namespace Alfa.Entities.Models
{
    public partial class OPERATION
    {
        public OPERATION()
        {
            this.WL_PROCESS = new List<WL_PROCESS>();
            this.WL_PROCESS1 = new List<WL_PROCESS>();
            this.WL_PROCESS2 = new List<WL_PROCESS>();
            this.WL_PROCESS3 = new List<WL_PROCESS>();
            this.WL_PROCESS4 = new List<WL_PROCESS>();
            this.WL_PROCESS5 = new List<WL_PROCESS>();
            this.WL_PROCESS6 = new List<WL_PROCESS>();
            this.WL_PROCESS7 = new List<WL_PROCESS>();
        }

        public int OPERATION_ID { get; set; }
        public System.DateTime OPERATION_INSERTDATE { get; set; }
        public int OPERATION_NO { get; set; }
        public string OPERATION_NAME { get; set; }
        public virtual ICollection<WL_PROCESS> WL_PROCESS { get; set; }
        public virtual ICollection<WL_PROCESS> WL_PROCESS1 { get; set; }
        public virtual ICollection<WL_PROCESS> WL_PROCESS2 { get; set; }
        public virtual ICollection<WL_PROCESS> WL_PROCESS3 { get; set; }
        public virtual ICollection<WL_PROCESS> WL_PROCESS4 { get; set; }
        public virtual ICollection<WL_PROCESS> WL_PROCESS5 { get; set; }
        public virtual ICollection<WL_PROCESS> WL_PROCESS6 { get; set; }
        public virtual ICollection<WL_PROCESS> WL_PROCESS7 { get; set; }
    }
}
