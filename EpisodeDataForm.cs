using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMDBFilmLibrary
{
    public partial class EpisodeDataForm : Form
    {
        public EpisodeDataForm()
        {
            InitializeComponent();
        }

        private void retrieveEpisodesDataBtn_Click(object sender, EventArgs e)
        {
            string connectionString = "Server = DESKTOP-ADC20D3; Database = IMDB; User = sa; Password = cheesecake; Integrated Security = false;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "Select TOP 10 * FROM dbo.Episodes ORDER BY tconst";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    episodeListBox.Items.Clear();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        List<string> episodeList = new List<string>();
                        string data = string.Empty;
                        while (reader.Read())
                        {
                            string tconst = reader["tconst"].ToString();
                            string parentconst = reader["parentTconst"].ToString();
                            string seasonNumber = reader["seasonNumber"].ToString();
                            string episodeNumber = reader["episodeNumber"].ToString();
                            data = $"TConst = {tconst}, ParentConst = {parentconst}, Season Number = {seasonNumber}, Episode Number = {episodeNumber}";
                        }
                        episodeList.Add(data);
                        foreach (string episode in episodeList)
                        {
                            this.episodeListBox.Items.Add(episode);
                        }
                    }
                    connection.Close();
                }
            }
        }
    }
}
