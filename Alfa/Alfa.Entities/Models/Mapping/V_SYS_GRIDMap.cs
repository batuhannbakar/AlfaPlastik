using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Alfa.Entities.Models.Mapping
{
    public class V_SYS_GRIDMap : EntityTypeConfiguration<V_SYS_GRID>
    {
        public V_SYS_GRIDMap()
        {
            // Primary Key
            this.HasKey(t => new { t.AUTHORS_ID, t.USERS_ID, t.Kullanıcı_Adı, t.Kullanıcı_Şifre, t.Kullanıcı_Yetkisi });

            // Properties
            this.Property(t => t.AUTHORS_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.USERS_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Kullanıcı_Adı)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.Kullanıcı_Şifre)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.Kullanıcı_Yetkisi)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("V_SYS_GRID");
            this.Property(t => t.AUTHORS_ID).HasColumnName("AUTHORS_ID");
            this.Property(t => t.USERS_ID).HasColumnName("USERS_ID");
            this.Property(t => t.Kullanıcı_Adı).HasColumnName("Kullanıcı_Adı");
            this.Property(t => t.Kullanıcı_Şifre).HasColumnName("Kullanıcı_Şifre");
            this.Property(t => t.Kullanıcı_Yetkisi).HasColumnName("Kullanıcı_Yetkisi");
        }
    }
}
