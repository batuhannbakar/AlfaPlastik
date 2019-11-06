using Alfa.DataAccessLayer.EntityFramework;
using Alfa.Entities.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alfa.WORKORDER
{
    class Ucisemir2Dal
    { //Alfa.Entities.Models.OPERATION oPERATION = new Entities.Models.OPERATION();
        public void Add(WL_PLAN uc2)
        {
            using (AlfaPlastikContext context = new AlfaPlastikContext())
            {
                var entity = context.Entry(uc2);
                entity.State = System.Data.Entity.EntityState.Added;
                context.SaveChanges();

            }
           
          
        }
        public void Update(WL_PLAN uc2)
        {
            using (AlfaPlastikContext context = new AlfaPlastikContext())
            {

                var entity = context.Entry(uc2);
              entity.State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }
        public void Delete(WL_PLAN uc2)
        {
            using (AlfaPlastikContext context = new AlfaPlastikContext())
            {

                var entity = context.Entry(uc2);
                entity.State = System.Data.Entity.EntityState.Deleted;
                context.SaveChanges();
                MessageBox.Show("Kayıt Silindi");
            }
        }
        public string Getope1()
        {
            AlfaPlastikContext context = new AlfaPlastikContext();
            string oPERATION = context.Database.SqlQuery<string>("Select OPERATION_NAME from OPERATION where OPERATION_ID=2", new SqlParameter("@id", 2)).FirstOrDefault();
            return oPERATION;
        }
        public string Getope2()
        {
            AlfaPlastikContext context = new AlfaPlastikContext();
            string oPERATION = context.Database.SqlQuery<string>("Select OPERATION_NAME from OPERATION where OPERATION_ID=5", new SqlParameter("@id", 5)).FirstOrDefault();
            return oPERATION;
        }
        public string Getope3()
        {
            AlfaPlastikContext context = new AlfaPlastikContext();
            string oPERATION = context.Database.SqlQuery<string>("Select OPERATION_NAME from OPERATION where OPERATION_ID=32", new SqlParameter("@id", 32)).FirstOrDefault();
            return oPERATION;
        }
        public string Getope4()
        {
            AlfaPlastikContext context = new AlfaPlastikContext();
            string oPERATION = context.Database.SqlQuery<string>("Select OPERATION_NAME from OPERATION where OPERATION_ID=36", new SqlParameter("@id", 36)).FirstOrDefault();
            return oPERATION;
        }
        public string Getope5()
        {
            AlfaPlastikContext context = new AlfaPlastikContext();
            string oPERATION = context.Database.SqlQuery<string>("Select OPERATION_NAME from OPERATION where OPERATION_ID=37", new SqlParameter("@id", 37)).FirstOrDefault();
            return oPERATION;
        }
        public string Getope6()
        {
            AlfaPlastikContext context = new AlfaPlastikContext();
            string oPERATION = context.Database.SqlQuery<string>("Select OPERATION_NAME from OPERATION where OPERATION_ID=38", new SqlParameter("@id", 38)).FirstOrDefault();
            return oPERATION;
        }
        public string Getope7()
        {
            AlfaPlastikContext context = new AlfaPlastikContext();
            string oPERATION = context.Database.SqlQuery<string>("Select OPERATION_NAME from OPERATION where OPERATION_ID=39", new SqlParameter("@id", 39)).FirstOrDefault();
            return oPERATION;
        }
        public string Getope8()
        {
            AlfaPlastikContext context = new AlfaPlastikContext();
            string oPERATION = context.Database.SqlQuery<string>("Select OPERATION_NAME from OPERATION where OPERATION_ID=40", new SqlParameter("@id", 40)).FirstOrDefault();
            return oPERATION;
        }
    }
}
