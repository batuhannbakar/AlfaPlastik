using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Alfa.Entities.Models.Mapping
{
    public class MOLDMap : EntityTypeConfiguration<MOLD>
    {
        public MOLDMap()
        {
            // Primary Key
            this.HasKey(t => t.MOLD_ID);

            // Properties
            this.Property(t => t.MOLD_NAME)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("MOLD");
            this.Property(t => t.MOLD_ID).HasColumnName("MOLD_ID");
            this.Property(t => t.MOLD_INSERTDATE).HasColumnName("MOLD_INSERTDATE");
            this.Property(t => t.MOLD_NO).HasColumnName("MOLD_NO");
            this.Property(t => t.MOLD_NAME).HasColumnName("MOLD_NAME");
            this.Property(t => t.Warehouse_ID).HasColumnName("Warehouse_ID");

            // Relationships
            this.HasRequired(t => t.WAREHOUSE)
                .WithMany(t => t.MOLDs)
                .HasForeignKey(d => d.Warehouse_ID);

        }
    }
}
