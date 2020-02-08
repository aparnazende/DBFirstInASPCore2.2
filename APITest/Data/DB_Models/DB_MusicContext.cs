using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Data.DB_Models
{
    public partial class DB_MusicContext : DbContext
    {
        public DB_MusicContext()
        {
        }

        public DB_MusicContext(DbContextOptions<DB_MusicContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TblMasterAlbum> TblMasterAlbum { get; set; }
        public virtual DbSet<TblMasterArtist> TblMasterArtist { get; set; }

        

        public virtual DbSet<TblMasterGenre> TblMasterGenre { get; set; }
        public virtual DbSet<TblSongs> TblSongs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=DESKTOP-4IVT239;initial catalog=DB_Music;persist security info=True;user id=sa;password=Admin@123;MultipleActiveResultSets=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity<TblMasterAlbum>(entity =>
            {
                entity.Property(e => e.Image).HasMaxLength(500);

                entity.Property(e => e.Name).HasMaxLength(200);

                entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<TblMasterArtist>(entity =>
            {
                entity.Property(e => e.Dob).HasColumnName("DOB");

                entity.Property(e => e.FirstName).HasMaxLength(150);

                entity.Property(e => e.LastName).HasMaxLength(10);
            });

            modelBuilder.Entity<TblMasterGenre>(entity =>
            {
                entity.Property(e => e.MusicType).HasMaxLength(200);
            });

            modelBuilder.Entity<TblSongs>(entity =>
            {
                entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.Album)
                    .WithMany(p => p.TblSongs)
                    .HasForeignKey(d => d.AlbumId)
                    .HasConstraintName("FK_TblSongs_TblSongs");

                entity.HasOne(d => d.Artist)
                    .WithMany(p => p.TblSongs)
                    .HasForeignKey(d => d.ArtistId)
                    .HasConstraintName("FK_TblSongs_TblMasterArtist");

                entity.HasOne(d => d.Genre)
                    .WithMany(p => p.TblSongs)
                    .HasForeignKey(d => d.GenreId)
                    .HasConstraintName("FK_TblSongs_TblGenre");
            });
        }
    }
}
