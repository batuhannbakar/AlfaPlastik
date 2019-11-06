using System;
using System.Collections.Generic;

namespace Alfa.Entities.Models
{
    public partial class V_SYS_GRID
    {
        public int AUTHORS_ID { get; set; }
        public int USERS_ID { get; set; }
        public string Kullanıcı_Adı { get; set; }
        public string Kullanıcı_Şifre { get; set; }
        public string Kullanıcı_Yetkisi { get; set; }
    }
}
