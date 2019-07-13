using FluentMigrator;

namespace FinalADS.Infrastructure.Migrations.MySQL
{
    [Migration(77)]
    public class insert_formato : Migration
    {
        public override void Up()
        {
            Execute.EmbeddedScript("insert_formato.sql");
        }

        public override void Down()
        {
        }
    }
}
