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
    public partial class RatingsDataForm : Form
    {
        public RatingsDataForm()
        {
            InitializeComponent();
        }

        private void retrieveRatingsDataBtn_Click(object sender, EventArgs e)
        {
            string connectionString = "Server = DESKTOP-ADC20D3; Database = IMDB; User = sa; Password = cheesecake; Integrated Security = false;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "Select TOP 10 * FROM dbo.Ratings ORDER BY tconst";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    ratingsListBox.Items.Clear();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        List<string> ratingsList = new List<string>();
                        string data = string.Empty;
                        while (reader.Read())
                        {
                            string tconst = reader["tconst"].ToString();
                            string averageRating = reader["averageRating"].ToString();
                            string numberVotes = reader["numVotes"].ToString();
                            data = $"TConst = {tconst}, Average Rating = {averageRating}, Number of Votes = {numberVotes}";
                        }
                        ratingsList.Add(data);
                        foreach (string rating in ratingsList)
                        {
                            this.ratingsListBox.Items.Add(rating);
                        }
                    }
                    connection.Close();
                }
            }
        }
    }
}
