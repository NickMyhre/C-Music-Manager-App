using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CourseProject.Models.DataLayer
{
    [Table("albums_artists")]
    public partial class AlbumsArtists
    {
        [Key]
        [Column("albumID")]
        public int AlbumId { get; set; }
        [Key]
        [Column("artistID")]
        public int ArtistId { get; set; }

        [ForeignKey(nameof(AlbumId))]
        [InverseProperty(nameof(Albums.AlbumsArtists))]
        public virtual Albums Album { get; set; }
        [ForeignKey(nameof(ArtistId))]
        [InverseProperty(nameof(Artists.AlbumsArtists))]
        public virtual Artists Artist { get; set; }
    }
}
