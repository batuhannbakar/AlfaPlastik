using Alfa.DataAccessLayer.EntityFramework;
using Alfa.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alfa.WORKORDER
{
    class Ucisemir3Dal
    {
        public void Add(WL_PROCESS uc3)
        {
            using (AlfaPlastikContext context = new AlfaPlastikContext())
            {
                var entity = context.Entry(uc3);
                entity.State = System.Data.Entity.EntityState.Added;
                context.SaveChanges();
            }
        }
        public void Update(WL_PROCESS uc3)
        {
            using (AlfaPlastikContext context = new AlfaPlastikContext())
            {

                var entity = context.Entry(uc3);
                entity.State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }
        public void Delete(WL_PROCESS uc3)
        {
            using (AlfaPlastikContext context = new AlfaPlastikContext())
            {

                var entity = context.Entry(uc3);
                entity.State = System.Data.Entity.EntityState.Deleted;
                context.SaveChanges();
                MessageBox.Show("Kayıt Silindi");
            }
        }
    }
}
