namespace CourseProject
{
    partial class frmMusic
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAllArtist = new System.Windows.Forms.Button();
            this.btnAllAlbum = new System.Windows.Forms.Button();
            this.btnAllSong = new System.Windows.Forms.Button();
            this.dgvAllEntity = new System.Windows.Forms.DataGridView();
            this.btnAddArt = new System.Windows.Forms.Button();
            this.btnAddAlb = new System.Windows.Forms.Button();
            this.btnAddSong = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllEntity)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAllArtist
            // 
            this.btnAllArtist.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnAllArtist.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAllArtist.Location = new System.Drawing.Point(12, 12);
            this.btnAllArtist.Name = "btnAllArtist";
            this.btnAllArtist.Size = new System.Drawing.Size(171, 42);
            this.btnAllArtist.TabIndex = 0;
            this.btnAllArtist.Text = "Display Artists";
            this.btnAllArtist.UseVisualStyleBackColor = false;
            this.btnAllArtist.Click += new System.EventHandler(this.btnAllArtist_Click);
            // 
            // btnAllAlbum
            // 
            this.btnAllAlbum.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnAllAlbum.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAllAlbum.Location = new System.Drawing.Point(314, 12);
            this.btnAllAlbum.Name = "btnAllAlbum";
            this.btnAllAlbum.Size = new System.Drawing.Size(171, 42);
            this.btnAllAlbum.TabIndex = 1;
            this.btnAllAlbum.Text = "Display Albums";
            this.btnAllAlbum.UseVisualStyleBackColor = false;
            this.btnAllAlbum.Click += new System.EventHandler(this.btnAllAlbum_Click);
            // 
            // btnAllSong
            // 
            this.btnAllSong.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnAllSong.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAllSong.Location = new System.Drawing.Point(616, 12);
            this.btnAllSong.Name = "btnAllSong";
            this.btnAllSong.Size = new System.Drawing.Size(171, 42);
            this.btnAllSong.TabIndex = 2;
            this.btnAllSong.Text = "Display Songs";
            this.btnAllSong.UseVisualStyleBackColor = false;
            this.btnAllSong.Click += new System.EventHandler(this.btnAllSong_Click);
            // 
            // dgvAllEntity
            // 
            this.dgvAllEntity.AllowUserToAddRows = false;
            this.dgvAllEntity.AllowUserToDeleteRows = false;
            this.dgvAllEntity.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllEntity.Location = new System.Drawing.Point(12, 60);
            this.dgvAllEntity.Name = "dgvAllEntity";
            this.dgvAllEntity.ReadOnly = true;
            this.dgvAllEntity.RowTemplate.Height = 25;
            this.dgvAllEntity.Size = new System.Drawing.Size(772, 362);
            this.dgvAllEntity.TabIndex = 3;
            this.dgvAllEntity.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAllEntity_CellClick);
            this.dgvAllEntity.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvAllEntity_ColumnHeaderMouseClick);
            // 
            // btnAddArt
            // 
            this.btnAddArt.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnAddArt.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddArt.Location = new System.Drawing.Point(12, 428);
            this.btnAddArt.Name = "btnAddArt";
            this.btnAddArt.Size = new System.Drawing.Size(171, 42);
            this.btnAddArt.TabIndex = 4;
            this.btnAddArt.Text = "Add Artist";
            this.btnAddArt.UseVisualStyleBackColor = false;
            this.btnAddArt.Click += new System.EventHandler(this.btnAddArt_Click);
            // 
            // btnAddAlb
            // 
            this.btnAddAlb.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnAddAlb.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddAlb.Location = new System.Drawing.Point(314, 428);
            this.btnAddAlb.Name = "btnAddAlb";
            this.btnAddAlb.Size = new System.Drawing.Size(171, 42);
            this.btnAddAlb.TabIndex = 5;
            this.btnAddAlb.Text = "Add Album";
            this.btnAddAlb.UseVisualStyleBackColor = false;
            this.btnAddAlb.Click += new System.EventHandler(this.btnAddAlb_Click);
            // 
            // btnAddSong
            // 
            this.btnAddSong.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnAddSong.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddSong.Location = new System.Drawing.Point(616, 428);
            this.btnAddSong.Name = "btnAddSong";
            this.btnAddSong.Size = new System.Drawing.Size(171, 42);
            this.btnAddSong.TabIndex = 6;
            this.btnAddSong.Text = "Add Song";
            this.btnAddSong.UseVisualStyleBackColor = false;
            this.btnAddSong.Click += new System.EventHandler(this.btnAddSong_Click);
            // 
            // frmMusic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InfoText;
            this.ClientSize = new System.Drawing.Size(800, 476);
            this.Controls.Add(this.btnAddSong);
            this.Controls.Add(this.btnAddAlb);
            this.Controls.Add(this.btnAddArt);
            this.Controls.Add(this.dgvAllEntity);
            this.Controls.Add(this.btnAllSong);
            this.Controls.Add(this.btnAllAlbum);
            this.Controls.Add(this.btnAllArtist);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmMusic";
            this.Text = "Music Management";
            this.Load += new System.EventHandler(this.frmMusic_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllEntity)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAllArtist;
        private System.Windows.Forms.Button btnAllAlbum;
        private System.Windows.Forms.Button btnAllSong;
        private System.Windows.Forms.DataGridView dgvAllEntity;
        private System.Windows.Forms.Button btnAddArt;
        private System.Windows.Forms.Button btnAddAlb;
        private System.Windows.Forms.Button btnAddSong;
    }
}
