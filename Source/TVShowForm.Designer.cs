namespace WDTV_Live_MetaData_Generator
{
    partial class TVShowForm
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
            this.lblShowName = new System.Windows.Forms.Label();
            this.tbShowName = new System.Windows.Forms.TextBox();
            this.lblNumberOfEpisodes = new System.Windows.Forms.Label();
            this.tbNumberOfEpisodes = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbSeasonNumber = new System.Windows.Forms.TextBox();
            this.lblGenre = new System.Windows.Forms.Label();
            this.tbGenre = new System.Windows.Forms.TextBox();
            this.lblRunTime = new System.Windows.Forms.Label();
            this.tbRuntime = new System.Windows.Forms.TextBox();
            this.lblActors = new System.Windows.Forms.Label();
            this.tbActors = new System.Windows.Forms.TextBox();
            this.lblTheTVDBShowNumber = new System.Windows.Forms.Label();
            this.tbTheTVDBShowNumber = new System.Windows.Forms.TextBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblShowName
            // 
            this.lblShowName.AutoSize = true;
            this.lblShowName.Location = new System.Drawing.Point(12, 9);
            this.lblShowName.Name = "lblShowName";
            this.lblShowName.Size = new System.Drawing.Size(68, 13);
            this.lblShowName.TabIndex = 0;
            this.lblShowName.Text = "Show Name:";
            // 
            // tbShowName
            // 
            this.tbShowName.Location = new System.Drawing.Point(177, 6);
            this.tbShowName.Name = "tbShowName";
            this.tbShowName.Size = new System.Drawing.Size(230, 20);
            this.tbShowName.TabIndex = 1;
            this.tbShowName.Text = "Type the name of the show into here, please";
            this.tbShowName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbShowName.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tbShowName_MouseClick);
            // 
            // lblNumberOfEpisodes
            // 
            this.lblNumberOfEpisodes.AutoSize = true;
            this.lblNumberOfEpisodes.Location = new System.Drawing.Point(12, 60);
            this.lblNumberOfEpisodes.Name = "lblNumberOfEpisodes";
            this.lblNumberOfEpisodes.Size = new System.Drawing.Size(102, 13);
            this.lblNumberOfEpisodes.TabIndex = 2;
            this.lblNumberOfEpisodes.Text = "Total # of Episodes:";
            // 
            // tbNumberOfEpisodes
            // 
            this.tbNumberOfEpisodes.Location = new System.Drawing.Point(307, 57);
            this.tbNumberOfEpisodes.Name = "tbNumberOfEpisodes";
            this.tbNumberOfEpisodes.Size = new System.Drawing.Size(100, 20);
            this.tbNumberOfEpisodes.TabIndex = 3;
            this.tbNumberOfEpisodes.Text = "Total # of Episodes";
            this.tbNumberOfEpisodes.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbNumberOfEpisodes.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tbNumberOfEpisodes_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Season Number:";
            // 
            // tbSeasonNumber
            // 
            this.tbSeasonNumber.Location = new System.Drawing.Point(307, 30);
            this.tbSeasonNumber.Name = "tbSeasonNumber";
            this.tbSeasonNumber.Size = new System.Drawing.Size(100, 20);
            this.tbSeasonNumber.TabIndex = 2;
            this.tbSeasonNumber.Text = "Season #";
            this.tbSeasonNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbSeasonNumber.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tbSeasonNumber_MouseClick);
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.Location = new System.Drawing.Point(12, 86);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(39, 13);
            this.lblGenre.TabIndex = 6;
            this.lblGenre.Text = "Genre:";
            // 
            // tbGenre
            // 
            this.tbGenre.Location = new System.Drawing.Point(307, 83);
            this.tbGenre.Name = "tbGenre";
            this.tbGenre.Size = new System.Drawing.Size(100, 20);
            this.tbGenre.TabIndex = 4;
            this.tbGenre.Text = "Genre";
            this.tbGenre.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbGenre.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tbGenre_MouseClick);
            // 
            // lblRunTime
            // 
            this.lblRunTime.AutoSize = true;
            this.lblRunTime.Location = new System.Drawing.Point(12, 112);
            this.lblRunTime.Name = "lblRunTime";
            this.lblRunTime.Size = new System.Drawing.Size(95, 13);
            this.lblRunTime.TabIndex = 8;
            this.lblRunTime.Text = "Runtime (Minutes):";
            // 
            // tbRuntime
            // 
            this.tbRuntime.Location = new System.Drawing.Point(307, 109);
            this.tbRuntime.Name = "tbRuntime";
            this.tbRuntime.Size = new System.Drawing.Size(100, 20);
            this.tbRuntime.TabIndex = 5;
            this.tbRuntime.Text = "Total Runtime";
            this.tbRuntime.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbRuntime.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tbRuntime_MouseClick);
            // 
            // lblActors
            // 
            this.lblActors.AutoSize = true;
            this.lblActors.Location = new System.Drawing.Point(12, 138);
            this.lblActors.Name = "lblActors";
            this.lblActors.Size = new System.Drawing.Size(40, 13);
            this.lblActors.TabIndex = 10;
            this.lblActors.Text = "Actors:";
            // 
            // tbActors
            // 
            this.tbActors.Location = new System.Drawing.Point(177, 135);
            this.tbActors.Name = "tbActors";
            this.tbActors.Size = new System.Drawing.Size(230, 20);
            this.tbActors.TabIndex = 6;
            this.tbActors.Text = "Actor Names (Seperated by ,)";
            this.tbActors.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbActors.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tbActors_MouseClick);
            // 
            // lblTheTVDBShowNumber
            // 
            this.lblTheTVDBShowNumber.AutoSize = true;
            this.lblTheTVDBShowNumber.Location = new System.Drawing.Point(12, 164);
            this.lblTheTVDBShowNumber.Name = "lblTheTVDBShowNumber";
            this.lblTheTVDBShowNumber.Size = new System.Drawing.Size(128, 13);
            this.lblTheTVDBShowNumber.TabIndex = 12;
            this.lblTheTVDBShowNumber.Text = "TheTVDB Show Number:";
            // 
            // tbTheTVDBShowNumber
            // 
            this.tbTheTVDBShowNumber.Location = new System.Drawing.Point(307, 161);
            this.tbTheTVDBShowNumber.Name = "tbTheTVDBShowNumber";
            this.tbTheTVDBShowNumber.Size = new System.Drawing.Size(100, 20);
            this.tbTheTVDBShowNumber.TabIndex = 7;
            this.tbTheTVDBShowNumber.Text = "Show #";
            this.tbTheTVDBShowNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbTheTVDBShowNumber.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tbtbTheTVDBShowNumber_MouseClick);
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(332, 187);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(75, 23);
            this.btnGenerate.TabIndex = 14;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(15, 187);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // TVShowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 217);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.tbTheTVDBShowNumber);
            this.Controls.Add(this.lblTheTVDBShowNumber);
            this.Controls.Add(this.tbActors);
            this.Controls.Add(this.lblActors);
            this.Controls.Add(this.tbRuntime);
            this.Controls.Add(this.lblRunTime);
            this.Controls.Add(this.tbGenre);
            this.Controls.Add(this.lblGenre);
            this.Controls.Add(this.tbSeasonNumber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbNumberOfEpisodes);
            this.Controls.Add(this.lblNumberOfEpisodes);
            this.Controls.Add(this.tbShowName);
            this.Controls.Add(this.lblShowName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "TVShowForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TV Show Metadata Generator";
            this.Load += new System.EventHandler(this.TVShowForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblShowName;
        private System.Windows.Forms.TextBox tbShowName;
        private System.Windows.Forms.Label lblNumberOfEpisodes;
        private System.Windows.Forms.TextBox tbNumberOfEpisodes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbSeasonNumber;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.TextBox tbGenre;
        private System.Windows.Forms.Label lblRunTime;
        private System.Windows.Forms.TextBox tbRuntime;
        private System.Windows.Forms.Label lblActors;
        private System.Windows.Forms.TextBox tbActors;
        private System.Windows.Forms.Label lblTheTVDBShowNumber;
        private System.Windows.Forms.TextBox tbTheTVDBShowNumber;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button btnCancel;
    }
}