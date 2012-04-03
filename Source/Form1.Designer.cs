namespace WDTV_Live_MetaData_Generator
{
    partial class MainForm
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
            this.btnMovie = new System.Windows.Forms.Button();
            this.btnTVShow = new System.Windows.Forms.Button();
            this.pbTVShow = new System.Windows.Forms.PictureBox();
            this.pbMovies = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbTVShow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMovies)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMovie
            // 
            this.btnMovie.Location = new System.Drawing.Point(22, 91);
            this.btnMovie.Name = "btnMovie";
            this.btnMovie.Size = new System.Drawing.Size(75, 23);
            this.btnMovie.TabIndex = 0;
            this.btnMovie.Text = "Movie";
            this.btnMovie.UseVisualStyleBackColor = true;
            // 
            // btnTVShow
            // 
            this.btnTVShow.Location = new System.Drawing.Point(196, 91);
            this.btnTVShow.Name = "btnTVShow";
            this.btnTVShow.Size = new System.Drawing.Size(75, 23);
            this.btnTVShow.TabIndex = 1;
            this.btnTVShow.Text = "TV Show";
            this.btnTVShow.UseVisualStyleBackColor = true;
            this.btnTVShow.Click += new System.EventHandler(this.btnTVShow_Click);
            // 
            // pbTVShow
            // 
            this.pbTVShow.Image = global::WDTV_Live_MetaData_Generator.Properties.Resources.tv_show;
            this.pbTVShow.Location = new System.Drawing.Point(187, 12);
            this.pbTVShow.Name = "pbTVShow";
            this.pbTVShow.Size = new System.Drawing.Size(95, 75);
            this.pbTVShow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbTVShow.TabIndex = 3;
            this.pbTVShow.TabStop = false;
            // 
            // pbMovies
            // 
            this.pbMovies.Image = global::WDTV_Live_MetaData_Generator.Properties.Resources.movie;
            this.pbMovies.Location = new System.Drawing.Point(12, 12);
            this.pbMovies.Name = "pbMovies";
            this.pbMovies.Size = new System.Drawing.Size(95, 75);
            this.pbMovies.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbMovies.TabIndex = 2;
            this.pbMovies.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 126);
            this.Controls.Add(this.pbTVShow);
            this.Controls.Add(this.pbMovies);
            this.Controls.Add(this.btnTVShow);
            this.Controls.Add(this.btnMovie);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Media Type Choice";
            ((System.ComponentModel.ISupportInitialize)(this.pbTVShow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMovies)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMovie;
        private System.Windows.Forms.Button btnTVShow;
        private System.Windows.Forms.PictureBox pbMovies;
        private System.Windows.Forms.PictureBox pbTVShow;
    }
}

