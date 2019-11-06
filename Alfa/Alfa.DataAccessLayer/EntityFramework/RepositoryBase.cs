using Alfa.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alfa.DataAccessLayer.EntityFramework
{
   public class RepositoryBase
    {
        private static AlfaPlastikContext context;
        public static AlfaPlastikContext CreateContext
        {
            get
            {
                if(context==null)
                {
                    context = new AlfaPlastikContext();
                }
                return context;
            }
        }
    }
}
