using System;

namespace CourseProject
{
    internal class AlbumPageSong
    {
        public AlbumPageSong()
        {
        }

        public int SongId { get; set; }
        public string SongName { get; set; }
        public TimeSpan Length { get; set; }
        public string Writer { get; set; }
        public int? BillBoardRank { get; internal set; }
    }
}