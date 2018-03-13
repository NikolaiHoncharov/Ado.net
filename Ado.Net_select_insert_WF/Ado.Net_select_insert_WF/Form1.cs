using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Ado.Net_select_insert_WF
{
    public partial class Form1 : Form {
        string FName, LName, ID_Countr;
        private string connectionString = $"Data Source=DESKTOP-VP3J4SV; Initial Catalog=BooksShop_db; Integrated Security=sspi;";
        SqlConnection connection;

        public Form1(){
            InitializeComponent();
            try { connection = new SqlConnection(connectionString); }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Exception"); }
        }

        //загрузка даных из таблиц 
        private void ConectBttn_Click(object sender, EventArgs e)
        {
            try{
                connection.Open();
                string query = "Select ID_Authors, FirstName, LastName, NameCountry from dbo.Authors Join dbo.Country On  dbo.Authors.ID_Country = dbo.Country.ID_Country";
                SqlCommand cmd = new SqlCommand(query, connection);
                SqlDataReader reader = cmd.ExecuteReader();
                //Считывание таблицы полностью
                while (reader.Read())
                    AuthorsListrchTxtBx.Text += $"\n {reader["ID_Authors"]}. {reader["LastName"]} {reader["FirstName"]} - {reader["NameCountry"]}\n";
                reader.Close();
            }catch (Exception ex) { MessageBox.Show(ex.Message, "Exception"); }
            finally { connection.Close(); }
        }

        private void DesconectBttn_Click(object sender, EventArgs e) { connection.Close(); AuthorsListrchTxtBx.Clear(); }

        private void Savebttn_Click(object sender, EventArgs e)
        {
            //Провекра на ввод данных 
            if (!String.IsNullOrWhiteSpace(FNametextBox.Text) && !String.IsNullOrWhiteSpace(SNametextBox.Text) && !String.IsNullOrWhiteSpace(IdCountrytextBox.Text))
            {
                FName = FNametextBox.Text;
                LName = SNametextBox.Text;
                ID_Countr = IdCountrytextBox.Text;
                try{
                    connection.Open();
                    string query = $"insert Authors values ('{FName}','{LName}', '{ID_Countr}')";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.ExecuteNonQuery();
                }catch (Exception ex) { MessageBox.Show($"{ex.Message}", "Exception"); }
                finally { connection.Close(); }
            }
            else { MessageBox.Show("Заполните все поля!", "Exception"); }
        }
    }
}
