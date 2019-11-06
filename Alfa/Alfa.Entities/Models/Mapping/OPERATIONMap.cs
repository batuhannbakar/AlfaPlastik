using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Alfa.Entities.Models.Mapping
{
    public class OPERATIONMap : EntityTypeConfiguration<OPERATION>
    {
        public OPERATIONMap()
        {
            // Primary Key
            this.HasKey(t => t.OPERATION_ID);

            // Properties
            this.Property(t => t.OPERATION_NAME)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("OPERATION");
            this.Property(t => t.OPERATION_ID).HasColumnName("OPERATION_ID");
            this.Property(t => t.OPERATION_INSERTDATE).HasColumnName("OPERATION_INSERTDATE");
            this.Property(t => t.OPERATION_NO).HasColumnName("OPERATION_NO");
            this.Property(t => t.OPERATION_NAME).HasColumnName("OPERATION_NAME");
        }
    }
}
