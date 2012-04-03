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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnTVShow_Click(object sender, EventArgs e)
        {
            TVShowForm _tvShowForm = new TVShowForm();
            _tvShowForm.ShowDialog();
        }
    }
}
