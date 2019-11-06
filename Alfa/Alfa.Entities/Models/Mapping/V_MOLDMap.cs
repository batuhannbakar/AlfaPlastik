using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Alfa.Entities.Models.Mapping
{
    public class V_MOLDMap : EntityTypeConfiguration<V_MOLD>
    {
        public V_MOLDMap()
        {
            // Primary Key
            this.HasKey(t => new { t.MOLD_ID, t.KALIP_Numarası, t.KALIP_Adı, t.MOLD_INSERTDATE, t.Kalıp_Yeri });

            // Properties
            this.Property(t => t.MOLD_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.KALIP_Numarası)
                                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);


            this.Property(t => t.KALIP_Adı)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Kalıp_Yeri)
                .IsRequired()
                .HasMaxLength(30);

            // Table & Column Mappings
            this.ToTable("V_MOLD");
            this.Property(t => t.MOLD_ID).HasColumnName("MOLD_ID");
            this.Property(t => t.KALIP_Numarası).HasColumnName("KALIP Numarası");
            this.Property(t => t.KALIP_Adı).HasColumnName("KALIP Adı");
            this.Property(t => t.MOLD_INSERTDATE).HasColumnName("MOLD_INSERTDATE");
            this.Property(t => t.Warehouse_ID).HasColumnName("Warehouse_ID");
            this.Property(t => t.Kalıp_Yeri).HasColumnName("Kalıp Yeri");
        }
    }
}
