using Alfa.DataAccessLayer.EntityFramework;
using Alfa.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alfa.MAINTAINTYPE
{
    class MaintaintypeDal
    {

        public List<V_MAINTAINTYPE> GetAll()
        {
            using (AlfaPlastikContext context = new AlfaPlastikContext())
            {
                return context.V_MAINTAINTYPE.OrderBy(r => r.Bakım_Tipi_Numarası).ToList();
              
            }
        }
        public void Add(Entities.Models.MAINTAINTYPE main)
        {
            using (AlfaPlastikContext context = new AlfaPlastikContext())
            {
                var sonuc = context.MAINTAINTYPEs.Any(x => x.MAINTAINTYPE_NAME == main.MAINTAINTYPE_NAME);
                var sonuc2 = context.MAINTAINTYPEs.Any(x => x.MAINTAINTYPE_NO == main.MAINTAINTYPE_NO);
                if (sonuc == true)
                {
                    MessageBox.Show("Aynı isim girilemez");
                }
                else
                {
                    if (sonuc2 == true)
                    {
                        MessageBox.Show("Aynı numara girilemez");
                    }
                    else
                    {

                        var entity = context.Entry(main);
                        entity.State = System.Data.Entity.EntityState.Added;
                        context.SaveChanges();
                        MessageBox.Show("Kayıt Eklendi");
                        
                    }
                }
               
            }
        }
        public void Update(Entities.Models.MAINTAINTYPE main)
        {
            using (AlfaPlastikContext context = new AlfaPlastikContext())
            {

                try
                {
                    var entity = context.Entry(main);
                    entity.State = System.Data.Entity.EntityState.Modified;
                    context.SaveChanges();
                    MessageBox.Show("Kayıt Güncellendi");
                }
                catch (Exception)
                {

                    MessageBox.Show("Aynı değer girilemez");
                }
              

            }
        }
        public void Delete(Entities.Models.MAINTAINTYPE main)
        {
            using (AlfaPlastikContext context = new AlfaPlastikContext())
            {
                    var hata = context.WRKORDs.Any(x=>x.Maintaintype_ID==main.MAINTAINTYPE_ID);
                if(hata==true)
                {
                    MessageBox.Show("Silinemez Kayıt,Hareket Görmüştür!");
                }
                else
                {
                    var entity = context.Entry(main);
                    entity.State = System.Data.Entity.EntityState.Deleted;
                    context.SaveChanges();
                    MessageBox.Show("Kayıt Silindi");
                }
               
            }
        }
    }
}
