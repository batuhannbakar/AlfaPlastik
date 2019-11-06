using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Alfa.Entities.Models.Mapping
{
    public class V_WRKORD_GRIDMap : EntityTypeConfiguration<V_WRKORD_GRID>
    {
        public V_WRKORD_GRIDMap()
        {
            // Primary Key
            this.HasKey(t => new { t.İş_Emri_No, t.İş_Emri_Tarihi, t.Bakım_Tipi, t.USERS_ID, t.KULLANICI, t.WRKORD_ID });

            // Properties
            this.Property(t => t.İş_Emri_No)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Değiştiren_Kişi)
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.Bakım_Tipi)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Statü)
                .HasMaxLength(50);

            this.Property(t => t.USERS_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Talep_Eden)
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.KULLANICI)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.Kalıp_Yeri)
                .HasMaxLength(50);

            this.Property(t => t.Kalıp_Adı)
                .HasMaxLength(50);

            this.Property(t => t.PRIORITY)
                .HasMaxLength(50);

            this.Property(t => t.Bakım_Personeli)
                .HasMaxLength(50);

            this.Property(t => t.DELIVERY_TYPE)
                .HasMaxLength(50);

            this.Property(t => t.OPE1)
                .HasMaxLength(50);

            this.Property(t => t.OPE2)
                .HasMaxLength(50);

            this.Property(t => t.OPE3)
                .HasMaxLength(50);

            this.Property(t => t.OPE4)
                .HasMaxLength(50);

            this.Property(t => t.OPE5)
                .HasMaxLength(50);

            this.Property(t => t.OPE6)
                .HasMaxLength(50);

            this.Property(t => t.OPE7)
                .HasMaxLength(50);

            this.Property(t => t.OPE8)
                .HasMaxLength(50);

            this.Property(t => t.WRKORD_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("V_WRKORD_GRID");
            this.Property(t => t.İş_Emri_No).HasColumnName("İş Emri No");
            this.Property(t => t.İş_Emri_Tarihi).HasColumnName("İş Emri Tarihi");
            this.Property(t => t.Değiştirme_Tarihi).HasColumnName("Değiştirme Tarihi");
            this.Property(t => t.Değiştiren_Kişi).HasColumnName("Değiştiren Kişi");
            this.Property(t => t.Bakım_Tipi).HasColumnName("Bakım Tipi");
            this.Property(t => t.Statü).HasColumnName("Statü");
            this.Property(t => t.USERS_ID).HasColumnName("USERS_ID");
            this.Property(t => t.Talep_Eden).HasColumnName("Talep Eden");
            this.Property(t => t.KULLANICI).HasColumnName("KULLANICI");
            this.Property(t => t.Kalıp_Yeri).HasColumnName("Kalıp Yeri");
            this.Property(t => t.Kalıp_Adı).HasColumnName("Kalıp Adı");
            this.Property(t => t.Kalıp_No).HasColumnName("Kalıp No");
            this.Property(t => t.PRIORITY).HasColumnName("PRIORITY");
            this.Property(t => t.Bakım_Personeli).HasColumnName("Bakım Personeli");
            this.Property(t => t.PLANNED_START_DATE).HasColumnName("PLANNED_START_DATE");
            this.Property(t => t.REQUEST_BY).HasColumnName("REQUEST_BY");
            this.Property(t => t.REQUEST_DATE).HasColumnName("REQUEST_DATE");
            this.Property(t => t.WRK_NOTE).HasColumnName("WRK_NOTE");
            this.Property(t => t.ESTIMATED_START_DATE).HasColumnName("ESTIMATED_START_DATE");
            this.Property(t => t.MAINTAIN_PERSON).HasColumnName("MAINTAIN_PERSON");
            this.Property(t => t.PLANNED_TİME).HasColumnName("PLANNED_TİME");
            this.Property(t => t.TO_DO_NOTE).HasColumnName("TO_DO_NOTE");
            this.Property(t => t.PROCESS_NOTE).HasColumnName("PROCESS_NOTE");
            this.Property(t => t.COMPLETION_DATE).HasColumnName("COMPLETION_DATE");
            this.Property(t => t.COMPLETION_TİME).HasColumnName("COMPLETION_TİME");
            this.Property(t => t.DELIVERY_NOTE).HasColumnName("DELIVERY_NOTE");
            this.Property(t => t.DELIVERY_TYPE).HasColumnName("DELIVERY_TYPE");
            this.Property(t => t.OPE1).HasColumnName("OPE1");
            this.Property(t => t.OPE1_DATE).HasColumnName("OPE1_DATE");
            this.Property(t => t.OPE2).HasColumnName("OPE2");
            this.Property(t => t.OPE2_DATE).HasColumnName("OPE2_DATE");
            this.Property(t => t.OPE3).HasColumnName("OPE3");
            this.Property(t => t.OPE3_DATE).HasColumnName("OPE3_DATE");
            this.Property(t => t.OPE4).HasColumnName("OPE4");
            this.Property(t => t.OPE4_DATE).HasColumnName("OPE4_DATE");
            this.Property(t => t.OPE5).HasColumnName("OPE5");
            this.Property(t => t.OPE5_DATE).HasColumnName("OPE5_DATE");
            this.Property(t => t.OPE6).HasColumnName("OPE6");
            this.Property(t => t.OPE6_DATE).HasColumnName("OPE6_DATE");
            this.Property(t => t.OPE7).HasColumnName("OPE7");
            this.Property(t => t.OPE7_DATE).HasColumnName("OPE7_DATE");
            this.Property(t => t.OPE8).HasColumnName("OPE8");
            this.Property(t => t.OPE8_DATE).HasColumnName("OPE8_DATE");
            this.Property(t => t.WRKORD_ID).HasColumnName("WRKORD_ID");
        }
    }
}
