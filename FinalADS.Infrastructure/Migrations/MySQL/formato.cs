using FluentMigrator;

namespace FinalADS.Infrastructure.Migrations.MySQL
{
    [Migration(76)]
    public class formato : Migration
    {
        public override void Up()
        {
            Execute.EmbeddedScript("formato.sql");
        }

        public override void Down()
        {
        }
    }
}
