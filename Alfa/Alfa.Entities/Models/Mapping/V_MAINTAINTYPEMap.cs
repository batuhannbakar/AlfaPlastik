using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Alfa.Entities.Models.Mapping
{
    public class V_MAINTAINTYPEMap : EntityTypeConfiguration<V_MAINTAINTYPE>
    {
        public V_MAINTAINTYPEMap()
        {
            // Primary Key
            this.HasKey(t => new { t.MAINTAINTYPE_ID, t.Bakım_Tipi_Tarihi, t.Bakım_Tipi_Numarası, t.Bakım_Tipi_İsmi });

            // Properties
            this.Property(t => t.MAINTAINTYPE_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.Bakım_Tipi_Numarası)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Bakım_Tipi_İsmi)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("V_MAINTAINTYPE");
            this.Property(t => t.MAINTAINTYPE_ID).HasColumnName("MAINTAINTYPE_ID");
            this.Property(t => t.Bakım_Tipi_Tarihi).HasColumnName("Bakım Tipi Tarihi");
            this.Property(t => t.Bakım_Tipi_Numarası).HasColumnName("Bakım Tipi Numarası");
            this.Property(t => t.Bakım_Tipi_İsmi).HasColumnName("Bakım Tipi İsmi");
        }
    }
}
