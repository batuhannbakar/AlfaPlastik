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
    class UcisemirDal
    {
       
        public void Add(WL_REQUEST uc1)
        {
           
            using (AlfaPlastikContext context = new AlfaPlastikContext())
            {
               
                    var entity = context.Entry(uc1);
                    entity.State = System.Data.Entity.EntityState.Added;
                    context.SaveChanges();

                

            }
        }
        public void Update(WL_REQUEST uc1)
        {
            using (AlfaPlastikContext context = new AlfaPlastikContext())
            {

                    var entity = context.Entry(uc1);
                    entity.State = System.Data.Entity.EntityState.Modified;
                    context.SaveChanges();
            }
        }
        public void Delete(WL_REQUEST uc1)
        {
            using (AlfaPlastikContext context = new AlfaPlastikContext())
            {

                var entity = context.Entry(uc1);
                entity.State = System.Data.Entity.EntityState.Deleted;
                context.SaveChanges();
                MessageBox.Show("Kayıt Silindi");
            }
        }
    }
}
