using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Reflection;

namespace WDTV_Live_MetaData_Generator
{
    public partial class TVShowForm : Form
    {
        public TVShowForm()
        {
            InitializeComponent();
        }

        #region TextBoxes

        private void tbShowName_MouseClick(object sender, MouseEventArgs e)
        {
            tbShowName.SelectAll();
        }

        private void tbSeasonNumber_MouseClick(object sender, MouseEventArgs e)
        {
            tbSeasonNumber.SelectAll();
        }

        private void tbNumberOfEpisodes_MouseClick(object sender, MouseEventArgs e)
        {
            tbNumberOfEpisodes.SelectAll();
        }

        private void tbGenre_MouseClick(object sender, MouseEventArgs e)
        {
            tbGenre.SelectAll();
        }

        private void tbRuntime_MouseClick(object sender, MouseEventArgs e)
        {
            tbRuntime.SelectAll();
        }

        private void tbActors_MouseClick(object sender, MouseEventArgs e)
        {
            tbActors.SelectAll();
        }

        private void tbtbTheTVDBShowNumber_MouseClick(object sender, MouseEventArgs e)
        {
            tbTheTVDBShowNumber.SelectAll();
        }

        #endregion

        private void TVShowForm_Load(object sender, EventArgs e)
        {

        }

        #region GUIButtons

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            string ShowName = "";
            string Genre = "";
            string Actors = "";
            int _seasonNumber = 0;
            int _numberOfEpisodes = 0;
            int _runtime = 0;
            int _TVDBShowNumber = 0;

            bool anErrorHasOccurred = false;

            #region CheckInput

            //check all of the inputted data is valid
            if (tbShowName.Text != "")
                ShowName = tbShowName.Text.ToString();
            else
                MessageBox.Show("Show Name has been inputted incorrectly", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            if (tbSeasonNumber.Text != "")
            {
                try
                {
                    _seasonNumber = Convert.ToInt32(tbSeasonNumber.Text);
                }
                catch (Exception seasonNumberException)
                {
                    anErrorHasOccurred = true;
                    MessageBox.Show("Season Number has been inputted incorrectly", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                anErrorHasOccurred = true;
                MessageBox.Show("Season Number has been inputted incorrectly", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (tbNumberOfEpisodes.Text != "")
            {
                try
                {
                    _numberOfEpisodes = Convert.ToInt32(tbNumberOfEpisodes.Text);
                }
                catch (Exception nubmerOfEpisodesException)
                {
                    anErrorHasOccurred = true;
                    _numberOfEpisodes = 0;
                    MessageBox.Show("Number of Episodes has been inputted incorrectly", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                anErrorHasOccurred = true;
                MessageBox.Show("Number of Episodes has been inputted incorrectly", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (tbGenre.Text != "")
                Genre = tbGenre.Text.ToString();
            else
            {
                anErrorHasOccurred = true;
                MessageBox.Show("Genre has been inputted incorrectly", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (tbRuntime.Text != "")
            {
                try
                {
                    _runtime = Convert.ToInt32(tbRuntime.Text);
                }
                catch (Exception runtimeMinutesException)
                {
                    anErrorHasOccurred = true;
                    MessageBox.Show("Runtime has been inputted incorrectly", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                anErrorHasOccurred = true;
                MessageBox.Show("Runtime has been inputted incorrectly", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (tbActors.Text != "")
                Actors = tbActors.Text.ToString();
            else
            {
                anErrorHasOccurred = true;
                MessageBox.Show("Actors has been inputted incorrectly", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (tbTheTVDBShowNumber.Text != "")
            {
                try
                {
                    _TVDBShowNumber = Convert.ToInt32(tbTheTVDBShowNumber.Text);
                }
                catch (Exception TVDBException)
                {
                    anErrorHasOccurred = true;
                    MessageBox.Show("TVDB Show Number has been inputted incorrectly", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                anErrorHasOccurred = true;
                MessageBox.Show("TVDB Show Number has been inputted incorrectly", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            #endregion

            if (!anErrorHasOccurred)
            {
                if (_numberOfEpisodes >= 1)
                {
                    bool filesWritenOk = true;
                    string appPath = Application.StartupPath;
                    string properllyFormattedActors = Actors.Replace(",", "/");
                    for (int i = 1; i <= _numberOfEpisodes; i++)
                    {
                        EpisodeNamePopUpBox _episodeNamePopUpBox = new EpisodeNamePopUpBox(i);
                        _episodeNamePopUpBox.ShowDialog();
                        string EpisodeName = EpisodeNamePopUpBox._episodeName;

                        try
                        {
                            string fileName = appPath + "\\" + _numberOfEpisodes + " - " + EpisodeName + ".xml";
                            XmlDocument xmlDocumentWriter = new XmlDocument();
                            XmlDeclaration xmlDec = xmlDocumentWriter.CreateXmlDeclaration("1.0", "utf-8", null);
                            XmlNode rootNode = xmlDocumentWriter.CreateElement("details");
                            rootNode.AppendChild(xmlDocumentWriter.CreateElement("id")).InnerText = _TVDBShowNumber.ToString();
                            rootNode.AppendChild(xmlDocumentWriter.CreateElement("series_name")).InnerText = ShowName;
                            rootNode.AppendChild(xmlDocumentWriter.CreateElement("episode_name")).InnerText = EpisodeName;
                            rootNode.AppendChild(xmlDocumentWriter.CreateElement("season_number")).InnerText = _seasonNumber.ToString();
                            if ( i < 10)
                                rootNode.AppendChild(xmlDocumentWriter.CreateElement("episode_number")).InnerText = "0" + i.ToString();
                            else
                                rootNode.AppendChild(xmlDocumentWriter.CreateElement("episode_number")).InnerText = i.ToString();
                            rootNode.AppendChild(xmlDocumentWriter.CreateElement("firstaired")).InnerText = "2001-01-01";
                            rootNode.AppendChild(xmlDocumentWriter.CreateElement("genre")).InnerText = Genre.ToString();
                            rootNode.AppendChild(xmlDocumentWriter.CreateElement("runtime")).InnerText = _runtime.ToString();
                            rootNode.AppendChild(xmlDocumentWriter.CreateElement("director")).InnerText = "Ed Smithy";
                            rootNode.AppendChild(xmlDocumentWriter.CreateElement("actor")).InnerText = properllyFormattedActors.ToString();
                            rootNode.AppendChild(xmlDocumentWriter.CreateElement("overview")).InnerText = "Some stuff happens";
                            rootNode.AppendChild(xmlDocumentWriter.CreateElement("backdrop")).InnerText = "http://thetvdb.com/banners/fanart/original/" + _TVDBShowNumber.ToString() + "-1.jpg";
                            rootNode.AppendChild(xmlDocumentWriter.CreateElement("backdrop")).InnerText = "http://thetvdb.com/banners/fanart/original/" + _TVDBShowNumber.ToString() + "-2.jpg";
                            rootNode.AppendChild(xmlDocumentWriter.CreateElement("backdrop")).InnerText = "http://thetvdb.com/banners/fanart/original/" + _TVDBShowNumber.ToString() + "-3.jpg";
                            rootNode.AppendChild(xmlDocumentWriter.CreateElement("backdrop")).InnerText = "http://thetvdb.com/banners/fanart/original/" + _TVDBShowNumber.ToString() + "-4.jpg";
                            xmlDocumentWriter.AppendChild(rootNode);
                            xmlDocumentWriter.Save(fileName);
                        }
                        catch (FieldAccessException io)
                        {
                            filesWritenOk = false;
                        }
                    }
                    if (filesWritenOk)
                        MessageBox.Show("All metadata files where written correctly", "Everything's OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Some of the metadata files where not written. Probably a file access error. Please make sure that you have write access to the folder",
                                        "Something went wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
            }
        }

        #endregion
    }
    }
}