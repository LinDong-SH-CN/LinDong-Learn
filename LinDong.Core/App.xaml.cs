using System.Windows;

namespace LinDong.Core
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static readonly Database.FbDatabaseConfig _config = new Database.FbDatabaseConfig()
        {
            Database = @"G:\NetProjects\LinDong\LinDong.Core\bin\x86\Debug\net6.0-windows\Database\Firebird.FDB",
            Password = "sysdba"
        };
    }
}
