using FirebirdSql.Data.FirebirdClient;
using LinDong.Database.Firebird;
using LinqToDB;

namespace LinDong.Database
{
    public class FbDatabaseConfig
    {
        public string DataSource { get; set; } = "localhost";
        public string Database { get; set; } = string.Empty;
        public string UserId { get; set; } = "SYSDBA";
        public string Password { get; set; } = "masterkey";
        public FbServerType ServerType { get; set; } = FbServerType.Default;

        public FbDatabaseConfig() { }

        public FbDatabaseConfig(string database, FbServerType serverType = FbServerType.Default)
        {
            Database = database;
            ServerType = serverType;
        }

        public FbDatabaseConfig(string database, string userId, string password, FbServerType serverType = FbServerType.Default)
        {
            Database = database;
            UserId = userId;
            Password = password;
            ServerType = serverType;
        }

        public FbDatabaseConfig(string dataSource, string database, FbServerType serverType = FbServerType.Default)
        {
            DataSource = dataSource;
            Database = database;
            ServerType = serverType;
        }

        public FbDatabaseConfig(string dataSource, string database, string userId, string password, FbServerType serverType = FbServerType.Default)
        {
            DataSource = dataSource;
            Database = database;
            UserId = userId;
            Password = password;
            ServerType = serverType;
        }
    }
}