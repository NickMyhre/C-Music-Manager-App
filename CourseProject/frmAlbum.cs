using CourseProject.Models.DataLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CourseProject
{
    public partial class frmAlbum : Form
    {
        public Albums Album;
        MusicContext context = new MusicContext();
        public bool add;
        public frmAlbum()
        {
            InitializeComponent();
        }

        private void frmAlbum_Load(object sender, EventArgs e)
        {
            dgvSongs.EnableHeadersVisualStyles = false;
            dgvSongs.AlternatingRowsDefaultCellStyle.BackColor = Color.SkyBlue;
            dgvSongs.RowsDefaultCellStyle.BackColor = Color.SlateGray;
            //if not adding
            if (!add)
            {
                //set data
                txtTitle.Text = Album.Title;
                txtGenre.Text = Album.Genre;
                txtFact.Text = Album.Fact;
                txtLabel.Text = Album.Label;
                dtpRelDate.Value = Album.ReleaseDate != null ? Convert.ToDateTime(Album.ReleaseDate) : DateTime.MinValue.AddYears(1890);

                //get album songs
                List<AlbumPageSong> list = context.Songs
                    .Where(x => x.AlbumId == Album.AlbumId)
                    .OrderBy(x => x.SongName)
                    .Select(s => new AlbumPageSong() { SongId = s.SongId, SongName = s.SongName, Length = s.Length, Writer = s.Writer, BillBoardRank = s.BbRank }).ToList();


                //get artists and display them
                var artistsIdList = context.AlbumsArtists
                        .Where(s => s.AlbumId == Album.AlbumId)
                        .Select(x => x.ArtistId).ToList();
                List<Artists> artists = context.Artists.ToList();
                lstArtists.DisplayMember = "BirthName";
                lstArtists.ValueMember = "ArtistId";
                lstArtists.DataSource = artists;

                //if they are the albums current artists select them
                for (int i = 0; i < lstArtists.Items.Count; i++)
                {
                    lstArtists.SetSelected(0, false);
                    int id = ((Artists)lstArtists.Items[i]).ArtistId;
                    if (artistsIdList.Contains(id))
                    {
                        lstArtists.SetSelected(i, true);

                    }
                }

                //bind and sort songs
                SortableBindingList<AlbumPageSong> sblList = new SortableBindingList<AlbumPageSong>(list);
                dgvSongs.DataSource = sblList;
                dgvSongs.Columns[0].Visible = false;
                dgvSongs.Sort(dgvSongs.Columns[1], ListSortDirection.Ascending);

                //format stuff
                dgvSongs.Columns[1].Width = (int)(dgvSongs.Width * 0.3);
                dgvSongs.Columns[2].Width = (int)(dgvSongs.Width * 0.2);
                dgvSongs.Columns[3].Width = (int)(dgvSongs.Width * 0.3);
                dgvSongs.Columns[4].Width = (int)(dgvSongs.Width * 0.2);

                dgvSongs.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                dgvSongs.Columns[1].HeaderText = "Song Name";
                dgvSongs.Columns[2].HeaderText = "Length";
                dgvSongs.Columns[3].HeaderText = "Writer";
                dgvSongs.Columns[4].HeaderText = "Rank";
            }
            else
            {
                //do less 
                dgvSongs.Hide();
                this.Height = 450;
                btnModify.Text = "Add";

                //still get the artists though
                List<Artists> artists = context.Artists.ToList();
                lstArtists.DisplayMember = "BirthName";
                lstArtists.ValueMember = "ArtistId";
                lstArtists.DataSource = artists;
            }
        }


        private void dgvSongs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            //if valid
            if (ValidateForm())
            {
                //if adding
                if (add)
                {
                    
                    Albums addAlb = new Albums();
                    List<int> artists = new List<int>();

                    //get data
                    addAlb.Title = txtTitle.Text;
                    addAlb.Label = txtLabel.Text;
                    addAlb.Fact = txtFact.Text;
                    addAlb.Genre = txtGenre.Text;
                    addAlb.ReleaseDate = dtpRelDate.Value;

                    //update DB to generate primary key
                    context.Albums.Add(addAlb);
                    context.SaveChanges();

                    //handle relationship entities and update
                    foreach (int id in lstArtists.SelectedIndices)
                    {
                        int value = ((Artists)lstArtists.Items[id]).ArtistId;
                        artists.Add(value);
                    }
                    bool success = updateRelation(addAlb.AlbumId, artists);
                    context.SaveChanges();

                    if (!success) { MessageBox.Show("Album " + addAlb.AlbumId.ToString() + "relationship update unnsuccessful"); }
                    else
                    {
                        this.Close();
                    }
                }
                else
                {
                    Albums modAlb = Album;
                    List<int> artists = new List<int>();

                    //update data
                    modAlb.Title = txtTitle.Text;
                    modAlb.Label = txtLabel.Text;
                    modAlb.Fact = txtFact.Text;
                    modAlb.Genre = txtGenre.Text;
                    modAlb.ReleaseDate = dtpRelDate.Value;

                    context.Albums.Update(modAlb);

                    //handle relationship entities
                    foreach (int id in lstArtists.SelectedIndices)
                    {
                        int value = ((Artists)lstArtists.Items[id]).ArtistId;
                        artists.Add(value);
                    }
                    bool success = updateRelation(modAlb.AlbumId, artists);
                    context.SaveChanges();

                    if (!success) { MessageBox.Show("Album " + modAlb.AlbumId.ToString() + "relationship update unnsuccessful"); }
                    else
                    {
                        this.Close();
                    }
                }
            }
        }
        /// <summary>
        /// Function to handle album relationship entities, deletes existing relationships then adds updated ones
        /// </summary>
        /// <param name="selectedId"></param>
        /// <param name="relationId"></param>
        /// <returns></returns>
        private bool updateRelation(int selectedId, List<int> relationId)
        {
            try
            {
                List<AlbumsArtists> albumsArtists = context.AlbumsArtists
                    .Where(x => x.AlbumId == selectedId)
                    .Select(x => new AlbumsArtists() { AlbumId = x.AlbumId, ArtistId = x.ArtistId }).ToList();
                for (int i = 0; i < albumsArtists.Count; i++)
                {
                    context.AlbumsArtists.Remove(albumsArtists[i]);
                }
                for (int i = 0; i < relationId.Count; i++)
                {
                    AlbumsArtists newRelation = new AlbumsArtists();
                    newRelation.AlbumId = selectedId;
                    newRelation.ArtistId = relationId[i];

                    context.AlbumsArtists.Add(newRelation);
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
            bool isValid = true;
            string title = txtTitle.Text;
            string label = txtLabel.Text;
            string fact = txtFact.Text;
            string Genre = txtGenre.Text;

            string error = String.Empty;

            if (string.IsNullOrEmpty(title))
            {
                error += "Please enter a value for title.\n";
                isValid =  false;
            }
            if (string.IsNullOrEmpty(label))
            {
                error += "Please enter a label\n";
                isValid = false;
            }
            if (string.IsNullOrEmpty(fact))
            {
                error += "Please enter a fact\n";
                isValid = false;
            }
            if (string.IsNullOrEmpty(Genre))
            {
                error += "Please enter a genre\n";
                isValid = false;
            }
            if(lstArtists.SelectedItem.Equals(null))
            {
                error += "You must select an artist.\n";
                isValid = false;
            }
            if (!isValid) { MessageBox.Show(error, "Error"); }
            return isValid;
        }
    }
}
