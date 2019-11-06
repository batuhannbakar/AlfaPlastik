using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Alfa.Entities.Models.Mapping
{
    public class V_WAREHOUSEMap : EntityTypeConfiguration<V_WAREHOUSE>
    {
        public V_WAREHOUSEMap()
        {
            // Primary Key
            this.HasKey(t => new { t.WAREHOUSE_ID, t.Ambar_Tarihi, t.Ambar_Numarası, t.Ambar_İsmi });

            // Properties
            this.Property(t => t.WAREHOUSE_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.Ambar_Numarası)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Ambar_İsmi)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("V_WAREHOUSE");
            this.Property(t => t.WAREHOUSE_ID).HasColumnName("WAREHOUSE_ID");
            this.Property(t => t.Ambar_Tarihi).HasColumnName("Ambar Tarihi");
            this.Property(t => t.Ambar_Numarası).HasColumnName("Ambar Numarası");
            this.Property(t => t.Ambar_İsmi).HasColumnName("Ambar İsmi");
        }
    }
}
