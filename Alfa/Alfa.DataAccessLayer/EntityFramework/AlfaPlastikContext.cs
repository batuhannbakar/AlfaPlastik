using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using Alfa.Entities.Models;
using Alfa.Entities.Models.Mapping;

namespace Alfa.DataAccessLayer.EntityFramework
{
    public partial class AlfaPlastikContext : DbContext
    {
        static AlfaPlastikContext()
        {
            Database.SetInitializer<AlfaPlastikContext>(null);
        }

        public AlfaPlastikContext()
            : base("Data Source=asus;Initial Catalog=AlfaPlastik;Integrated Security=True")
        {
        }

        public DbSet<MAINTAINTYPE> MAINTAINTYPEs { get; set; }
        public DbSet<MOLD> MOLDs { get; set; }
        public DbSet<OPERATION> OPERATIONs { get; set; }
        public DbSet<sysdiagram> sysdiagrams { get; set; }
        public DbSet<TRACKING> TRACKINGs { get; set; }
        public DbSet<USER> USERS { get; set; }
        public DbSet<WAREHOUSE> WAREHOUSEs { get; set; }
        public DbSet<WL_COMPLETE> WL_COMPLETE { get; set; }
        public DbSet<WL_PLAN> WL_PLAN { get; set; }
        public DbSet<WL_PROCESS> WL_PROCESS { get; set; }
        public DbSet<WL_REQUEST> WL_REQUEST { get; set; }
        public DbSet<WRKORD> WRKORDs { get; set; }
        public DbSet<V_MAINTAINTYPE> V_MAINTAINTYPE { get; set; }
        public DbSet<V_MOLD> V_MOLD { get; set; }
        public DbSet<V_OPERATION> V_OPERATION { get; set; }
        public DbSet<V_TRACKING_GRID> V_TRACKING_GRID { get; set; }
        public DbSet<V_WAREHOUSE> V_WAREHOUSE { get; set; }
        public DbSet<V_WRKORD_GRID> V_WRKORD_GRID { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new MAINTAINTYPEMap());
            modelBuilder.Configurations.Add(new MOLDMap());
            modelBuilder.Configurations.Add(new OPERATIONMap());
            modelBuilder.Configurations.Add(new sysdiagramMap());
            modelBuilder.Configurations.Add(new TRACKINGMap());
            modelBuilder.Configurations.Add(new USERMap());
            modelBuilder.Configurations.Add(new WAREHOUSEMap());
            modelBuilder.Configurations.Add(new WL_COMPLETEMap());
            modelBuilder.Configurations.Add(new WL_PLANMap());
            modelBuilder.Configurations.Add(new WL_PROCESSMap());
            modelBuilder.Configurations.Add(new WL_REQUESTMap());
            modelBuilder.Configurations.Add(new WRKORDMap());
            modelBuilder.Configurations.Add(new V_MAINTAINTYPEMap());
            modelBuilder.Configurations.Add(new V_MOLDMap());
            modelBuilder.Configurations.Add(new V_OPERATIONMap());
            modelBuilder.Configurations.Add(new V_TRACKING_GRIDMap());
            modelBuilder.Configurations.Add(new V_WAREHOUSEMap());
            modelBuilder.Configurations.Add(new V_WRKORD_GRIDMap());
        }
    }
}
