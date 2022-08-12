using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CourseProject.Models.DataLayer
{
    [Table("artists_songs")]
    public partial class ArtistsSongs
    {
        [Key]
        [Column("artistID")]
        public int ArtistId { get; set; }
        [Key]
        [Column("songID")]
        public int SongId { get; set; }

        [ForeignKey(nameof(ArtistId))]
        [InverseProperty(nameof(Artists.ArtistsSongs))]
        public virtual Artists Artist { get; set; }
        [ForeignKey(nameof(SongId))]
        [InverseProperty(nameof(Songs.ArtistsSongs))]
        public virtual Songs Song { get; set; }
    }
}
