using System;
using System.Collections.Generic;

namespace Alfa.Entities.Models
{
    public partial class WAREHOUSE
    {
        public WAREHOUSE()
        {
            this.MOLDs = new List<MOLD>();
        }

        public int WAREHOUSE_ID { get; set; }
        public System.DateTime WAREHOUSE_INSERTDATE { get; set; }
        public int WAREHOUSE_NO { get; set; }
        public string WAREHOUSE_NAME { get; set; }
        public virtual ICollection<MOLD> MOLDs { get; set; }
    }
}
