using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using RecruitmentSystemRepositories.Interfaces;

#nullable disable

namespace RecruitmentSystemRepositories.Models
{
    public partial class RecruitmentSystemContext : DbContext,IContext
    {
        public RecruitmentSystemContext()
        {
        }

        public RecruitmentSystemContext(DbContextOptions<RecruitmentSystemContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Candidate> Candidates { get; set; }
        public virtual DbSet<Language> Languages { get; set; }
        public virtual DbSet<WorkerLanguage> WorkerLanguages { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=.;Database=RecruitmentSystem;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Hebrew_CI_AS");

            modelBuilder.Entity<Candidate>(entity =>
            {
                entity.ToTable("candidate");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.BeginYear).HasColumnName("beginYear");

                entity.Property(e => e.LastUpdateDate)
                    .HasColumnType("date")
                    .HasColumnName("lastUpdateDate");

                entity.Property(e => e.Name)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<Language>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<WorkerLanguage>(entity =>
            {
                entity.HasKey(e => new { e.CandidateId, e.LanguageId })
                    .HasName("PK__WorkerLa__45113222949B3892");

                entity.Property(e => e.CandidateId).HasColumnName("candidateId");

                entity.Property(e => e.LanguageId).HasColumnName("languageId");

                entity.Property(e => e.Number).HasColumnName("number");

                entity.HasOne(d => d.Candidate)
                    .WithMany(p => p.WorkerLanguages)
                    .HasForeignKey(d => d.CandidateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__WorkerLan__candi__276EDEB3");

                entity.HasOne(d => d.Language)
                    .WithMany(p => p.WorkerLanguages)
                    .HasForeignKey(d => d.LanguageId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__WorkerLan__langu__286302EC");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
