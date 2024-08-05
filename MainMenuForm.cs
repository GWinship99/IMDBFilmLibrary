using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMDBFilmLibrary
{
    public partial class MainMenuForm : Form
    {
        public MainMenuForm()
        {
            InitializeComponent();
        }

        private void crewDataBtn_Click(object sender, EventArgs e)
        {
            CrewDataForm crewDataForm = new CrewDataForm();
            crewDataForm.Show();
        }

        private void ratingsDataBtn_Click(object sender, EventArgs e)
        {
            RatingsDataForm ratingsDataForm = new RatingsDataForm();
            ratingsDataForm.Show();
        }

        private void episodeDataBtn_Click(object sender, EventArgs e)
        {
            EpisodeDataForm episodeDataForm = new EpisodeDataForm();
            episodeDataForm.Show();
        }
    }
}
