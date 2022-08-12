using CourseProject.Models.DataLayer;
using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace CourseProject
{
    public partial class frmSong : Form
    {
        public Songs Song;
        MusicContext context = new MusicContext();
        public bool add;
        public frmSong()
        {
            InitializeComponent();
        }

        private void txtComments_TextChanged(object sender, EventArgs e)
        {

        }

        private void song_Load(object sender, EventArgs e)
        {
            //if modifying
            if (!add)
            {
                //set data
                dtpBDate.Value = Song.BbDate != null ? Convert.ToDateTime(Song.BbDate) : DateTime.MinValue.AddYears(1890);
                txtbbRank.Text = Song.BbRank != null ? Song.BbRank.ToString() : "";
                txtComments.Text = Song.Comments != null ? Song.Comments.ToString() : "";
                txtLength.Text = Song.Length.ToString();
                txtWriter.Text = Song.Writer.ToString();
                txtTitle.Text = Song.SongName.ToString();

                //get song artists
                var artistsIdList = context.ArtistsSongs
                        .Where(s => s.SongId == Song.SongId)
                        .Select(x => x.ArtistId).ToList();
                List<Artists> artists = context.Artists.ToList();

                //bind artists to listview
                lstArtists.DisplayMember = "BirthName";
                lstArtists.ValueMember = "ArtistId";
                lstArtists.DataSource = artists;

                //select songs current artists
                for (int i = 0; i < lstArtists.Items.Count; i++)
                {
                    lstArtists.SetSelected(0, false);
                    int id = ((Artists)lstArtists.Items[i]).ArtistId;
                    if (artistsIdList.Contains(id))
                    {
                        lstArtists.SetSelected(i, true);

                    }
                }

                //get albums and bind
                List<Albums> albums = context.Albums.ToList();
                lstAlbums.DisplayMember = "Title";
                lstAlbums.ValueMember = "AlbumId";
                lstAlbums.DataSource = albums;

                //select current album
                for (int i = 0; i < lstAlbums.Items.Count; i++)
                {
                    int id = ((Albums)lstAlbums.Items[i]).AlbumId;
                    if (Song.AlbumId == id)
                    {
                        lstAlbums.SetSelected(i, true);

                    }
                }

            }
            else
            {
                //do less
                btnModify.Text = "Add";
                List<Albums> albums = context.Albums.ToList();
                List<Artists> artists = context.Artists.ToList();

                //get artists and albums still
                lstArtists.DisplayMember = "BirthName";
                lstArtists.ValueMember = "ArtistId";
                lstArtists.DataSource = artists;

                lstAlbums.DisplayMember = "Title";
                lstAlbums.ValueMember = "AlbumId";
                lstAlbums.DataSource = albums;
            }
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            //if valid data
            if (ValidateForm())
            {
                List<int> artists = new List<int>();

                //if adding
                if (add)
                {
                    Songs addSong = new Songs();

                    //get data
                    addSong.SongName = txtTitle.Text;
                    addSong.Writer = txtWriter.Text;
                    addSong.Comments = txtComments.Text;
                    addSong.AlbumId = Convert.ToInt32(lstAlbums.SelectedValue);
                    addSong.Length = TimeSpan.Parse(txtLength.Text);

                    //control the controls
                    if (chkbb.Checked)
                    {
                        addSong.BbRank = Convert.ToInt32(txtbbRank.Text);
                        addSong.BbDate = Convert.ToDateTime(dtpBDate.Value);
                    }
                    else
                    {
                        addSong.BbRank = null;
                        addSong.BbDate = null;
                    }

                    //add to generate primary key
                    context.Songs.Add(addSong);
                    context.SaveChanges();

                    //handle relationship entities
                    foreach (int id in lstArtists.SelectedIndices)
                    {
                        int value = ((Artists)lstArtists.Items[id]).ArtistId;
                        artists.Add(value);
                    }
                    bool success = updateRelation(addSong.SongId, artists);
                    context.SaveChanges();

                    //something went wrong with relationship management
                    if (!success) { MessageBox.Show("Song " + Song.SongId.ToString() + "relationship update unnsuccessful"); }
                    else
                    {
                        this.Close();
                    }

                }
                else
                {
                    //update data
                    Songs modSong = Song;
                    modSong.SongName = txtTitle.Text;
                    modSong.Writer = txtWriter.Text;
                    modSong.Comments = txtComments.Text;
                    modSong.AlbumId = Convert.ToInt32(lstAlbums.SelectedValue);
                    modSong.Length = TimeSpan.Parse(txtLength.Text);


                    //control the controls
                    if (chkbb.Checked)
                    {
                        modSong.BbRank = Convert.ToInt32(txtbbRank.Text);
                        modSong.BbDate = Convert.ToDateTime(dtpBDate.Value);
                    }
                    else
                    {
                        modSong.BbRank = null;
                        modSong.BbDate = null;
                    }

                    context.Songs.Update(modSong);

                    //handle the relationship entitites
                    foreach (int id in lstArtists.SelectedIndices)
                    {
                        int value = ((Artists)lstArtists.Items[id]).ArtistId;
                        artists.Add(value);
                    }
                    bool success = updateRelation(modSong.SongId, artists);
                    context.SaveChanges();

                    //if something goes wrong
                    if (!success) { MessageBox.Show("Song " + Song.SongId.ToString() + "relationship update unnsuccessful"); }
                    else { this.Close(); }
                }
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void chkbb_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbb.Checked)
            {
                dtpBDate.Enabled = true;
                txtbbRank.Enabled = true;
            }
            else
            {
                dtpBDate.Enabled = false;
                txtbbRank.Enabled = false;
            }
        }
        /// <summary>
        /// function that updates relationships, deletes existing entities and adds new ones
        /// </summary>
        /// <param name="selectedId"></param>
        /// <param name="relationId"></param>
        /// <returns></returns>
        private bool updateRelation(int selectedId, List<int> relationId)
        {
            try
            {
                List<ArtistsSongs> artistsSongs = context.ArtistsSongs
                    .Where(x => x.SongId == selectedId)
                    .Select(x => new ArtistsSongs() { SongId = x.SongId, ArtistId = x.ArtistId }).ToList();
                for (int i = 0; i < artistsSongs.Count; i++)
                {
                    context.ArtistsSongs.Remove(artistsSongs[i]);
                }
                for (int i = 0; i < relationId.Count; i++)
                {
                    ArtistsSongs newRelation = new ArtistsSongs();
                    newRelation.SongId = selectedId;
                    newRelation.ArtistId = relationId[i];

                    context.ArtistsSongs.Add(newRelation);
                }
                context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        private bool ValidateForm()
        {
            string error = string.Empty;
            bool isValid = true;
            string title = txtTitle.Text;
            string writer = txtWriter.Text;
            string length = txtLength.Text;
            Regex rx = new Regex(@"^(?:(?:([01]?\d|2[0-3]):)?([0-5]?\d):)?([0-5]?\d)$");

            if (string.IsNullOrEmpty(title))
            {
                error += "You must enter a song title\n.";
                isValid = false;
            }
            if (string.IsNullOrEmpty(writer))
            {
                error += "You must enter a writer.\n";
                isValid = false;
            }
            if (string.IsNullOrEmpty(length))
            {
                error += "You must enter a length.\n";
                isValid = false;
            }
            else if (!rx.IsMatch(length))
            {
                error += "Enter song length in the format 'hh:mm:ss' please.\n";
                isValid = false;
            }
            if (lstAlbums.SelectedItem == null)
            {
                error += "Please select an album.\n";
                isValid = false;
            }
            if(lstArtists.SelectedItem == null)
            {
                error += "Please select one or more artists.\n";
                isValid = false;
            }
            if (!isValid)
            {
                MessageBox.Show(error, "Error");
            }
            return isValid;
        }

        private void btnAlbum_Click(object sender, EventArgs e)
        {
            Albums album = context.Albums.Where(x => x.AlbumId == Convert.ToInt32(Song.AlbumId)).FirstOrDefault();
            frmAlbum frmAlbum = new frmAlbum()
            {
                Album = album,
                add = false
            };
            this.Hide();

            DialogResult result = frmAlbum.ShowDialog();
        }
    }
}
