using Alfa.DataAccessLayer.EntityFramework;
using Alfa.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alfa.MOLD
{
    class MoldDal
    {
        public List<V_MOLD> GetAll()
        {
            using (AlfaPlastikContext context = new AlfaPlastikContext())
            {
                return context.V_MOLD.OrderBy(r => r.KALIP_Numarası).ToList();
            }
        }
        public void Add(Entities.Models.MOLD mold)
        {
            using (AlfaPlastikContext context = new AlfaPlastikContext())
            {
                var sonuc = context.MOLDs.Any(x => x.MOLD_NAME == mold.MOLD_NAME);
                var sonuc2 = context.MOLDs.Any(x => x.MOLD_NO== mold.MOLD_NO);
                if (sonuc == true)
                {
                    MessageBox.Show("aynı isim giremez");
                }
                else
                {
                    if (sonuc2 == true)
                    {
                        MessageBox.Show("aynı NO giremez");
                    }
                    else
                    {

                        var entity = context.Entry(mold);
                        entity.State = System.Data.Entity.EntityState.Added;
                        context.SaveChanges();
                        MessageBox.Show("Kayıt Eklendi");

                    }
                }

            }
        }
        public void Update(Entities.Models.MOLD mold)
        {
            using (AlfaPlastikContext context = new AlfaPlastikContext())
            {

                try { 
                        var entity = context.Entry(mold);
                        entity.State = System.Data.Entity.EntityState.Modified;
                        context.SaveChanges();
            }
                catch (Exception)
            {

                MessageBox.Show("Aynı değer girilemez");
            }

        }
        }
        public void Delete(Entities.Models.MOLD mold)
        {
            using (AlfaPlastikContext context = new AlfaPlastikContext())
            {
                var hata = context.WRKORDs.Any(x => x.Mold_ID == mold.MOLD_ID);
                if (hata==true)
                {
                    MessageBox.Show("Silinemez Kayıt,Hareket Görmüştür!");
                }
                else
                {
                    var entity = context.Entry(mold);
                    entity.State = System.Data.Entity.EntityState.Deleted;
                    context.SaveChanges();
                    MessageBox.Show("Kayıt Silindi");
                }
               
            }
        }
    }
}

