using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CourseProject.Models.DataLayer
{
    [Table("artists")]
    public partial class Artists
    {
        public Artists()
        {
            AlbumsArtists = new HashSet<AlbumsArtists>();
            ArtistsSongs = new HashSet<ArtistsSongs>();
        }

        [Key]
        
        [Column("artistID")]
        public int ArtistId { get; set; }
        [Column("stageName")]
        [StringLength(45)]
        public string StageName { get; set; }
        [Required]
        [Column("birthName")]
        [StringLength(45)]
        public string BirthName { get; set; }
        [Column("hometown")]
        [StringLength(45)]
        public string Hometown { get; set; }
        [Column("birth", TypeName = "datetime")]
        public DateTime Birth { get; set; }
        [Column("death", TypeName = "datetime")]
        public DateTime? Death { get; set; }
        [Required]
        [Column("fact")]
        [StringLength(45)]
        public string Fact { get; set; }

        [InverseProperty("Artist")]
        public virtual ICollection<AlbumsArtists> AlbumsArtists { get; set; }
        [InverseProperty("Artist")]
        public virtual ICollection<ArtistsSongs> ArtistsSongs { get; set; }
    }
}
