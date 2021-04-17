namespace Real_Estate_Project.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingCustoemrFkRelationShip : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.Customers");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false),
                        LastName = c.String(nullable: false),
                        MiddleName = c.String(),
                        StreetAddress = c.String(nullable: false),
                        Municipality = c.String(nullable: false),
                        Province = c.String(nullable: false),
                        PostalCode = c.String(nullable: false),
                        PhoneNumber = c.String(nullable: false),
                        Email = c.String(),
                        dateOfBirth = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
    }
}
