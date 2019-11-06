using System;
using System.Collections.Generic;

namespace Alfa.Entities.Models
{
    public partial class V_WAREHOUSE
    {
        public int WAREHOUSE_ID { get; set; }
        public System.DateTime Ambar_Tarihi { get; set; }
        public int Ambar_Numarası { get; set; }
        public string Ambar_İsmi { get; set; }
    }
}
