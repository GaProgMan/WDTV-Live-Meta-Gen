using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WDTV_Live_MetaData_Generator
{
    public partial class EpisodeNamePopUpBox : Form
    {
        public static string _episodeName = "";

        public EpisodeNamePopUpBox()
        {
            InitializeComponent();
        }

        public EpisodeNamePopUpBox(int numberOfEpisode)
        {
            InitializeComponent();
            lblEpisodeNumber.Text += numberOfEpisode.ToString() + "?";
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            _episodeName = tbEpisodeName.Text.ToString();
            this.DialogResult = DialogResult.OK;
        }
    }
}
