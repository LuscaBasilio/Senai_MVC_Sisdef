using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Senai.SAEP.Sisdef.Domains;

namespace Senai.SAEP.Sisdef.Contextos
{
    public partial class SisdefContext : DbContext
    {
        public SisdefContext()
        {
        }

        public SisdefContext(DbContextOptions<SisdefContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Defeito> Defeito { get; set; }
        public virtual DbSet<Equipamento> Equipamento { get; set; }
        public virtual DbSet<RegistroDefeito> RegistroDefeito { get; set; }
        public virtual DbSet<TipoEquipamento> TipoEquipamento { get; set; }
        public virtual DbSet<Usuario> Usuario { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
                //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=.\\SQLEXPRESS01;Initial Catalog=SISDEF_SAEP;user id = sa; pwd = info@132");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Defeito>(entity =>
            {
                entity.ToTable("DEFEITO");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasColumnName("NOME")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Equipamento>(entity =>
            {
                entity.ToTable("EQUIPAMENTO");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Horario)
                    .HasColumnName("HORARIO")
                    .HasColumnType("datetime");

                entity.Property(e => e.TipoEquipamentoId).HasColumnName("TIPO_EQUIPAMENTO_ID");

                entity.HasOne(d => d.TipoEquipamento)
                    .WithMany(p => p.Equipamento)
                    .HasForeignKey(d => d.TipoEquipamentoId)
                    .HasConstraintName("FK__EQUIPAMEN__TIPO___628FA481");
            });

            modelBuilder.Entity<RegistroDefeito>(entity =>
            {
                entity.ToTable("REGISTRO_DEFEITO");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DataDefeito)
                    .HasColumnName("DATA_DEFEITO")
                    .HasColumnType("datetime");

                entity.Property(e => e.EquipamentoId).HasColumnName("EQUIPAMENTO_ID");

                entity.Property(e => e.HoraFinal)
                    .HasColumnName("HORA_FINAL")
                    .HasColumnType("datetime");

                entity.Property(e => e.HoraInicial)
                    .HasColumnName("HORA_INICIAL")
                    .HasColumnType("datetime");

                entity.Property(e => e.TipoDefeitoId).HasColumnName("TIPO_DEFEITO_ID");

                entity.HasOne(d => d.Equipamento)
                    .WithMany(p => p.RegistroDefeito)
                    .HasForeignKey(d => d.EquipamentoId)
                    .HasConstraintName("FK__REGISTRO___EQUIP__656C112C");

                entity.HasOne(d => d.TipoDefeito)
                    .WithMany(p => p.RegistroDefeito)
                    .HasForeignKey(d => d.TipoDefeitoId)
                    .HasConstraintName("FK__REGISTRO___TIPO___66603565");
            });

            modelBuilder.Entity<TipoEquipamento>(entity =>
            {
                entity.ToTable("TIPO_EQUIPAMENTO");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasColumnName("NOME")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.ToTable("USUARIO");

                entity.HasIndex(e => e.Email)
                    .HasName("UQ__USUARIO__161CF7248DE61DEF")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("EMAIL")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Senha)
                    .IsRequired()
                    .HasColumnName("SENHA")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });
        }
    }
}
