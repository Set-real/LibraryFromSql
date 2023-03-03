namespace LibraryFromSql.Configurations
{
    public static class ConnectionString
    {
        public static string MsSqlConnection => @"Server=.\SQLEXPRESS01;Database=testing;Trusted_Connection=True;TrustServerCertificate=true";
    }
}
