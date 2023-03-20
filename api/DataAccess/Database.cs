using System.Data.SQLite;

namespace api.DataAccess
{
    public class Database
    {
        public Database()
        {

        }

        public void Get()
        {
            Config props = new Config();

            //create connection and open it
            using var con = new SQLiteConnection(props.cs,true);
            con.Open();

            //create command object so we can execute query
            string stm = "select SQLITE_VERSION()";
            using var cmd = new SQLiteCommand(stm,con);
            string version = cmd.ExecuteScalar().ToString();

            //test that our query ran
            System.Console.WriteLine(version);


        }
    }
}