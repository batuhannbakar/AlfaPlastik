using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Alfa.Entities.Models.Mapping
{
    public class WRKORDLINEMap : EntityTypeConfiguration<WRKORDLINE>
    {
        public WRKORDLINEMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            // Table & Column Mappings
            this.ToTable("WRKORDLINE");
            this.Property(t => t.ID).HasColumnName("ID");
        }
    }
}
