using Alfa.DataAccessLayer.EntityFramework;
using Alfa.Entities.Models;
using System.Windows.Forms;

namespace Alfa.WORKORDER
{
    class Ucisemir4Dal
    {
        public void Add(WL_COMPLETE uc4)
        {
            using (AlfaPlastikContext context = new AlfaPlastikContext())
               
            {
                    var entity = context.Entry(uc4);
                    entity.State = System.Data.Entity.EntityState.Added;
                    context.SaveChanges();

            }
            
        }
        public void Update(WL_COMPLETE uc4)
        {
            using (AlfaPlastikContext context = new AlfaPlastikContext())
            {

                var entity = context.Entry(uc4);
                entity.State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }
        public void Delete(WL_COMPLETE uc4)
        {
            using (AlfaPlastikContext context = new AlfaPlastikContext())
            {

                var entity = context.Entry(uc4);
                entity.State = System.Data.Entity.EntityState.Deleted;
                context.SaveChanges();
                MessageBox.Show("Kayıt Silindi");
            }
        }
    }
}
