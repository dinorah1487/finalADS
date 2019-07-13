using FluentMigrator;

namespace FinalADS.Infrastructure.Migrations.MySQL
{
    [Migration(79)]
    public class insert_modalidad : Migration
    {
        public override void Up()
        {
            Execute.EmbeddedScript("insert_modalidad.sql");
        }

        public override void Down()
        {
        }
    }
}
