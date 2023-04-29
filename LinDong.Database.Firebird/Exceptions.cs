using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinDong.Database
{
    /// <summary>
    /// The Exception For Database Driver(ProviderName) Is Null.
    /// </summary>
    /// <remarks>
    /// 数据库驱动文件未加载，或加载错误。
    /// </remarks>
    public class ProviderNameNullException : Exception
    {
        private static readonly string _exception_msg = "Database Driver(ProviderName) is Null.";

        public ProviderNameNullException() : base(_exception_msg) { }
    }

    public class DbCfgNullException : Exception
    {
        private static readonly string _exception_msg = "Database Config Object is Null.";

        public DbCfgNullException() : base(_exception_msg) { }
    }

    public class DbNullException : Exception
    {
        private static readonly string _exception_msg = "Database is not here, Please check Database Path.";

        public DbNullException() : base(_exception_msg) { }
    }

    public class ConnectionStringNullException : Exception
    {
        private static readonly string _exception_msg = "FbConnectionStringBuilder is null.";

        public ConnectionStringNullException() : base(_exception_msg) { }
    }
}
