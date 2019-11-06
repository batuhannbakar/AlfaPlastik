using Alfa.DataAccessLayer.EntityFramework;
using Alfa.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alfa.OPERATION
{
    class OperationDal
    {
        public List<V_OPERATION> GetAll()
        {
            using (AlfaPlastikContext context = new AlfaPlastikContext())
            {
                return context.V_OPERATION.OrderBy(r => r.Operasyon_Numarası).ToList();
            }
        }
        public void Add(Entities.Models.OPERATION ope)
        {
            using (AlfaPlastikContext context = new AlfaPlastikContext())
            {
                var sonuc = context.OPERATIONs.Any(x => x.OPERATION_NAME == ope.OPERATION_NAME);
                var sonuc2 = context.OPERATIONs.Any(x => x.OPERATION_NO == ope.OPERATION_NO);
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

                        var entity = context.Entry(ope);
                        entity.State = System.Data.Entity.EntityState.Added;
                        context.SaveChanges();
                        MessageBox.Show("Kayıt Eklendi");

                    }
                }

            }
        }
        public void Update(Entities.Models.OPERATION ope)
        {
            using (AlfaPlastikContext context = new AlfaPlastikContext())
            {

                //try
                //{
                    var entity = context.Entry(ope);
                    entity.State = System.Data.Entity.EntityState.Modified;
                    context.SaveChanges();
                    MessageBox.Show("Kayıt Güncellendi");

                //}
                //catch (Exception)
                //{

                //    MessageBox.Show("Aynı değer girilemez");
                //}
                
            }
        }
        public void Delete(Entities.Models.OPERATION ope)
        {
            using (AlfaPlastikContext context = new AlfaPlastikContext())
            {

                var entity = context.Entry(ope);
                entity.State = System.Data.Entity.EntityState.Deleted;
                context.SaveChanges();
                MessageBox.Show("Kayıt Silindi");
            }
        }
    }
}
