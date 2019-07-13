using FluentMigrator;

namespace FinalADS.Infrastructure.Migrations.MySQL
{
    [Migration(74)]
    public class articulo : Migration
    {
        public override void Up()
        {
            Execute.EmbeddedScript("articulo.sql");
        }

        public override void Down()
        {
        }
    }
}
