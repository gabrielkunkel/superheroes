namespace Superheroes.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddSecondaryAbility : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Superheroes", "secondaryAbility", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Superheroes", "secondaryAbility");
        }
    }
}
