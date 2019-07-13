using System;
using System.Collections.Generic;
using System.Text;
using FluentMigrator;

namespace FinalADS.Infrastructure.Migrations.MySQL
{
    [Migration(78)]
    public class MODALIDAD :Migration
    {
        public override void Up()
        {
            Execute.EmbeddedScript("Modalidad.sql");
        }

        public override void Down()
        {
        }

    }
}
