namespace MyCompany.Crm.Nuke.Postgres
{
    public class PostgresSettings
    {
        public const string Key = "Postgres";
        
        public string MigrationConnectionString { get; set; }
    }
}