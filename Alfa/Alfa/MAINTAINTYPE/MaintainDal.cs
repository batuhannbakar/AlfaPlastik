using Alfa.DataAccessLayer.EntityFramework;
using Alfa.Entities.Models;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Data.Entity;

namespace Alfa.MAINTAINTYPE
{
    public class MaintainDal
    {

        public List<V_MAINTAINTYPE> GetAll()
        {
            using (AlfaPlastikContext cnt = new AlfaPlastikContext())
            {
                return cnt.V_MAINTAINTYPE.ToList();
            }

        }

        public void Add(Entities.Models.MAINTAINTYPE maintain)
        {
            using (AlfaPlastikContext cnt = new AlfaPlastikContext())
            {
                var sonuc = cnt.MAINTAINTYPEs.Any(x => x.MAINTAINTYPE_NAME == maintain.MAINTAINTYPE_NAME);
                var sonuc2 = cnt.MAINTAINTYPEs.Any(x => x.MAINTAINTYPE_NO == maintain.MAINTAINTYPE_NO);
                if (sonuc == true)
                {
                    MessageBox.Show("Aynı isim girilemez.");
                }
                else
                {
                    if (sonuc2 == true)
                    {
                        MessageBox.Show("Aynı numara girilemez.");
                    }
                    else
                    {
                        var entity = cnt.Entry(maintain);
                        entity.State = EntityState.Added;
                        cnt.SaveChanges();
                        MessageBox.Show("Kayıt Eklendi..");
                    }

                }
            }

        }

        public void Update(Entities.Models.MAINTAINTYPE maintain)
        {
            using (AlfaPlastikContext cnt = new AlfaPlastikContext())
            {
                try
                {
                    var entity = cnt.Entry(maintain);
                    entity.State = EntityState.Modified;
                    cnt.SaveChanges();
                    MessageBox.Show("Kayıt Güncellendi");

                }
                catch (System.Exception)
                {

                    MessageBox.Show("Aynı değere girilemez..");
                }

            }

        }


        public void Delete(Entities.Models.MAINTAINTYPE maintain)
        {
            using (AlfaPlastikContext cnt = new AlfaPlastikContext())
            {
                var entity = cnt.Entry(maintain);
                entity.State = EntityState.Deleted;
                cnt.SaveChanges();
            }
        }
    }
}


    


