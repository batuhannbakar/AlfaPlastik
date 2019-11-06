using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Alfa.Entities.Models.Mapping
{
    public class V_OPERATIONMap : EntityTypeConfiguration<V_OPERATION>
    {
        public V_OPERATIONMap()
        {
            // Primary Key
            this.HasKey(t => new { t.OPERATION_ID, t.Operasyon_Tarihi, t.Operasyon_Numarası, t.Operasyon_İsmi });

            // Properties
            this.Property(t => t.OPERATION_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.Operasyon_Numarası)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Operasyon_İsmi)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("V_OPERATION");
            this.Property(t => t.OPERATION_ID).HasColumnName("OPERATION_ID");
            this.Property(t => t.Operasyon_Tarihi).HasColumnName("Operasyon Tarihi");
            this.Property(t => t.Operasyon_Numarası).HasColumnName("Operasyon Numarası");
            this.Property(t => t.Operasyon_İsmi).HasColumnName("Operasyon İsmi");
        }
    }
}
