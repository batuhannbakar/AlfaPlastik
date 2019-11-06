using System;
using System.Collections.Generic;

namespace Alfa.Entities.Models
{
    public partial class MAINTAINTYPE
    {
        public MAINTAINTYPE()
        {
            this.WRKORDs = new List<WRKORD>();
        }

        public int MAINTAINTYPE_ID { get; set; }
        public System.DateTime MAINTAINTYPE_INSERTDATE { get; set; }
        public int MAINTAINTYPE_NO { get; set; }
        public string MAINTAINTYPE_NAME { get; set; }
        public virtual ICollection<WRKORD> WRKORDs { get; set; }
    }
}
