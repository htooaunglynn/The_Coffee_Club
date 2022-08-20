using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheCoffeeClub.Model;

namespace TheCoffeeClub.DAO
{
    public class OwnerServer : IOwnerDAO
    {
        public List<OwnerModel> GetOwnerList()
        {
            List<OwnerModel> ownerListData = new List<OwnerModel>();

            string connectionString = "Data Source=localhost;Initial Catalog=CoffeeClubMgtDB;User Id=sa;Password=azono";

            SqlConnection sqlConnection = new SqlConnection(connectionString);

            sqlConnection.Open();

            if (sqlConnection != null)
            {
                string query = $"SELECT * FROM Owner ORDER BY Id";

                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    OwnerModel dbModel = new OwnerModel()
                    {
                        Id = Convert.ToInt32(sqlDataReader["Id"]),
                        UserName = sqlDataReader["UserName"].ToString(),
                        Email = sqlDataReader["Email"].ToString(),
                        Password = "***********",
                        ComfirmPassword = "***************" 
                    }; 

                    ownerListData.Add(dbModel); 

                } // end of sqlDataReader (while)

                sqlDataReader.Close();
                sqlConnection.Close();

            } // end of sqlConnection (if)

            return ownerListData;

        } // end of List<OwnerModel> GetOwnerList method

        //-------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------

        public OwnerModel GetOwnerListByUserNameAndPassword(string UserName, string Password)
        {
            OwnerModel dbModel = new OwnerModel();

            string connectionString= "Data Source=localhost;Initial Catalog=CoffeeClubMgtDB;User Id=sa;Password=azono";

            SqlConnection sqlConnection = new SqlConnection(connectionString);

            sqlConnection.Open();

            if(sqlConnection!=null)
            {
                string query = $"SELECT * FROM Owner WHERE UserName='{UserName}' AND Password='{Password}'";

                SqlCommand sqlCommand=new SqlCommand(query,sqlConnection);

                SqlDataReader sqlDataReader=sqlCommand.ExecuteReader();

                while(sqlDataReader.Read())
                {
                    dbModel.Id = Convert.ToInt32(sqlDataReader["Id"]);
                    dbModel.UserName = sqlDataReader["UserName"].ToString();
                    dbModel.Email = sqlDataReader["Email"].ToString();
                    dbModel.Password = sqlDataReader["Password"].ToString();
                    dbModel.ComfirmPassword = sqlDataReader["ComfirmPassword"].ToString();

                } // end of sqlDataReader (while)

                sqlDataReader.Close();
                sqlConnection.Close();

            } // end of sqlConnection (if)

            return dbModel;

        } // end of GetOwnerListByUserNameAndPassword

        //-------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------

        public void OwnerAdd(OwnerModel owner)
        {
            try
            {
                string connectionString = @"Data Source=localhost;Initial Catalog=CoffeeClubMgtDB;User Id=sa;Password=azono";

                SqlConnection sqlConnection = new SqlConnection(connectionString);
                sqlConnection.Open();

                if (sqlConnection != null)
                {
                    string query = $"insert into Owner values ({owner.Id},'{owner.UserName}','{owner.Email}','{owner.Password}','{owner.ComfirmPassword}')";

                    SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                    int result = sqlCommand.ExecuteNonQuery();

                    if (result > 0)
                    {
                        //MessageBox.Show($"\nCommands completed successfully. \nCompletion time: {DateTime.Now}\n");
                    }

                    sqlConnection.Close();
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        //-------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------

        public void OwnerDelete(OwnerModel owner)
        {
            try
            {
                string connectionString = @"Data Source=localhost;Initial Catalog=CoffeeClubMgtDB;User Id=sa;Password=azono";

                SqlConnection sqlConnection = new SqlConnection(connectionString);
                sqlConnection.Open();

                if (sqlConnection != null)
                {
                    string query = $"delete from Owner where Id={owner.Id}";

                    SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                    int result = sqlCommand.ExecuteNonQuery();

                    if (result > 0)
                    {
                         //MessageBox.Show($"\nCommands completed successfully. \nCompletion time: {DateTime.Now}\n");
                    }

                    sqlConnection.Close();
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Error occur " + error.Message);
            }
        }

        //-------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------

        public void OwnerRegistration(OwnerModel owner)
        {
            try
            {
                string connectionString = @"Data Source=localhost;Initial Catalog=CoffeeClubMgtDB;User Id=sa;Password=azono";

                SqlConnection sqlConnection = new SqlConnection(connectionString);

                sqlConnection.Open();

                if (sqlConnection != null)
                {
                    string query = $"INSERT INTO Owner VALUES ({owner.Id},'{owner.UserName}','{owner.Email}','{owner.Password}','{owner.ComfirmPassword}')";

                    SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                    int result = sqlCommand.ExecuteNonQuery();

                    if (result > 0)
                    {
                        //MessageBox.Show($"\nCommands completed successfully. \nCompletion time: {DateTime.Now}\n");
                    }

                    sqlConnection.Close();

                } // end of sqlConnection (if)
            }
            catch (Exception error)
            {
                    MessageBox.Show(error.Message);
            }

        } // end of OwnerRegistration method

        //-------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------

        public void OwnerUpdate(OwnerModel owner)
        {
            try
            {
                string connectionString = @"Data Source=localhost;Initial Catalog=CoffeeClubMgtDB;User Id=sa;Password=azono";

                SqlConnection sqlConnection = new SqlConnection(connectionString);
                sqlConnection.Open();

                if (sqlConnection != null)
                {
                    string query = $"UPDATE Owner SET UserName ='{owner.UserName}' , Email ='{owner.Email}' , Password ='{owner.Password}' , ComfirmPassword = '{owner.ComfirmPassword}' WHERE Id=  {owner.Id}";

                    SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                    int result = sqlCommand.ExecuteNonQuery();

                    if (result > 0)
                    {
                        //return  true;

                        //MessageBox.Show("correct");
                    }

                    sqlConnection.Close();
                }
            }
            catch (Exception error)
            {
                MessageBox.Show($"Error occur when {error.Message}!", "Error Occur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //return false;
        }
    } // end of OwnerServer class

} // end of namespace
