using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Alfa.Entities.Models.Mapping
{
    public class WL_COMPLETEMap : EntityTypeConfiguration<WL_COMPLETE>
    {
        public WL_COMPLETEMap()
        {
            // Primary Key
            this.HasKey(t => t.COMPLETE_ID);

            // Properties
            this.Property(t => t.DELIVERY_TYPE)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("WL_COMPLETE");
            this.Property(t => t.COMPLETE_ID).HasColumnName("COMPLETE_ID");
            this.Property(t => t.WRKID).HasColumnName("WRKID");
            this.Property(t => t.DELIVERY_TYPE).HasColumnName("DELIVERY_TYPE");
            this.Property(t => t.COMPLETION_DATE).HasColumnName("COMPLETION_DATE");
            this.Property(t => t.COMPLETION_TİME).HasColumnName("COMPLETION_TİME");
            this.Property(t => t.DELIVERY_NOTE).HasColumnName("DELIVERY_NOTE");

            // Relationships
            this.HasRequired(t => t.WRKORD)
                .WithMany(t => t.WL_COMPLETE)
                .HasForeignKey(d => d.WRKID);

        }
    }
}
