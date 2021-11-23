using System.Data;
using System.Data.SqlClient;

namespace LibraryManagement
{
    public class MyDB
    {
        private string dataSource;
        private string username;
        private string password;
        private SqlConnection con;
        public string getDataSource()
        {
            return this.dataSource;
        }
        public void setDataSource(string datasource)
        {
            this.dataSource = datasource;
        }
        public string getUsername()
        {
            return this.username;
        }
        public void setUsername(string username)
        {
            this.username = username;
        }
        public string getPassword()
        {
            return this.password;
        }
        public void setPassword(string password)
        {
            this.password = password;
        }
        public SqlConnection getConnection
        {
            get { return con; }
        }
        
        public MyDB(string datasource, string username, string password)
        {
            this.dataSource = datasource;
            this.username = username;
            this.password = password;
            this.con = new SqlConnection(@"Server=" + datasource + ";Database=LIBRARY;User Id=" + username + ";Password=" + password + ";");
        }

        
        public void openConnection()
        {
            if ((con.State == ConnectionState.Closed))
            {
                con.Open();
            }
        }
        public void closeConnection()
        {
            if ((con.State == ConnectionState.Open))
            {
                con.Close();
            }
        }
    }
}
