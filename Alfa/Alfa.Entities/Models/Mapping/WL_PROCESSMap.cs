using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Alfa.Entities.Models.Mapping
{
    public class WL_PROCESSMap : EntityTypeConfiguration<WL_PROCESS>
    {
        public WL_PROCESSMap()
        {
            // Primary Key
            this.HasKey(t => t.PROCESS_ID);

            // Properties
            // Table & Column Mappings
            this.ToTable("WL_PROCESS");
            this.Property(t => t.PROCESS_ID).HasColumnName("PROCESS_ID");
            this.Property(t => t.WRKID).HasColumnName("WRKID");
            this.Property(t => t.PROCESS_NOTE).HasColumnName("PROCESS_NOTE");
            this.Property(t => t.OPE1_ID).HasColumnName("OPE1_ID");
            this.Property(t => t.OPE1_DATE).HasColumnName("OPE1_DATE");
            this.Property(t => t.OPE2_ID).HasColumnName("OPE2_ID");
            this.Property(t => t.OPE2_DATE).HasColumnName("OPE2_DATE");
            this.Property(t => t.OPE3_ID).HasColumnName("OPE3_ID");
            this.Property(t => t.OPE3_DATE).HasColumnName("OPE3_DATE");
            this.Property(t => t.OPE4_ID).HasColumnName("OPE4_ID");
            this.Property(t => t.OPE4_DATE).HasColumnName("OPE4_DATE");
            this.Property(t => t.OPE5_ID).HasColumnName("OPE5_ID");
            this.Property(t => t.OPE5_DATE).HasColumnName("OPE5_DATE");
            this.Property(t => t.OPE6_ID).HasColumnName("OPE6_ID");
            this.Property(t => t.OPE6_DATE).HasColumnName("OPE6_DATE");
            this.Property(t => t.OPE7_ID).HasColumnName("OPE7_ID");
            this.Property(t => t.OPE7_DATE).HasColumnName("OPE7_DATE");
            this.Property(t => t.OPE8_ID).HasColumnName("OPE8_ID");
            this.Property(t => t.OPE8_DATE).HasColumnName("OPE8_DATE");

            // Relationships
            this.HasOptional(t => t.OPERATION)
                .WithMany(t => t.WL_PROCESS)
                .HasForeignKey(d => d.OPE1_ID);
            this.HasOptional(t => t.OPERATION1)
                .WithMany(t => t.WL_PROCESS1)
                .HasForeignKey(d => d.OPE2_ID);
            this.HasOptional(t => t.OPERATION2)
                .WithMany(t => t.WL_PROCESS2)
                .HasForeignKey(d => d.OPE3_ID);
            this.HasOptional(t => t.OPERATION3)
                .WithMany(t => t.WL_PROCESS3)
                .HasForeignKey(d => d.OPE4_ID);
            this.HasOptional(t => t.OPERATION4)
                .WithMany(t => t.WL_PROCESS4)
                .HasForeignKey(d => d.OPE5_ID);
            this.HasOptional(t => t.OPERATION5)
                .WithMany(t => t.WL_PROCESS5)
                .HasForeignKey(d => d.OPE6_ID);
            this.HasOptional(t => t.OPERATION6)
                .WithMany(t => t.WL_PROCESS6)
                .HasForeignKey(d => d.OPE7_ID);
            this.HasOptional(t => t.OPERATION7)
                .WithMany(t => t.WL_PROCESS7)
                .HasForeignKey(d => d.OPE8_ID);
            this.HasRequired(t => t.WRKORD)
                .WithMany(t => t.WL_PROCESS)
                .HasForeignKey(d => d.WRKID);

        }
    }
}
