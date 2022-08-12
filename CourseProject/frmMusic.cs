using AutoMapper;
using CourseProject.Models.DataLayer;
using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseProject
{
    public partial class frmMusic : Form
    {
        new char[] space = new char[] { ' ' };
        new char[] comma = new char[] { ',' };
        public MusicContext context = new MusicContext();
        Songs selectedSong = new Songs();
        Artists selectedArtist = new Artists();
        Albums selectedAlbum = new Albums();

        bool displayArtists;
        bool displayAlbums;
        bool displaySongs;

        public frmMusic()
        {
            InitializeComponent();
        }

        private void btnAllArtist_Click(object sender, EventArgs e)
        {
            //clear pre-existing entities
            dgvAllEntity.Columns.Clear();

            //get song count
            var songCount = context.Artists
                .Join(context.ArtistsSongs,
                a => a.ArtistId,
                i => i.ArtistId,
                (a, i) => new { a.ArtistId })
                .GroupBy(a => a.ArtistId)
                .Select(a => new { ArtistId = a.Key, SongCount = a.Count() });

            //create artist list with song count
            List<ArtistList> list = context.Artists
                .GroupJoin(songCount,
                a => a.ArtistId,
                i => i.ArtistId,
                (a, i) => new { a, i }
                ).SelectMany(
                x => x.i.DefaultIfEmpty(),
                 (a, i) => new ArtistList { ArtistId = Convert.ToInt32(a.a.ArtistId), LastName = a.a.BirthName.Split(space).Last(), Age = a.a.Death.HasValue ? (Convert.ToDateTime(a.a.Death).Year - a.a.Birth.Year) : (DateTime.Now.Year - a.a.Birth.Year), SongCount = i.SongCount }).ToList();


            //make list sortable and bind
            dgvAllEntity.DataSource = null;
            SortableBindingList<ArtistList> sblList = new SortableBindingList<ArtistList>(list);
            dgvAllEntity.DataSource = sblList;

            //formatting
            dgvAllEntity.Columns[0].Visible = false;
            RefreshDGVColumns(1);

            dgvAllEntity.Columns[1].Width = (int)(dgvAllEntity.Width * 0.4);
            dgvAllEntity.Columns[2].Width = (int)(dgvAllEntity.Width * 0.3);
            dgvAllEntity.Columns[3].Width = (int)(dgvAllEntity.Width * 0.1);
            dgvAllEntity.Columns[4].Width = (int)(dgvAllEntity.Width * 0.1);
            dgvAllEntity.Columns[5].Width = (int)(dgvAllEntity.Width * 0.1);

            dgvAllEntity.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dgvAllEntity.Columns[1].HeaderText = "Last Name";
            dgvAllEntity.Columns[3].HeaderText = "Song Count";
        }

        private void btnAllAlbum_Click(object sender, EventArgs e)
        {
            //clear pre-existing entities
            dgvAllEntity.Columns.Clear();

            //get album artist info
            var albumArtists = context.Artists
                .Join(context.AlbumsArtists,
                a => a.ArtistId,
                i => i.ArtistId,
                (a, i) => new
                {
                    AlbumId = i.AlbumId,
                    name = String.Join(", ", context.Artists.Where(n => n.ArtistId == i.ArtistId).Select(bn => bn.BirthName.ToString()).Distinct())
                })
                .Select(a => new { AlbumId = a.AlbumId, artists = a.name });

            //get list of albums
            List<AlbumList> list = context.Albums
                .Join(albumArtists,
                a => a.AlbumId,
                i => i.AlbumId,
                (a, i) => new { AlbumId = a.AlbumId, Title = a.Title, artists = Convert.ToString(i.artists).Split(comma).Count() > 2 ? "various" : i.artists, genre = a.Genre, label = a.Label, ReleaseDate = a.ReleaseDate })
                .Select(x => new AlbumList { AlbumId = x.AlbumId, Title = x.Title, artists = x.artists, genre = x.genre, label = x.label, ReleaseDate = x.ReleaseDate }).ToList();

            //bind and sort
            dgvAllEntity.DataSource = null;
            SortableBindingList<AlbumList> sblList = new SortableBindingList<AlbumList>(list);
            dgvAllEntity.DataSource = sblList;

            //format
            dgvAllEntity.Columns[0].Visible = false;
            RefreshDGVColumns(2);

            dgvAllEntity.Columns[1].Width = (int)(dgvAllEntity.Width * 0.3);
            dgvAllEntity.Columns[2].Width = (int)(dgvAllEntity.Width * 0.2);
            dgvAllEntity.Columns[3].Width = (int)(dgvAllEntity.Width * 0.1);
            dgvAllEntity.Columns[4].Width = (int)(dgvAllEntity.Width * 0.1);
            dgvAllEntity.Columns[5].Width = (int)(dgvAllEntity.Width * 0.1);
            dgvAllEntity.Columns[6].Width = (int)(dgvAllEntity.Width * 0.1);
            dgvAllEntity.Columns[7].Width = (int)(dgvAllEntity.Width * 0.1);

            dgvAllEntity.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dgvAllEntity.Columns[2].HeaderText = "Artists";
            dgvAllEntity.Columns[3].HeaderText = "Genre";
            dgvAllEntity.Columns[4].HeaderText = "Label";
            dgvAllEntity.Columns[5].HeaderText = "Release";
        }

        private void btnAllSong_Click(object sender, EventArgs e)
        {
            //clear entities
            dgvAllEntity.Columns.Clear();


            //list of songs
            List<SongDGV> list = context.Songs
                .Join(context.Albums,
                s => s.AlbumId,
                a => a.AlbumId,
                (s, a) => new SongDGV() { SongId = s.SongId, SongName = s.SongName, AlbumTitle = a.Title, Writer = s.Writer })
                .OrderBy(s => s.SongName).ToList();

            //bind and sort
            SortableBindingList<SongDGV> sblList = new SortableBindingList<SongDGV>(list);
            dgvAllEntity.DataSource = sblList;

            //format
            dgvAllEntity.Columns[0].Visible = false;
            RefreshDGVColumns(3);

            dgvAllEntity.Columns[1].Width = (int)(dgvAllEntity.Width * 0.4);
            dgvAllEntity.Columns[2].Width = (int)(dgvAllEntity.Width * 0.2);
            dgvAllEntity.Columns[3].Width = (int)(dgvAllEntity.Width * 0.2);
            dgvAllEntity.Columns[4].Width = (int)(dgvAllEntity.Width * 0.1);
            dgvAllEntity.Columns[5].Width = (int)(dgvAllEntity.Width * 0.1);

            dgvAllEntity.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dgvAllEntity.Columns[1].HeaderText = "Song Name";
            dgvAllEntity.Columns[2].HeaderText = "Album";
            dgvAllEntity.Columns[3].HeaderText = "Writer";

        }

        private void frmMusic_Load(object sender, EventArgs e)
        {
            dgvAllEntity.EnableHeadersVisualStyles = false;
            dgvAllEntity.AlternatingRowsDefaultCellStyle.BackColor = Color.SkyBlue;
            dgvAllEntity.RowsDefaultCellStyle.BackColor = Color.SlateGray;

            btnAllSong.PerformClick();
        }

        private void RefreshDGVColumns(int buttonNo)
        {
            //track displayed data
            switch (buttonNo)
            {
                case 1:
                    displayArtists = true;
                    displayAlbums = false;
                    displaySongs = false;
                    break;
                case 2:
                    displayArtists = false;
                    displayAlbums = true;
                    displaySongs = false;
                    break;
                case 3:
                    displayArtists = false;
                    displayAlbums = false;
                    displaySongs = true;
                    break;
                default:
                    break;
            }
            //re-add columns
            var viewColumn = new DataGridViewButtonColumn()
            {
                UseColumnTextForButtonValue = true,
                HeaderText = "",
                Text = "View"
            };
            dgvAllEntity.Columns.Add(viewColumn);
            var deleteColumn = new DataGridViewButtonColumn()
            {
                UseColumnTextForButtonValue = true,
                HeaderText = "",
                Text = "Delete"
            };
            dgvAllEntity.Columns.Add(deleteColumn);
            dgvAllEntity.AutoResizeColumns();
        }

        private void dgvAllEntity_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //handle album actions when displayed
            if (displayAlbums)
            {
                const int ViewIndex = 6;
                const int DeleteIndex = 7;

                if (e.ColumnIndex == ViewIndex || e.ColumnIndex == DeleteIndex)
                {
                    try
                    {
                        string albumId = dgvAllEntity.Rows[e.RowIndex].Cells[0].Value.ToString();
                        selectedAlbum = context.Albums.Where(
                            x => x.AlbumId == Convert.ToInt32(albumId)).FirstOrDefault();
                    }
                    catch (Exception ex) { return; }
                }

                if (e.ColumnIndex == ViewIndex)
                {
                    ViewAlbum();
                }
                else if (e.ColumnIndex == DeleteIndex)
                {
                    DeleteAlbum();
                }
            }

            //handle artist actions when displayed
            else if (displayArtists)
            {
                const int ViewIndex = 4;
                const int DeleteIndex = 5;

                if (e.ColumnIndex == ViewIndex || e.ColumnIndex == DeleteIndex)
                {
                    try
                    {
                        string artistId = dgvAllEntity.Rows[e.RowIndex].Cells[0].Value.ToString().Trim();
                        selectedArtist = context.Artists.Where(
                            x => x.ArtistId == Convert.ToInt32(artistId)).First();
                    }
                    catch (Exception ex) { return; }
                }

                if (e.ColumnIndex == ViewIndex)
                {
                    ViewArtist();
                }
                else if (e.ColumnIndex == DeleteIndex)
                {
                    DeleteArtist();
                }
            }

            //handle song actions when displayed
            else if (displaySongs)
            {
                const int ViewIndex = 4;
                const int DeleteIndex = 5;

                if (e.ColumnIndex == ViewIndex || e.ColumnIndex == DeleteIndex)
                {
                    try
                    {
                        string songId = dgvAllEntity.Rows[e.RowIndex].Cells[0].Value.ToString().Trim();
                        selectedSong = context.Songs
                            .Where(x => x.SongId == Convert.ToInt32(songId)).FirstOrDefault();
                    }
                    catch (Exception ex)
                    { return; }
                }

                if (e.ColumnIndex == ViewIndex)
                {
                    ViewSong();
                }
                else if (e.ColumnIndex == DeleteIndex)
                {
                    DeleteSong();
                }

            }

            //account for the apocalypse
            else
            {
                MessageBox.Show("you really messed up to get this to pop up");
            }
        }

        private void DeleteArtist()
        {
            var songs = context.ArtistsSongs
                .Where(x => x.ArtistId == selectedArtist.ArtistId).ToList();
            var albums = context.AlbumsArtists
                .Where(x => x.ArtistId == selectedArtist.ArtistId).ToList();
            if (songs.Count > 0 || albums.Count > 0)
            { MessageBox.Show("You can't delete an artist with songs or albums", "Error"); }
            else
            {
                context.Artists.Remove(selectedArtist);
                context.SaveChanges();
                btnAllArtist.PerformClick();
            }
        }

        private void ViewArtist()
        {
            var frmArtist = new frmArtist()
            {
                Artist = selectedArtist,
                add = false
            };
            DialogResult result = frmArtist.ShowDialog();
            btnAllArtist.PerformClick();
        }

        private void DeleteAlbum()
        {
            DialogResult result = MessageBox.Show("Are you sure? This could delete a lot of data.", "Careful!", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                List<Songs> list = context.Songs
                    .Where(x => x.AlbumId == selectedAlbum.AlbumId)
                    .Select(s => new Songs() { SongId = s.SongId, SongName = s.SongName, AlbumId = s.AlbumId, Writer = s.Writer, BbDate = s.BbDate, BbRank = s.BbRank }).ToList();
                

                //Remove songs
                for(int i = 0; i < list.Count; i++)
                {
                    context.Remove(list[i]);
                    removeRelation("song", list[i].SongId);
                }

                //update database
                context.SaveChanges();

                //get album artist ID's
                var artists = context.AlbumsArtists
                    .Where(x => x.AlbumId == selectedAlbum.AlbumId)
                    .Select(a => new { ArtistId = a.ArtistId }).ToList();

                //find out if album has songs---will not be included if there are no songs
                var songCount = context.Artists
                    .Join(context.ArtistsSongs,
                     a => a.ArtistId,
                     i => i.ArtistId,
                       (a, i) => new { a.ArtistId })
                    .GroupBy(a => a.ArtistId)
                    .Select(a => new { ArtistId = a.Key, SongCount = a.Count() });

                //make list of artists that still have songs
                var delartists = artists
                    .Join(songCount,
                    x => x.ArtistId,
                    i => i.ArtistId,
                    (x, i) => new { ArtistId = x.ArtistId }).ToList();

                //foreach album artist
                for (int i = 0; i < artists.Count; i++)
                {
                    //if the artist isn't present in the list of artists that still have songs
                    if (!delartists.Contains(artists[i]))
                    {
                        //create artist object and delete from DB
                        Artists art = context.Artists.Where(x => x.ArtistId == artists[i].ArtistId).First();
                        context.Remove(art);
                    }

                }

                //update DB
                context.Remove(selectedAlbum);
                removeRelation("album", selectedAlbum.AlbumId);

                context.SaveChanges();
                btnAllAlbum.PerformClick();
                
            }
        }
        #region
        /// <summary>
        /// Functions for forms and sets properties depending on the data passed to them
        /// </summary>
        private void ViewAlbum()
        {
            var frmAlbum = new frmAlbum()
            {
                Album = selectedAlbum,
                add = false
            };
            DialogResult result = frmAlbum.ShowDialog();
            btnAllAlbum.PerformClick();
        }

        private void ViewSong()
        {
            frmSong frmSong = new frmSong()
            {
                Song = selectedSong,
                add = false
            };

            DialogResult result = frmSong.ShowDialog();
            btnAllSong.PerformClick();
        }

        private void DeleteSong()
        {
            context.Songs.Remove(selectedSong);
            bool success = removeRelation("song", selectedSong.SongId);
            if (success)
            { 
                context.SaveChanges();
                btnAllSong.PerformClick(); 
            }
        }

        private void dgvAllEntity_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {


        }

        private void btnAddArt_Click(object sender, EventArgs e)
        {
            var frmArtist = new frmArtist()
            {
                Artist = selectedArtist,
                add = true
            };
            DialogResult result = frmArtist.ShowDialog();
            btnAllArtist.PerformClick();
        }

        private void btnAddAlb_Click(object sender, EventArgs e)
        {
            var frmAlbum = new frmAlbum()
            {
                Album = selectedAlbum,
                add = true
            };
            DialogResult result = frmAlbum.ShowDialog();
            btnAllAlbum.PerformClick();
        }

        private void btnAddSong_Click(object sender, EventArgs e)
        {
            frmSong frmSong = new frmSong()
            {
                Song = selectedSong,
                add = true
            };

            DialogResult result = frmSong.ShowDialog();
            btnAllSong.PerformClick();
        }
        #endregion
        /// <summary>
        /// function to handle relationship entities 
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        private bool removeRelation(string entity, int id)
        {

            if (entity == "song")
            {
                List<ArtistsSongs> relations = context.ArtistsSongs
                    .Where(x => x.SongId == id)
                    .Select(x => new ArtistsSongs() { SongId = x.SongId, ArtistId = x.ArtistId }).ToList();
                for (int i = 0; i < relations.Count; i++)
                {
                    context.ArtistsSongs.Remove(relations[i]);
                }
                return true;
            }
            else if (entity == "album")
            {
                List<AlbumsArtists> relations = context.AlbumsArtists
                    .Where(x => x.AlbumId == id)
                    .Select(x => new AlbumsArtists() { AlbumId = x.AlbumId, ArtistId = x.ArtistId }).ToList();
                for (int i = 0; i < relations.Count; i++)
                {
                    context.AlbumsArtists.Remove(relations[i]);
                }
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
