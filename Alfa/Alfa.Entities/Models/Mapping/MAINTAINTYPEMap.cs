using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Alfa.Entities.Models.Mapping
{
    public class MAINTAINTYPEMap : EntityTypeConfiguration<MAINTAINTYPE>
    {
        public MAINTAINTYPEMap()
        {
            // Primary Key
            this.HasKey(t => t.MAINTAINTYPE_ID);

            // Properties
            this.Property(t => t.MAINTAINTYPE_NAME)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("MAINTAINTYPE");
            this.Property(t => t.MAINTAINTYPE_ID).HasColumnName("MAINTAINTYPE_ID");
            this.Property(t => t.MAINTAINTYPE_INSERTDATE).HasColumnName("MAINTAINTYPE_INSERTDATE");
            this.Property(t => t.MAINTAINTYPE_NO).HasColumnName("MAINTAINTYPE_NO");
            this.Property(t => t.MAINTAINTYPE_NAME).HasColumnName("MAINTAINTYPE_NAME");
        }
    }
}
