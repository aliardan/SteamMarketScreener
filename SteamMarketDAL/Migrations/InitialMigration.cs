using FluentMigrator;

namespace SteamMarketDAL.Migrations
{
    [Migration(20220130223000)]
    public class InitialMigration : Migration
    {
        public override void Up()
        {
            Create.Table("Item")
            .WithColumn("Id").AsInt64().PrimaryKey()
            .WithColumn("Name").AsString(100);
        }

        public override void Down()
        {
            Delete.Table("Item");
        }
    }
}
