using System;
using System.Collections.Generic;

namespace Alfa.Entities.Models
{
    public partial class V_MAINTAINTYPE
    {
        public int MAINTAINTYPE_ID { get; set; }
        public System.DateTime Bakım_Tipi_Tarihi { get; set; }
        public int Bakım_Tipi_Numarası { get; set; }
        public string Bakım_Tipi_İsmi { get; set; }
    }
}
