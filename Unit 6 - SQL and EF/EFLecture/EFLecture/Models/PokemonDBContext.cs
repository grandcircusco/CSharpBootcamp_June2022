using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace EFLecture.Models
{
    public partial class PokemonDBContext : DbContext
    {
        public PokemonDBContext()
        {
        }

        public PokemonDBContext(DbContextOptions<PokemonDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Pokemon> Pokemons { get; set; } = null!;
        public virtual DbSet<Trainer> Trainers { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=.\\sqlexpress;Initial Catalog=PokemonDB; Integrated Security=SSPI;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pokemon>(entity =>
            {
                entity.ToTable("Pokemon");

                entity.Property(e => e.MainType).HasMaxLength(255);

                entity.Property(e => e.Name).HasMaxLength(255);

                entity.Property(e => e.SecondType).HasMaxLength(255);
            });

            modelBuilder.Entity<Trainer>(entity =>
            {
                entity.ToTable("Trainer");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.FavPokemonId).HasColumnName("FavPokemonID");

                entity.Property(e => e.Name).HasMaxLength(255);

                entity.HasOne(d => d.FavPokemon)
                    .WithMany(p => p.Trainers)
                    .HasForeignKey(d => d.FavPokemonId)
                    .HasConstraintName("FK__Trainer__FavPoke__267ABA7A");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
