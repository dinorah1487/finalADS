﻿using FluentMigrator;

namespace FinalADS.Infrastructure.Migrations.MySQL
{
    [Migration(73)]
    public class InsertAccounts : Migration
    {
        public override void Up()
        {
            Execute.EmbeddedScript("7_InsertAccounts.sql");
        }

        public override void Down()
        {
        }
    }
}
