using System;
using System.Collections.Generic;

namespace Alfa.Entities.Models
{
    public partial class AUTHOR
    {
        public AUTHOR()
        {
            this.USERS = new List<USER>();
        }

        public int AUTHORS_ID { get; set; }
        public int AUTHORS_NO { get; set; }
        public string AUTHORS_NAME { get; set; }
        public virtual ICollection<USER> USERS { get; set; }
    }
}
