using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Alfa.Entities.Models.Mapping
{
    public class USERMap : EntityTypeConfiguration<USER>
    {
        public USERMap()
        {
            // Primary Key
            this.HasKey(t => t.USERS_ID);

            // Properties
            this.Property(t => t.NAME)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.PASSWORD)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("USERS");
            this.Property(t => t.USERS_ID).HasColumnName("USERS_ID");
            this.Property(t => t.NAME).HasColumnName("NAME");
            this.Property(t => t.PASSWORD).HasColumnName("PASSWORD");
        }
    }
}
