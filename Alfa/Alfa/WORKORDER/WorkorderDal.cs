using Alfa.DataAccessLayer.EntityFramework;
using Alfa.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;

using System.Windows.Forms;

namespace Alfa.WORKORDER
{
    class WorkorderDal
    {

        public List<V_WRKORD_GRID> GetAll()
        {
            using (AlfaPlastikContext context = new AlfaPlastikContext())
            {
                return context.V_WRKORD_GRID.OrderBy(r=>r.İş_Emri_No).ToList();
            }
        }
        public void Add(WRKORD wrk)
        {
            using (AlfaPlastikContext context = new AlfaPlastikContext())
            {
                var sonuc = context.WRKORDs.Any(x => x.WRKORD_NO == wrk.WRKORD_NO);
                if(sonuc==true)
                {
                    MessageBox.Show("İŞ EMRİ NUMARASI AYNI OLAMAZ!");
                }
                else
                {
                     var entity = context.Entry(wrk);
                     entity.State = System.Data.Entity.EntityState.Added;
                     context.SaveChanges();

                    MessageBox.Show("Kayıt Eklendi");                   
                }
              
            }
        }
        public void Update(WRKORD wrk)
        {
            using (AlfaPlastikContext context = new AlfaPlastikContext())
            {

              
                    var entity = context.Entry(wrk);
                    entity.State = System.Data.Entity.EntityState.Modified;
                    context.SaveChanges();
                    MessageBox.Show("Kayıt Güncellendi");
               

            }
        }
        public void Delete(WRKORD wrk)
        {
            using (AlfaPlastikContext context = new AlfaPlastikContext())
            {
               
                var entity = context.Entry(wrk);
                entity.State = System.Data.Entity.EntityState.Deleted;
                context.SaveChanges();
                MessageBox.Show("Kayıt Silindi");
            }
        }
    }
}
