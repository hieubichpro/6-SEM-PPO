using System.Data;
using Npgsql;
using lab_08;
using lab_9;

namespace lab_04.DA
{
    //public class ConnectionArguments
    //{
    //    private string host;
    //    private string username;
    //    private string password;
    //    private int port;
    //    private string database;

    //    public string Host { get => host; set => host = value; }
    //    public string Username { get => username; set => username = value; }
    //    public string Password { get => password; set => password = value; }
    //    public int Port { get => port; set => port = value; }
    //    public string Database { get => database; set => database = value; }

    //    public ConnectionArguments(string host, string username, string password, int port, string database)
    //    {
    //        this.host = host;
    //        this.username = username;
    //        this.password = password;
    //        this.port = port;
    //        this.database = database;
    //    }
    //    public string getStringConnection()
    //    {
    //        return "Host = " + host + "; Username = " + username + "; Password = " + password + "; Database = " + database + ";";
    //    }
    //    public static class ConnectionCheck
    //    {
    //        public static void checkConnection(NpgsqlConnection connector)
    //        {
    //            if (connector == null || connector.State != ConnectionState.Open)
    //                return;
    //        }
    //    }
    //}

    public class DataProvider
    {
        private static DataProvider instance;
        //private NpgsqlConnection connector = new NpgsqlConnection(new ConnectionArguments("localhost", "postgres", "123456789", 5432, "PPO2024").getStringConnection());
        private NpgsqlConnection connector = new NpgsqlConnection(Program.connectionString);

        public static DataProvider Instance
        {
            get { if (instance == null) instance = new DataProvider(); return instance; }
            private set {instance = value; }
        }
        private DataProvider()
        {
            connector.Open();
        }

        public DataTable getDataTable(string query)
        {
            //connector.Open();
            NpgsqlCommand command = new NpgsqlCommand(query, connector);
            NpgsqlDataReader reader = command.ExecuteReader();
            DataTable data = new DataTable();
            data.Load(reader);
            reader.Close();
            //connector.Close();
            return data;
        }

        public void ExecuteNonQuery(string query)
        {
            NpgsqlCommand command = new NpgsqlCommand(query, connector);
            command.ExecuteNonQuery();
        }

        public NpgsqlDataReader ExecuteQuery(string query)
        {
            //connector.Open();
            NpgsqlCommand command = new NpgsqlCommand(query, connector);
            NpgsqlDataReader reader = command.ExecuteReader();
            //connector.Close();
            return reader;
        }
    }
}
