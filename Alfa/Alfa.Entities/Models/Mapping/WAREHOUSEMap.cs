using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Alfa.Entities.Models.Mapping
{
    public class WAREHOUSEMap : EntityTypeConfiguration<WAREHOUSE>
    {
        public WAREHOUSEMap()
        {
            // Primary Key
            this.HasKey(t => t.WAREHOUSE_ID);

            // Properties
            this.Property(t => t.WAREHOUSE_NAME)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("WAREHOUSE");
            this.Property(t => t.WAREHOUSE_ID).HasColumnName("WAREHOUSE_ID");
            this.Property(t => t.WAREHOUSE_INSERTDATE).HasColumnName("WAREHOUSE_INSERTDATE");
            this.Property(t => t.WAREHOUSE_NO).HasColumnName("WAREHOUSE_NO");
            this.Property(t => t.WAREHOUSE_NAME).HasColumnName("WAREHOUSE_NAME");
        }
    }
}
