using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Alfa.Entities.Models.Mapping
{
    public class WL_PLANMap : EntityTypeConfiguration<WL_PLAN>
    {
        public WL_PLANMap()
        {
            // Primary Key
            this.HasKey(t => t.PLAN_ID);

            // Properties
            this.Property(t => t.MAINTAIN_PERSON_NAME)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("WL_PLAN");
            this.Property(t => t.PLAN_ID).HasColumnName("PLAN_ID");
            this.Property(t => t.WRKID).HasColumnName("WRKID");
            this.Property(t => t.MAINTAIN_PERSON).HasColumnName("MAINTAIN_PERSON");
            this.Property(t => t.ESTIMATED_START_DATE).HasColumnName("ESTIMATED_START_DATE");
            this.Property(t => t.PLANNED_TİME).HasColumnName("PLANNED_TİME");
            this.Property(t => t.MAINTAIN_PERSON_NAME).HasColumnName("MAINTAIN_PERSON_NAME");
            this.Property(t => t.TO_DO_NOTE).HasColumnName("TO_DO_NOTE");

            // Relationships
            this.HasRequired(t => t.WRKORD)
                .WithMany(t => t.WL_PLAN)
                .HasForeignKey(d => d.WRKID);

        }
    }
}
