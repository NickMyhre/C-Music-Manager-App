using CourseProject.Models.DataLayer;
using Microsoft.Data.SqlClient;
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
    public partial class frmArtist : Form
    {
        public Artists Artist;
        MusicContext context = new MusicContext();
        private Songs song;
        public bool add;
        public frmArtist()
        {
            InitializeComponent();
        }

        private void frmArtist_Load(object sender, EventArgs e)
        {
            // if not adding a new entry, display all data from the artist object
            if (!add)
            {
                txtBirthName.Text = Artist.BirthName;
                txtFact.Text = Artist.Fact;
                txtHometown.Text = Artist.Hometown;
                txtStage.Text = Artist.StageName;

                dtpBirth.Value = Artist.Birth;
                dtpDeathDate.Value = Artist.Death != null ? Convert.ToDateTime(Artist.Death) : DateTime.MinValue.AddYears(1890);

                var songIds = context.ArtistsSongs.Where(s => s.ArtistId == Artist.ArtistId).Select(x => x.SongId).ToList();

                //display songs for the artist
                List<AlbumPageSong> list = new List<AlbumPageSong>();

                foreach (int id in songIds)
                {
                    AlbumPageSong song = context.Songs
                        .Where(x => x.SongId == id)
                        .OrderBy(x => x.SongName)
                        .Select(s => new AlbumPageSong() { SongId = s.SongId, SongName = s.SongName, Length = s.Length, Writer = s.Writer, BillBoardRank = s.BbRank }).FirstOrDefault();
                    list.Add(song);
                }

                //do datagridview stuff and make songs sortable
                var modifyColumn = new DataGridViewButtonColumn();
                SortableBindingList<AlbumPageSong> sbl = new SortableBindingList<AlbumPageSong>(list);
                dgvSongs.DataSource = sbl;
                dgvSongs.Columns[0].Visible = false;
                var viewColumn = new DataGridViewButtonColumn()
                {
                    UseColumnTextForButtonValue = true,
                    HeaderText = "",
                    Text = "View"
                }; 

                //dgv format stuff
                dgvSongs.Columns.Add(viewColumn);
                dgvSongs.Sort(dgvSongs.Columns[1], ListSortDirection.Ascending);

                dgvSongs.EnableHeadersVisualStyles = false;
                dgvSongs.AlternatingRowsDefaultCellStyle.BackColor = Color.SkyBlue;
                dgvSongs.RowsDefaultCellStyle.BackColor = Color.SlateGray;

                dgvSongs.Columns[1].Width = (int)(dgvSongs.Width * 0.3);
                dgvSongs.Columns[2].Width = (int)(dgvSongs.Width * 0.2);
                dgvSongs.Columns[3].Width = (int)(dgvSongs.Width * 0.3);
                dgvSongs.Columns[4].Width = (int)(dgvSongs.Width * 0.1);
                dgvSongs.Columns[5].Width = (int)(dgvSongs.Width * 0.1);

                dgvSongs.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                dgvSongs.Columns[1].HeaderText = "Song Name";
                dgvSongs.Columns[2].HeaderText = "Length";
                dgvSongs.Columns[3].HeaderText = "Writer";
                dgvSongs.Columns[4].HeaderText = "Rank";
            }
            //do the bare minimum
            else
            {
                dgvSongs.Hide();
                this.Height = 450;
                btnModify.Text = "Add";
            }
        }

        private void dgvSongs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            const int ViewIndex = 5;

            if (e.ColumnIndex == ViewIndex)
            {
                //select song and account for a user who doesn't know where to click
                try
                {
                    string songId = dgvSongs.Rows[e.RowIndex].Cells[0].Value.ToString();
                    song = context.Songs.Where(
                        x => x.SongId == Convert.ToInt32(songId)).FirstOrDefault();
                }
                catch (Exception ex) { return; }
            }

            if (e.ColumnIndex == ViewIndex)
            {

                ViewSong();
            }
        }

        private void ViewSong()
        {
            this.Hide();
            frmSong frmSong = new frmSong()
            {
                Song = song
            };
            DialogResult result = frmSong.ShowDialog();

        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                try
                {
                    //if adding a new entry
                    if (add)
                    {
                        //get data from controls
                        Artists AddArt = new Artists();
                        AddArt.BirthName = txtBirthName.Text.ToString();
                        AddArt.Hometown = txtHometown.Text.ToString();
                        AddArt.Fact = txtFact.Text.ToString();
                        AddArt.Birth = Convert.ToDateTime(dtpBirth.Value);

                        if (chkAlive.Checked)
                        {

                            AddArt.Death = null;
                        }
                        else
                        {
                            AddArt.Death = dtpDeathDate.Value;
                        }

                        //add to db and do UI stuff
                        context.Artists.Add(AddArt);

                        context.SaveChanges();
                        this.DialogResult = DialogResult.OK;
                        this.Close();

                    }
                    else
                    {
                        //update artists object
                        Artists ModArt = Artist;
                        ModArt.BirthName = txtBirthName.Text.ToString();
                        ModArt.Hometown = txtHometown.Text.ToString();
                        ModArt.Fact = txtFact.Text.ToString();
                        ModArt.Birth = Convert.ToDateTime(dtpBirth.Value);

                        if (chkAlive.Checked)
                        {

                            ModArt.Death = null;
                        }
                        else
                        {
                            ModArt.Death = dtpDeathDate.Value;
                        }


                        context.Artists.Update(ModArt);

                        context.SaveChanges();
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }

                }

                catch (SqlException x)
                {
                    var errorMsg = String.Empty;
                    var sqlException = (SqlException)x.InnerException;
                    foreach (SqlError error in sqlException.Errors)
                    { errorMsg += error.Message + error.Number; }
                    MessageBox.Show(errorMsg);
                }
                catch (Exception x)
                { MessageBox.Show(x.Message); }
            }
        }

        private void chkAlive_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAlive.Checked)
            {

                dtpDeathDate.Enabled = false;
            }
            else
            {
                dtpDeathDate.Enabled = true;
            }
        }

        private bool ValidateForm()
        {
            bool isValid = true;
            string error = string.Empty;


            string name = txtBirthName.Text;
            string fact  = txtFact.Text;
            string home = txtHometown.Text;
            DateTime birth = dtpBirth.Value;
            DateTime death = dtpDeathDate.Value;

            if (string.IsNullOrEmpty(name))
            {
                error += "Enter a name.\n";
                isValid = false;
            }
            if (string.IsNullOrEmpty(fact))
            {
                error = "Please enter a fact. \n";
                isValid = false;
            }
            if (string.IsNullOrEmpty(home))
            {
                error += "Please enter a hometown.\n";
                isValid = false;
            }
            if (birth > DateTime.Now)
            {
                error += "how do you know the artist is going to born in the future?\n";
                isValid = false;
            }
            if (birth > death)
            {
                error += "how exactly does one get born after they die?\n";
                isValid = false;
            }
            if(!isValid) { MessageBox.Show(error, "Error"); }
            return isValid;
        }
    }
    }

