
namespace CourseProject
{
    partial class frmAlbum
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dtpRelDate = new System.Windows.Forms.DateTimePicker();
            this.lstArtists = new System.Windows.Forms.ListBox();
            this.btnModify = new System.Windows.Forms.Button();
            this.txtGenre = new System.Windows.Forms.TextBox();
            this.txtFact = new System.Windows.Forms.TextBox();
            this.txtLabel = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lblFact = new System.Windows.Forms.Label();
            this.lblRelDate = new System.Windows.Forms.Label();
            this.lblLabel = new System.Windows.Forms.Label();
            this.lblLength = new System.Windows.Forms.Label();
            this.lblArtists = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.dgvSongs = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSongs)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpRelDate
            // 
            this.dtpRelDate.Location = new System.Drawing.Point(691, 215);
            this.dtpRelDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpRelDate.Name = "dtpRelDate";
            this.dtpRelDate.Size = new System.Drawing.Size(280, 26);
            this.dtpRelDate.TabIndex = 36;
            // 
            // lstArtists
            // 
            this.lstArtists.FormattingEnabled = true;
            this.lstArtists.ItemHeight = 18;
            this.lstArtists.Location = new System.Drawing.Point(211, 281);
            this.lstArtists.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstArtists.Name = "lstArtists";
            this.lstArtists.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstArtists.Size = new System.Drawing.Size(210, 76);
            this.lstArtists.Sorted = true;
            this.lstArtists.TabIndex = 35;
            // 
            // btnModify
            // 
            this.btnModify.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnModify.Location = new System.Drawing.Point(711, 281);
            this.btnModify.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(261, 52);
            this.btnModify.TabIndex = 34;
            this.btnModify.Text = "Modify";
            this.btnModify.UseVisualStyleBackColor = false;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // txtGenre
            // 
            this.txtGenre.Location = new System.Drawing.Point(680, 137);
            this.txtGenre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtGenre.Name = "txtGenre";
            this.txtGenre.Size = new System.Drawing.Size(291, 26);
            this.txtGenre.TabIndex = 32;
            // 
            // txtFact
            // 
            this.txtFact.Location = new System.Drawing.Point(226, 204);
            this.txtFact.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFact.Name = "txtFact";
            this.txtFact.Size = new System.Drawing.Size(195, 26);
            this.txtFact.TabIndex = 30;
            // 
            // txtLabel
            // 
            this.txtLabel.Location = new System.Drawing.Point(253, 125);
            this.txtLabel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtLabel.Name = "txtLabel";
            this.txtLabel.Size = new System.Drawing.Size(168, 26);
            this.txtLabel.TabIndex = 29;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(226, 50);
            this.txtTitle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(760, 26);
            this.txtTitle.TabIndex = 28;
            // 
            // lblFact
            // 
            this.lblFact.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblFact.Location = new System.Drawing.Point(117, 208);
            this.lblFact.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFact.Name = "lblFact";
            this.lblFact.Size = new System.Drawing.Size(143, 28);
            this.lblFact.TabIndex = 25;
            this.lblFact.Text = "Fact: ";
            // 
            // lblRelDate
            // 
            this.lblRelDate.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblRelDate.Location = new System.Drawing.Point(513, 215);
            this.lblRelDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRelDate.Name = "lblRelDate";
            this.lblRelDate.Size = new System.Drawing.Size(143, 28);
            this.lblRelDate.TabIndex = 24;
            this.lblRelDate.Text = "Release Date: ";
            // 
            // lblLabel
            // 
            this.lblLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblLabel.Location = new System.Drawing.Point(117, 125);
            this.lblLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLabel.Name = "lblLabel";
            this.lblLabel.Size = new System.Drawing.Size(143, 28);
            this.lblLabel.TabIndex = 23;
            this.lblLabel.Text = "Label: ";
            // 
            // lblLength
            // 
            this.lblLength.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblLength.Location = new System.Drawing.Point(577, 138);
            this.lblLength.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(143, 28);
            this.lblLength.TabIndex = 22;
            this.lblLength.Text = "Genre: ";
            // 
            // lblArtists
            // 
            this.lblArtists.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblArtists.Location = new System.Drawing.Point(117, 300);
            this.lblArtists.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblArtists.Name = "lblArtists";
            this.lblArtists.Size = new System.Drawing.Size(143, 28);
            this.lblArtists.TabIndex = 21;
            this.lblArtists.Text = "Artists: ";
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblTitle.Location = new System.Drawing.Point(103, 40);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(143, 41);
            this.lblTitle.TabIndex = 20;
            this.lblTitle.Text = "Title: ";
            // 
            // dgvSongs
            // 
            this.dgvSongs.AllowUserToAddRows = false;
            this.dgvSongs.AllowUserToDeleteRows = false;
            this.dgvSongs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSongs.Location = new System.Drawing.Point(117, 390);
            this.dgvSongs.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvSongs.Name = "dgvSongs";
            this.dgvSongs.ReadOnly = true;
            this.dgvSongs.RowTemplate.Height = 25;
            this.dgvSongs.Size = new System.Drawing.Size(884, 337);
            this.dgvSongs.TabIndex = 37;
            this.dgvSongs.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSongs_CellContentClick);
            // 
            // frmAlbum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InfoText;
            this.ClientSize = new System.Drawing.Size(1143, 740);
            this.Controls.Add(this.dgvSongs);
            this.Controls.Add(this.dtpRelDate);
            this.Controls.Add(this.lstArtists);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.txtGenre);
            this.Controls.Add(this.txtFact);
            this.Controls.Add(this.txtLabel);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.lblFact);
            this.Controls.Add(this.lblRelDate);
            this.Controls.Add(this.lblLabel);
            this.Controls.Add(this.lblLength);
            this.Controls.Add(this.lblArtists);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmAlbum";
            this.Text = "Album Information";
            this.Load += new System.EventHandler(this.frmAlbum_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSongs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpRelDate;
        private System.Windows.Forms.ListBox lstArtists;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.TextBox txtGenre;
        private System.Windows.Forms.TextBox txtFact;
        private System.Windows.Forms.TextBox txtLabel;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label lblFact;
        private System.Windows.Forms.Label lblRelDate;
        private System.Windows.Forms.Label lblLabel;
        private System.Windows.Forms.Label lblLength;
        private System.Windows.Forms.Label lblArtists;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridView dgvSongs;
    }
}