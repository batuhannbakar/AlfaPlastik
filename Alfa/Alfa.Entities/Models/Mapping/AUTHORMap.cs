using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Alfa.Entities.Models.Mapping
{
    public class AUTHORMap : EntityTypeConfiguration<AUTHOR>
    {
        public AUTHORMap()
        {
            // Primary Key
            this.HasKey(t => t.AUTHORS_ID);

            // Properties
            this.Property(t => t.AUTHORS_NAME)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("AUTHORS");
            this.Property(t => t.AUTHORS_ID).HasColumnName("AUTHORS_ID");
            this.Property(t => t.AUTHORS_NO).HasColumnName("AUTHORS_NO");
            this.Property(t => t.AUTHORS_NAME).HasColumnName("AUTHORS_NAME");
        }
    }
}
