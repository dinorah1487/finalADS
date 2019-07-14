using FluentMigrator;

namespace FinalADS.Infrastructure.Migrations.MySQL
{
    [Migration(133)]
    public class InsertCustomer : Migration
    {
        public override void Up()
        {
            Execute.EmbeddedScript("8_InsertCustomer.sql");
        }

        public override void Down()
        {
        }
    }
}
