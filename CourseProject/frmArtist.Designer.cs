
namespace CourseProject
{
    partial class frmArtist
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
            this.dgvSongs = new System.Windows.Forms.DataGridView();
            this.dtpDeathDate = new System.Windows.Forms.DateTimePicker();
            this.btnModify = new System.Windows.Forms.Button();
            this.txtStage = new System.Windows.Forms.TextBox();
            this.txtFact = new System.Windows.Forms.TextBox();
            this.txtHometown = new System.Windows.Forms.TextBox();
            this.txtBirthName = new System.Windows.Forms.TextBox();
            this.lblFact = new System.Windows.Forms.Label();
            this.lblDeath = new System.Windows.Forms.Label();
            this.lblHometown = new System.Windows.Forms.Label();
            this.lblStage = new System.Windows.Forms.Label();
            this.lblBN = new System.Windows.Forms.Label();
            this.dtpBirth = new System.Windows.Forms.DateTimePicker();
            this.lblBirth = new System.Windows.Forms.Label();
            this.chkAlive = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSongs)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSongs
            // 
            this.dgvSongs.AllowUserToAddRows = false;
            this.dgvSongs.AllowUserToDeleteRows = false;
            this.dgvSongs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSongs.Location = new System.Drawing.Point(96, 353);
            this.dgvSongs.Name = "dgvSongs";
            this.dgvSongs.ReadOnly = true;
            this.dgvSongs.RowTemplate.Height = 25;
            this.dgvSongs.Size = new System.Drawing.Size(619, 281);
            this.dgvSongs.TabIndex = 51;
            this.dgvSongs.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSongs_CellContentClick);
            // 
            // dtpDeathDate
            // 
            this.dtpDeathDate.Location = new System.Drawing.Point(498, 207);
            this.dtpDeathDate.Name = "dtpDeathDate";
            this.dtpDeathDate.Size = new System.Drawing.Size(197, 23);
            this.dtpDeathDate.TabIndex = 50;
            // 
            // btnModify
            // 
            this.btnModify.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnModify.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnModify.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnModify.Location = new System.Drawing.Point(512, 262);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(183, 43);
            this.btnModify.TabIndex = 48;
            this.btnModify.Text = "Modify";
            this.btnModify.UseVisualStyleBackColor = false;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // txtStage
            // 
            this.txtStage.Location = new System.Drawing.Point(490, 142);
            this.txtStage.Name = "txtStage";
            this.txtStage.Size = new System.Drawing.Size(205, 23);
            this.txtStage.TabIndex = 47;
            // 
            // txtFact
            // 
            this.txtFact.Location = new System.Drawing.Point(172, 282);
            this.txtFact.Name = "txtFact";
            this.txtFact.Size = new System.Drawing.Size(138, 23);
            this.txtFact.TabIndex = 46;
            // 
            // txtHometown
            // 
            this.txtHometown.Location = new System.Drawing.Point(170, 129);
            this.txtHometown.Name = "txtHometown";
            this.txtHometown.Size = new System.Drawing.Size(140, 23);
            this.txtHometown.TabIndex = 45;
            // 
            // txtBirthName
            // 
            this.txtBirthName.Location = new System.Drawing.Point(172, 70);
            this.txtBirthName.Name = "txtBirthName";
            this.txtBirthName.Size = new System.Drawing.Size(533, 23);
            this.txtBirthName.TabIndex = 44;
            // 
            // lblFact
            // 
            this.lblFact.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblFact.Location = new System.Drawing.Point(96, 285);
            this.lblFact.Name = "lblFact";
            this.lblFact.Size = new System.Drawing.Size(100, 23);
            this.lblFact.TabIndex = 43;
            this.lblFact.Text = "Fact: ";
            // 
            // lblDeath
            // 
            this.lblDeath.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblDeath.Location = new System.Drawing.Point(418, 207);
            this.lblDeath.Name = "lblDeath";
            this.lblDeath.Size = new System.Drawing.Size(100, 23);
            this.lblDeath.TabIndex = 42;
            this.lblDeath.Text = "Death Date: ";
            // 
            // lblHometown
            // 
            this.lblHometown.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblHometown.Location = new System.Drawing.Point(81, 129);
            this.lblHometown.Name = "lblHometown";
            this.lblHometown.Size = new System.Drawing.Size(100, 23);
            this.lblHometown.TabIndex = 41;
            this.lblHometown.Text = "Hometown:";
            // 
            // lblStage
            // 
            this.lblStage.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblStage.Location = new System.Drawing.Point(418, 143);
            this.lblStage.Name = "lblStage";
            this.lblStage.Size = new System.Drawing.Size(100, 23);
            this.lblStage.TabIndex = 40;
            this.lblStage.Text = "Stage Name: ";
            // 
            // lblBN
            // 
            this.lblBN.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBN.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblBN.Location = new System.Drawing.Point(27, 61);
            this.lblBN.Name = "lblBN";
            this.lblBN.Size = new System.Drawing.Size(154, 34);
            this.lblBN.TabIndex = 38;
            this.lblBN.Text = "Birth Name:";
            // 
            // dtpBirth
            // 
            this.dtpBirth.Location = new System.Drawing.Point(170, 207);
            this.dtpBirth.Name = "dtpBirth";
            this.dtpBirth.Size = new System.Drawing.Size(197, 23);
            this.dtpBirth.TabIndex = 53;
            // 
            // lblBirth
            // 
            this.lblBirth.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblBirth.Location = new System.Drawing.Point(81, 207);
            this.lblBirth.Name = "lblBirth";
            this.lblBirth.Size = new System.Drawing.Size(100, 23);
            this.lblBirth.TabIndex = 52;
            this.lblBirth.Text = "Birth Date: ";
            // 
            // chkAlive
            // 
            this.chkAlive.AutoSize = true;
            this.chkAlive.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.chkAlive.Location = new System.Drawing.Point(418, 275);
            this.chkAlive.Name = "chkAlive";
            this.chkAlive.Size = new System.Drawing.Size(77, 19);
            this.chkAlive.TabIndex = 54;
            this.chkAlive.Text = "Still alive?";
            this.chkAlive.UseVisualStyleBackColor = true;
            this.chkAlive.CheckedChanged += new System.EventHandler(this.chkAlive_CheckedChanged);
            // 
            // frmArtist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InfoText;
            this.ClientSize = new System.Drawing.Size(800, 695);
            this.Controls.Add(this.chkAlive);
            this.Controls.Add(this.dtpBirth);
            this.Controls.Add(this.lblBirth);
            this.Controls.Add(this.dgvSongs);
            this.Controls.Add(this.dtpDeathDate);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.txtStage);
            this.Controls.Add(this.txtFact);
            this.Controls.Add(this.txtHometown);
            this.Controls.Add(this.txtBirthName);
            this.Controls.Add(this.lblFact);
            this.Controls.Add(this.lblDeath);
            this.Controls.Add(this.lblHometown);
            this.Controls.Add(this.lblStage);
            this.Controls.Add(this.lblBN);
            this.Name = "frmArtist";
            this.Text = "Artist Information";
            this.Load += new System.EventHandler(this.frmArtist_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSongs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSongs;
        private System.Windows.Forms.DateTimePicker dtpDeathDate;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.TextBox txtStage;
        private System.Windows.Forms.TextBox txtFact;
        private System.Windows.Forms.TextBox txtHometown;
        private System.Windows.Forms.TextBox txtBirthName;
        private System.Windows.Forms.Label lblFact;
        private System.Windows.Forms.Label lblDeath;
        private System.Windows.Forms.Label lblHometown;
        private System.Windows.Forms.Label lblStage;
        private System.Windows.Forms.Label lblBN;
        private System.Windows.Forms.DateTimePicker dtpBirth;
        private System.Windows.Forms.Label lblBirth;
        private System.Windows.Forms.CheckBox chkAlive;
    }
}