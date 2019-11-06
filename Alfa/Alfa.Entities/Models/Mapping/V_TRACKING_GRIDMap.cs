using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Alfa.Entities.Models.Mapping
{
    public class V_TRACKING_GRIDMap : EntityTypeConfiguration<V_TRACKING_GRID>
    {
        public V_TRACKING_GRIDMap()
        {
            // Primary Key
            this.HasKey(t => new { t.TRACKING_ID, t.CREATER_ID });

            // Properties
            this.Property(t => t.TRACKING_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.CREATER_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("V_TRACKING_GRID");
            this.Property(t => t.TRACKING_ID).HasColumnName("TRACKING_ID");
            this.Property(t => t.WRKID).HasColumnName("WRKID");
            this.Property(t => t.TRACKING_NOTE).HasColumnName("TRACKING_NOTE");
            this.Property(t => t.TRACKING_STATUS).HasColumnName("TRACKING_STATUS");
            this.Property(t => t.TRACKING_INSERTDATE).HasColumnName("TRACKING_INSERTDATE");
            this.Property(t => t.CREATER_ID).HasColumnName("CREATER_ID");
            this.Property(t => t.Mold_ID).HasColumnName("Mold_ID");
            this.Property(t => t.MODIFY_DATE).HasColumnName("MODIFY_DATE");
            this.Property(t => t.MODIFIER_ID).HasColumnName("MODIFIER_ID");
        }
    }
}
