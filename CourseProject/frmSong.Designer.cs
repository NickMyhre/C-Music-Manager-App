namespace CourseProject
{
    partial class frmSong
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblArtists = new System.Windows.Forms.Label();
            this.lblLength = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblbbDate = new System.Windows.Forms.Label();
            this.lblWriter = new System.Windows.Forms.Label();
            this.lblalbum = new System.Windows.Forms.Label();
            this.lblComments = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtbbRank = new System.Windows.Forms.TextBox();
            this.txtWriter = new System.Windows.Forms.TextBox();
            this.txtComments = new System.Windows.Forms.TextBox();
            this.btnModify = new System.Windows.Forms.Button();
            this.lstArtists = new System.Windows.Forms.ListBox();
            this.dtpBDate = new System.Windows.Forms.DateTimePicker();
            this.txtLength = new System.Windows.Forms.TextBox();
            this.chkbb = new System.Windows.Forms.CheckBox();
            this.lstAlbums = new System.Windows.Forms.ListBox();
            this.btnAlbum = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblTitle.Location = new System.Drawing.Point(127, 48);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(143, 41);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Title: ";
            // 
            // lblArtists
            // 
            this.lblArtists.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblArtists.Location = new System.Drawing.Point(127, 343);
            this.lblArtists.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblArtists.Name = "lblArtists";
            this.lblArtists.Size = new System.Drawing.Size(143, 28);
            this.lblArtists.TabIndex = 1;
            this.lblArtists.Text = "Artists: ";
            // 
            // lblLength
            // 
            this.lblLength.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblLength.Location = new System.Drawing.Point(601, 146);
            this.lblLength.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(143, 28);
            this.lblLength.TabIndex = 2;
            this.lblLength.Text = "Length: ";
            // 
            // label4
            // 
            this.label4.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label4.Location = new System.Drawing.Point(141, 133);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 28);
            this.label4.TabIndex = 3;
            this.label4.Text = "Billboard Rank: ";
            // 
            // lblbbDate
            // 
            this.lblbbDate.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblbbDate.Location = new System.Drawing.Point(537, 223);
            this.lblbbDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblbbDate.Name = "lblbbDate";
            this.lblbbDate.Size = new System.Drawing.Size(143, 28);
            this.lblbbDate.TabIndex = 4;
            this.lblbbDate.Text = "Billboard Date: ";
            // 
            // lblWriter
            // 
            this.lblWriter.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblWriter.Location = new System.Drawing.Point(141, 216);
            this.lblWriter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWriter.Name = "lblWriter";
            this.lblWriter.Size = new System.Drawing.Size(143, 28);
            this.lblWriter.TabIndex = 5;
            this.lblWriter.Text = "Writer: ";
            // 
            // lblalbum
            // 
            this.lblalbum.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblalbum.Location = new System.Drawing.Point(601, 306);
            this.lblalbum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblalbum.Name = "lblalbum";
            this.lblalbum.Size = new System.Drawing.Size(143, 28);
            this.lblalbum.TabIndex = 6;
            this.lblalbum.Text = "Album: ";
            // 
            // lblComments
            // 
            this.lblComments.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblComments.Location = new System.Drawing.Point(141, 293);
            this.lblComments.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblComments.Name = "lblComments";
            this.lblComments.Size = new System.Drawing.Size(143, 28);
            this.lblComments.TabIndex = 7;
            this.lblComments.Text = "Comments: ";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(236, 59);
            this.txtTitle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(760, 26);
            this.txtTitle.TabIndex = 9;
            // 
            // txtbbRank
            // 
            this.txtbbRank.Enabled = false;
            this.txtbbRank.Location = new System.Drawing.Point(277, 133);
            this.txtbbRank.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtbbRank.Name = "txtbbRank";
            this.txtbbRank.Size = new System.Drawing.Size(168, 26);
            this.txtbbRank.TabIndex = 11;
            // 
            // txtWriter
            // 
            this.txtWriter.Location = new System.Drawing.Point(250, 212);
            this.txtWriter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtWriter.Name = "txtWriter";
            this.txtWriter.Size = new System.Drawing.Size(195, 26);
            this.txtWriter.TabIndex = 12;
            // 
            // txtComments
            // 
            this.txtComments.Location = new System.Drawing.Point(250, 289);
            this.txtComments.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtComments.Name = "txtComments";
            this.txtComments.Size = new System.Drawing.Size(195, 26);
            this.txtComments.TabIndex = 13;
            this.txtComments.TextChanged += new System.EventHandler(this.txtComments_TextChanged);
            // 
            // btnModify
            // 
            this.btnModify.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnModify.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnModify.Location = new System.Drawing.Point(736, 427);
            this.btnModify.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(261, 52);
            this.btnModify.TabIndex = 17;
            this.btnModify.Text = "Modify";
            this.btnModify.UseVisualStyleBackColor = false;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // lstArtists
            // 
            this.lstArtists.FormattingEnabled = true;
            this.lstArtists.ItemHeight = 18;
            this.lstArtists.Location = new System.Drawing.Point(236, 343);
            this.lstArtists.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstArtists.Name = "lstArtists";
            this.lstArtists.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstArtists.Size = new System.Drawing.Size(210, 76);
            this.lstArtists.Sorted = true;
            this.lstArtists.TabIndex = 18;
            // 
            // dtpBDate
            // 
            this.dtpBDate.Enabled = false;
            this.dtpBDate.Location = new System.Drawing.Point(716, 223);
            this.dtpBDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpBDate.Name = "dtpBDate";
            this.dtpBDate.Size = new System.Drawing.Size(280, 26);
            this.dtpBDate.TabIndex = 19;
            // 
            // txtLength
            // 
            this.txtLength.Location = new System.Drawing.Point(704, 146);
            this.txtLength.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtLength.Name = "txtLength";
            this.txtLength.Size = new System.Drawing.Size(291, 26);
            this.txtLength.TabIndex = 20;
            this.txtLength.Text = "hh:mm:ss";
            // 
            // chkbb
            // 
            this.chkbb.AutoSize = true;
            this.chkbb.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.chkbb.Location = new System.Drawing.Point(569, 456);
            this.chkbb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkbb.Name = "chkbb";
            this.chkbb.Size = new System.Drawing.Size(154, 22);
            this.chkbb.TabIndex = 21;
            this.chkbb.Text = "Made Billboard?";
            this.chkbb.UseVisualStyleBackColor = true;
            this.chkbb.CheckedChanged += new System.EventHandler(this.chkbb_CheckedChanged);
            // 
            // lstAlbums
            // 
            this.lstAlbums.FormattingEnabled = true;
            this.lstAlbums.ItemHeight = 18;
            this.lstAlbums.Location = new System.Drawing.Point(736, 307);
            this.lstAlbums.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstAlbums.Name = "lstAlbums";
            this.lstAlbums.Size = new System.Drawing.Size(260, 112);
            this.lstAlbums.TabIndex = 22;
            // 
            // btnAlbum
            // 
            this.btnAlbum.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnAlbum.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAlbum.Location = new System.Drawing.Point(236, 427);
            this.btnAlbum.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAlbum.Name = "btnAlbum";
            this.btnAlbum.Size = new System.Drawing.Size(211, 52);
            this.btnAlbum.TabIndex = 23;
            this.btnAlbum.Text = "View Album";
            this.btnAlbum.UseVisualStyleBackColor = false;
            this.btnAlbum.Click += new System.EventHandler(this.btnAlbum_Click);
            // 
            // frmSong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InfoText;
            this.ClientSize = new System.Drawing.Size(1143, 540);
            this.Controls.Add(this.btnAlbum);
            this.Controls.Add(this.lstAlbums);
            this.Controls.Add(this.chkbb);
            this.Controls.Add(this.txtLength);
            this.Controls.Add(this.dtpBDate);
            this.Controls.Add(this.lstArtists);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.txtComments);
            this.Controls.Add(this.txtWriter);
            this.Controls.Add(this.txtbbRank);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.lblComments);
            this.Controls.Add(this.lblalbum);
            this.Controls.Add(this.lblWriter);
            this.Controls.Add(this.lblbbDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblLength);
            this.Controls.Add(this.lblArtists);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmSong";
            this.Text = "Song Information";
            this.Load += new System.EventHandler(this.song_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblArtists;
        private System.Windows.Forms.Label lblLength;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblbbDate;
        private System.Windows.Forms.Label lblWriter;
        private System.Windows.Forms.Label lblalbum;
        private System.Windows.Forms.Label lblComments;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtbbRank;
        private System.Windows.Forms.TextBox txtWriter;
        private System.Windows.Forms.TextBox txtComments;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.ListBox lstArtists;
        private System.Windows.Forms.DateTimePicker dtpBDate;
        private System.Windows.Forms.TextBox txtLength;
        private System.Windows.Forms.CheckBox chkbb;
        private System.Windows.Forms.ListBox lstAlbums;
        private System.Windows.Forms.Button btnAlbum;
    }
}