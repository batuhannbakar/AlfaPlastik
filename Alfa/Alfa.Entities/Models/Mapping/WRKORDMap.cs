using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Alfa.Entities.Models.Mapping
{
    public class WRKORDMap : EntityTypeConfiguration<WRKORD>
    {
        public WRKORDMap()
        {
            // Primary Key
            this.HasKey(t => t.WRKORD_ID);

            // Properties
            this.Property(t => t.STATUS_)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("WRKORD");
            this.Property(t => t.WRKORD_ID).HasColumnName("WRKORD_ID");
            this.Property(t => t.WRKORD_NO).HasColumnName("WRKORD_NO");
            this.Property(t => t.WRKORD_INSERTDATE).HasColumnName("WRKORD_INSERTDATE");
            this.Property(t => t.CREATER_ID).HasColumnName("CREATER_ID");
            this.Property(t => t.Mold_ID).HasColumnName("Mold_ID");
            this.Property(t => t.MODIFYDATE).HasColumnName("MODIFYDATE");
            this.Property(t => t.MODIFIER_ID).HasColumnName("MODIFIER_ID");
            this.Property(t => t.Maintaintype_ID).HasColumnName("Maintaintype_ID");
            this.Property(t => t.STATUS_).HasColumnName("STATUS_");

            // Relationships
            this.HasRequired(t => t.MAINTAINTYPE)
                .WithMany(t => t.WRKORDs)
                .HasForeignKey(d => d.Maintaintype_ID);
            this.HasOptional(t => t.MOLD)
                .WithMany(t => t.WRKORDs)
                .HasForeignKey(d => d.Mold_ID);
            this.HasRequired(t => t.USER)
                .WithMany(t => t.WRKORDs)
                .HasForeignKey(d => d.CREATER_ID);
            this.HasOptional(t => t.USER1)
                .WithMany(t => t.WRKORDs1)
                .HasForeignKey(d => d.MODIFIER_ID);

        }
    }
}
