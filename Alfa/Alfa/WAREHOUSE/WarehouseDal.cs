using Alfa.DataAccessLayer.EntityFramework;
using Alfa.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Alfa.WAREHOUSE
{
    class WarehouseDal
    {
        public List<V_WAREHOUSE> GetAll()
        {
            using (AlfaPlastikContext context = new AlfaPlastikContext())
            {
                return context.V_WAREHOUSE.OrderBy(a => a.Ambar_Numarası).ToList();
            }
        }
        public void Add(Entities.Models.WAREHOUSE wrh)
        {
            using (AlfaPlastikContext context = new AlfaPlastikContext())
            {
                var sonuc = context.WAREHOUSEs.Any(x => x.WAREHOUSE_NAME == wrh.WAREHOUSE_NAME);
                var sonuc2 = context.WAREHOUSEs.Any(x => x.WAREHOUSE_NO ==wrh.WAREHOUSE_NO);
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

                        var entity = context.Entry(wrh);
                        entity.State = System.Data.Entity.EntityState.Added;
                        context.SaveChanges();
                        MessageBox.Show("Kayıt Eklendi");

                    }
                }

            }
        }
        public void Update(Entities.Models.WAREHOUSE wrh)
        {
            using (AlfaPlastikContext context = new AlfaPlastikContext())
            {

                try
                {
                    var entity = context.Entry(wrh);
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
        public void Delete(Entities.Models.WAREHOUSE wrh)
        {
            using (AlfaPlastikContext context = new AlfaPlastikContext())
            {
                var hata = context.MOLDs.Any(x => x.Warehouse_ID == wrh.WAREHOUSE_ID);
                if (hata == true)
                {
                    MessageBox.Show("Silinemez Kayıt,Hareket Görmüştür!");
                }
                else
                {
                    var entity = context.Entry(wrh);
                    entity.State = System.Data.Entity.EntityState.Deleted;

                    context.SaveChanges();
                    MessageBox.Show("Kayıt Silindi");
                }
          
               
              
               
            }
        }
    }
}
