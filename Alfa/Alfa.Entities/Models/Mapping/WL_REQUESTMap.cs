using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Alfa.Entities.Models.Mapping
{
    public class WL_REQUESTMap : EntityTypeConfiguration<WL_REQUEST>
    {
        public WL_REQUESTMap()
        {
            // Primary Key
            this.HasKey(t => t.REQUEST_ID);

            // Properties
            this.Property(t => t.PRIORITY)
                .HasMaxLength(50);

            this.Property(t => t.REQUEST_BY_NAME)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("WL_REQUEST");
            this.Property(t => t.REQUEST_ID).HasColumnName("REQUEST_ID");
            this.Property(t => t.WRKID).HasColumnName("WRKID");
            this.Property(t => t.PRIORITY).HasColumnName("PRIORITY");
            this.Property(t => t.REQUEST_BY).HasColumnName("REQUEST_BY");
            this.Property(t => t.REQUEST_DATE).HasColumnName("REQUEST_DATE");
            this.Property(t => t.PLANNED_START_DATE).HasColumnName("PLANNED_START_DATE");
            this.Property(t => t.WRK_NOTE).HasColumnName("WRK_NOTE");
            this.Property(t => t.REQUEST_BY_NAME).HasColumnName("REQUEST_BY_NAME");

            // Relationships
            this.HasRequired(t => t.WRKORD)
                .WithMany(t => t.WL_REQUEST)
                .HasForeignKey(d => d.WRKID);

        }
    }
}
