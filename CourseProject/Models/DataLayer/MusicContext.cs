using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace CourseProject.Models.DataLayer
{
    public partial class MusicContext : DbContext
    {
        public MusicContext()
        {
        }

        public MusicContext(DbContextOptions<MusicContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Albums> Albums { get; set; }
        public virtual DbSet<AlbumsArtists> AlbumsArtists { get; set; }
        public virtual DbSet<Artists> Artists { get; set; }
        public virtual DbSet<ArtistsSongs> ArtistsSongs { get; set; }
        public virtual DbSet<Songs> Songs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=(LocalDB)\\MSSQLLocalDB; AttachDBFilename=C:\\Users\\Nickm\\music.mdf;Integrated security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Albums>(entity =>
            {
                entity.HasKey(e => e.AlbumId)
                    .HasName("PK__albums__75BF3EEF78CAEFD1");

                entity.Property(e => e.AlbumId).ValueGeneratedOnAdd();

                entity.Property(e => e.Fact).IsUnicode(false);

                entity.Property(e => e.Genre).IsUnicode(false);

                entity.Property(e => e.Label).IsUnicode(false);

                entity.Property(e => e.Title).IsUnicode(false);
            });

            modelBuilder.Entity<AlbumsArtists>(entity =>
            {
                entity.HasKey(e => new { e.AlbumId, e.ArtistId })
                    .HasName("PK__albums_a__114B07D926BDBDA5");

                entity.HasOne(d => d.Album)
                    .WithMany(p => p.AlbumsArtists)
                    .HasForeignKey(d => d.AlbumId)
                    .HasConstraintName("albumID_fk");

                entity.HasOne(d => d.Artist)
                    .WithMany(p => p.AlbumsArtists)
                    .HasForeignKey(d => d.ArtistId)
                    .HasConstraintName("artistID_fk");
            });

            modelBuilder.Entity<Artists>(entity =>
            {
                entity.HasKey(e => e.ArtistId)
                    .HasName("PK__artists__4F439367C959E4A2");

                entity.Property(e => e.ArtistId).ValueGeneratedOnAdd();

                entity.Property(e => e.BirthName).IsUnicode(false);

                entity.Property(e => e.Fact).IsUnicode(false);

                entity.Property(e => e.Hometown).IsUnicode(false);

                entity.Property(e => e.StageName).IsUnicode(false);
            });

            modelBuilder.Entity<ArtistsSongs>(entity =>
            {
                entity.HasKey(e => new { e.ArtistId, e.SongId })
                    .HasName("PK__artists___8F75DE0DD3AC7F8E");

                entity.HasOne(d => d.Artist)
                    .WithMany(p => p.ArtistsSongs)
                    .HasForeignKey(d => d.ArtistId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("artistID");

                entity.HasOne(d => d.Song)
                    .WithMany(p => p.ArtistsSongs)
                    .HasForeignKey(d => d.SongId)
                    .HasConstraintName("songID");
            });

            modelBuilder.Entity<Songs>(entity =>
            {
                entity.HasKey(e => e.SongId)
                    .HasName("PK__songs__0364D6ADE599DDE9");

                entity.Property(e => e.SongId).ValueGeneratedOnAdd();

                entity.Property(e => e.Comments).IsUnicode(false);

                entity.Property(e => e.SongName).IsUnicode(false);

                entity.Property(e => e.Writer).IsUnicode(false);

                entity.HasOne(d => d.Album)
                    .WithMany(p => p.Songs)
                    .HasForeignKey(d => d.AlbumId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("albumID");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
