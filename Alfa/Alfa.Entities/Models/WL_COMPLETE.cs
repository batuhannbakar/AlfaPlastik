using System;
using System.Collections.Generic;

namespace Alfa.Entities.Models
{
    public partial class WL_COMPLETE
    {
        public int COMPLETE_ID { get; set; }
        public int WRKID { get; set; }
        public string DELIVERY_TYPE { get; set; }
        public Nullable<System.DateTime> COMPLETION_DATE { get; set; }
        public Nullable<System.TimeSpan> COMPLETION_TİME { get; set; }
        public string DELIVERY_NOTE { get; set; }
        public virtual WRKORD WRKORD { get; set; }
    }
}
