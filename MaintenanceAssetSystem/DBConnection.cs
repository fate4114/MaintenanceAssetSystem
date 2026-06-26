using MySql.Data.MySqlClient;

namespace MaintenanceAssetSystem
{
    public class DBConnection
    {
        public static string connString =
            "server=127.0.0.1;port=3307;database=maintenancerequestdb;uid=root;pwd=root;";
    }
}