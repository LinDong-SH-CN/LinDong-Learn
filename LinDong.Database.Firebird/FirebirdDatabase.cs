using FirebirdSql.Data.FirebirdClient;
using LinDong.Database.Firebird;
using LinqToDB;

namespace LinDong.Database
{
    public class FirebirdDatabase
    {
        private static readonly string _ProviderName = "Firebird";

        private FbDatabaseConfig? _config;

        private FbConnectionStringBuilder? _builder;

        public DataOptions DataOptions
        {
            get
            {
                if (_builder == null)
                    throw new ConnectionStringNullException();
                return new DataOptions().UseConnectionString(_ProviderName, _builder.ConnectionString);
            }
        }

        private FirebirdDatabase(FbDatabaseConfig config)
        {
            _config = config;
            Initializer();
        }

        private void Initializer()
        {
            if (_config != null)
            {
                if (_config.Database != null && _config.Database != string.Empty)
                {
                    _builder = new FbConnectionStringBuilder();
                    _builder.UserID = _config.UserId;
                    _builder.Password = _config.Password;
                    _builder.Database = _config.Database;
                    _builder.DataSource = _config.DataSource;
                    _builder.ServerType = _config.ServerType;
                }
                else
                {
                    throw new DbNullException();
                }
            }
            else
            {
                throw new DbCfgNullException();
            }
        }

        private static FirebirdDatabase? _single;

        public static FirebirdDatabase UseConfig(FbDatabaseConfig config)
        {
            if (_single == null)
                _single = new FirebirdDatabase(config);
            return _single;
        }
    }

    public static class DatabaseExtendedFunction
    {
        public static FirebirdDB DbConnection(this DataOptions options)
        {
            return new FirebirdDB(options);
        }

        public static FirebirdDB DbConnection(this FirebirdDatabase database)
        {
            return database.DataOptions.DbConnection();
        }

        public static FirebirdDB DbConnection(this FbDatabaseConfig config)
        {
            return FirebirdDatabase.UseConfig(config).DbConnection();
        }
    }
}
