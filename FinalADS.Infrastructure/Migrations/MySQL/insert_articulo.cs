using FluentMigrator;

namespace FinalADS.Infrastructure.Migrations.MySQL
{
    [Migration(75)]
    public class insert_articulo : Migration
    {
        public override void Up()
        {
            Execute.EmbeddedScript("insert_articulo.sql");
        }

        public override void Down()
        {
        }
    }
}
