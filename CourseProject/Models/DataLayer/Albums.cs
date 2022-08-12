using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CourseProject.Models.DataLayer
{
    [Table("albums")]
    public partial class Albums
    {
        public Albums()
        {
            AlbumsArtists = new HashSet<AlbumsArtists>();
            Songs = new HashSet<Songs>();
        }

        [Key]
        [Column("albumID")]
        public int AlbumId { get; set; }
        [Required]
        [Column("title")]
        [StringLength(255)]
        public string Title { get; set; }
        [Required]
        [Column("label")]
        [StringLength(45)]
        public string Label { get; set; }
        [Required]
        [Column("genre")]
        [StringLength(45)]
        public string Genre { get; set; }
        [Column("releaseDate", TypeName = "datetime")]
        public DateTime ReleaseDate { get; set; }
        [Column("fact")]
        [StringLength(255)]
        public string Fact { get; set; }

        [InverseProperty("Album")]
        public virtual ICollection<AlbumsArtists> AlbumsArtists { get; set; }
        [InverseProperty("Album")]
        public virtual ICollection<Songs> Songs { get; set; }
    }
}
