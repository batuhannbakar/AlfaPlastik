using System;
using System.Collections.Generic;

namespace Alfa.Entities.Models
{
    public partial class V_OPERATION
    {
        public int OPERATION_ID { get; set; }
        public System.DateTime Operasyon_Tarihi { get; set; }
        public int Operasyon_Numarası { get; set; }
        public string Operasyon_İsmi { get; set; }
    }
}
