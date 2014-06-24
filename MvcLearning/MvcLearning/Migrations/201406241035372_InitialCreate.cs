namespace MvcLearning.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.RestaurantModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        City = c.String(),
                        Country = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.RestaurantReviewModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Rate = c.Int(nullable: false),
                        Body = c.String(),
                        RestaurantId = c.Int(nullable: false),
                        RestaurantModels_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.RestaurantModels", t => t.RestaurantModels_Id)
                .Index(t => t.RestaurantModels_Id);
            
        }
        
        public override void Down()
        {
            DropIndex("dbo.RestaurantReviewModels", new[] { "RestaurantModels_Id" });
            DropForeignKey("dbo.RestaurantReviewModels", "RestaurantModels_Id", "dbo.RestaurantModels");
            DropTable("dbo.RestaurantReviewModels");
            DropTable("dbo.RestaurantModels");
        }
    }
}
