using System;
using System.Collections.Generic;

namespace Alfa.Entities.Models
{
    public partial class USER
    {
        public USER()
        {
            this.TRACKINGs = new List<TRACKING>();
            this.WRKORDs = new List<WRKORD>();
            this.WRKORDs1 = new List<WRKORD>();
        }

        public int USERS_ID { get; set; }
        public string NAME { get; set; }
        public string PASSWORD { get; set; }
        public virtual ICollection<TRACKING> TRACKINGs { get; set; }
        public virtual ICollection<WRKORD> WRKORDs { get; set; }
        public virtual ICollection<WRKORD> WRKORDs1 { get; set; }
    }
}
