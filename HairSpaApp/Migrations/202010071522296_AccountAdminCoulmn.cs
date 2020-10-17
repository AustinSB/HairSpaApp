namespace HairSpaApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AccountAdminCoulmn : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Accounts", "IsAdmin", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Accounts", "IsAdmin");
        }
    }
}
