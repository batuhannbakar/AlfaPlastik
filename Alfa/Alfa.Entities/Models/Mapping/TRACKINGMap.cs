using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Alfa.Entities.Models.Mapping
{
    public class TRACKINGMap : EntityTypeConfiguration<TRACKING>
    {
        public TRACKINGMap()
        {
            // Primary Key
            this.HasKey(t => t.TRACKING_ID);

            // Properties
            // Table & Column Mappings
            this.ToTable("TRACKING");
            this.Property(t => t.TRACKING_ID).HasColumnName("TRACKING_ID");
            this.Property(t => t.WRKID).HasColumnName("WRKID");
            this.Property(t => t.TRACKING_NOTE).HasColumnName("TRACKING_NOTE");
            this.Property(t => t.TRACKING_STATUS).HasColumnName("TRACKING_STATUS");
            this.Property(t => t.TRACKING_INSERTDATE).HasColumnName("TRACKING_INSERTDATE");
            this.Property(t => t.CREATER_ID).HasColumnName("CREATER_ID");
            this.Property(t => t.Mold_ID).HasColumnName("Mold_ID");
            this.Property(t => t.MODIFY_DATE).HasColumnName("MODIFY_DATE");
            this.Property(t => t.MODIFIER_ID).HasColumnName("MODIFIER_ID");

            // Relationships
            this.HasOptional(t => t.MOLD)
                .WithMany(t => t.TRACKINGs)
                .HasForeignKey(d => d.Mold_ID);
            this.HasRequired(t => t.USER)
                .WithMany(t => t.TRACKINGs)
                .HasForeignKey(d => d.CREATER_ID);
            this.HasOptional(t => t.WRKORD)
                .WithMany(t => t.TRACKINGs)
                .HasForeignKey(d => d.WRKID);

        }
    }
}
