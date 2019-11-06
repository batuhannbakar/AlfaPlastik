using System;
using System.Collections.Generic;

namespace Alfa.Entities.Models
{
    public partial class WL_PLAN
    {
        public int PLAN_ID { get; set; }
        public int WRKID { get; set; }
        public Nullable<int> MAINTAIN_PERSON { get; set; }
        public Nullable<System.DateTime> ESTIMATED_START_DATE { get; set; }
        public Nullable<int> PLANNED_TİME { get; set; }
        public string MAINTAIN_PERSON_NAME { get; set; }
        public string TO_DO_NOTE { get; set; }
        public virtual WRKORD WRKORD { get; set; }
    }
}
