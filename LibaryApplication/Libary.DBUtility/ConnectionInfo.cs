using System.Configuration;

namespace Libary.DBUtility
{
    /// <summary>
    /// ConnectionInfo 
    /// </summary>
    public class ConnectionInfo
    {
        public static string GetSqlServerConnectionString()
        {
            return ConfigurationSettings.AppSettings["LibaryDB"];
        }
    }
}
