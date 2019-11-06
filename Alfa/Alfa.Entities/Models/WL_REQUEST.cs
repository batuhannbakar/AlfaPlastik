using System;
using System.Collections.Generic;

namespace Alfa.Entities.Models
{
    public partial class WL_REQUEST
    {
        public int REQUEST_ID { get; set; }
        public int WRKID { get; set; }
        public string PRIORITY { get; set; }
        public Nullable<int> REQUEST_BY { get; set; }
        public Nullable<System.DateTime> REQUEST_DATE { get; set; }
        public Nullable<System.DateTime> PLANNED_START_DATE { get; set; }
        public string WRK_NOTE { get; set; }
        public string REQUEST_BY_NAME { get; set; }
        public virtual WRKORD WRKORD { get; set; }
    }
}
