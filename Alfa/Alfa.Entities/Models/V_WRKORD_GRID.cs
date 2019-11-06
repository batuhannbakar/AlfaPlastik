using System;
using System.Collections.Generic;

namespace Alfa.Entities.Models
{
    public partial class V_WRKORD_GRID
    {
        public int İş_Emri_No { get; set; }
        public System.DateTime İş_Emri_Tarihi { get; set; }
        public Nullable<System.DateTime> Değiştirme_Tarihi { get; set; }
        public string Değiştiren_Kişi { get; set; }
        public string Bakım_Tipi { get; set; }
        public string Statü { get; set; }
        public int USERS_ID { get; set; }
        public string Talep_Eden { get; set; }
        public string KULLANICI { get; set; }
        public string Kalıp_Yeri { get; set; }
        public string Kalıp_Adı { get; set; }
        public Nullable<int> Kalıp_No { get; set; }
        public string PRIORITY { get; set; }
        public string Bakım_Personeli { get; set; }
        public Nullable<System.DateTime> PLANNED_START_DATE { get; set; }
        public Nullable<int> REQUEST_BY { get; set; }
        public Nullable<System.DateTime> REQUEST_DATE { get; set; }
        public string WRK_NOTE { get; set; }
        public Nullable<System.DateTime> ESTIMATED_START_DATE { get; set; }
        public Nullable<int> MAINTAIN_PERSON { get; set; }
        public Nullable<int> PLANNED_TİME { get; set; }
        public string TO_DO_NOTE { get; set; }
        public string PROCESS_NOTE { get; set; }
        public Nullable<System.DateTime> COMPLETION_DATE { get; set; }
        public Nullable<System.TimeSpan> COMPLETION_TİME { get; set; }
        public string DELIVERY_NOTE { get; set; }
        public string DELIVERY_TYPE { get; set; }
        public string OPE1 { get; set; }
        public Nullable<System.DateTime> OPE1_DATE { get; set; }
        public string OPE2 { get; set; }
        public Nullable<System.DateTime> OPE2_DATE { get; set; }
        public string OPE3 { get; set; }
        public Nullable<System.DateTime> OPE3_DATE { get; set; }
        public string OPE4 { get; set; }
        public Nullable<System.DateTime> OPE4_DATE { get; set; }
        public string OPE5 { get; set; }
        public Nullable<System.DateTime> OPE5_DATE { get; set; }
        public string OPE6 { get; set; }
        public Nullable<System.DateTime> OPE6_DATE { get; set; }
        public string OPE7 { get; set; }
        public Nullable<System.DateTime> OPE7_DATE { get; set; }
        public string OPE8 { get; set; }
        public Nullable<System.DateTime> OPE8_DATE { get; set; }
        public int WRKORD_ID { get; set; }
    }
}
