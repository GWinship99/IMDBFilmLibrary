using System.Data.SqlClient;

namespace IMDBFilmLibrary
{
    public partial class CrewDataForm : Form
    {
        public CrewDataForm()
        {
            InitializeComponent();
        }

        private void retrieveCrewDataBtn_Click(object sender, EventArgs e)
        {
            string connectionString = "Server = DESKTOP-ADC20D3; Database = IMDB; User = sa; Password = cheesecake; Integrated Security = false;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            { 
                connection.Open();
                string query = "Select * FROM dbo.Crew ORDER BY tconst";
           
                using(SqlCommand command = new SqlCommand(query, connection))
                {
                    using(SqlDataReader reader = command.ExecuteReader())
                    {
                        string data = string.Empty;
                        while (reader.Read())
                        {
                            string tconst = reader["tconst"].ToString();
                            string directors = reader["directors"].ToString();
                            string writers = reader["writers"].ToString();
                            data = $"TConst = {tconst}, Director = {directors}, Writers = {writers}";
                        }
                        crewDataList.Text = data;
                    }
                    connection.Close();
                }
            }
        }
    }
}
