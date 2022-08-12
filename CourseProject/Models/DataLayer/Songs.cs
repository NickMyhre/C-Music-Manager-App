using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CourseProject.Models.DataLayer
{
    [Table("songs")]
    public partial class Songs
    {
        public Songs()
        {
            ArtistsSongs = new HashSet<ArtistsSongs>();
        }

        [Key]
        [Column("songID")]
        public int SongId { get; set; }
        [Required]
        [Column("songName")]
        [StringLength(75)]
        public string SongName { get; set; }
        [Column("length")]
        public TimeSpan Length { get; set; }
        [Column("comments")]
        [StringLength(45)]
        public string Comments { get; set; }
        [Column("bbRank")]
        public int? BbRank { get; set; }
        [Column("bbDate", TypeName = "datetime")]
        public DateTime? BbDate { get; set; }
        [Required]
        [Column("writer")]
        [StringLength(45)]
        public string Writer { get; set; }
        [Column("albumID")]
        public int? AlbumId { get; set; }

        [ForeignKey(nameof(AlbumId))]
        [InverseProperty(nameof(Albums.Songs))]
        public virtual Albums Album { get; set; }
        [InverseProperty("Song")]
        public virtual ICollection<ArtistsSongs> ArtistsSongs { get; set; }
    }
}
