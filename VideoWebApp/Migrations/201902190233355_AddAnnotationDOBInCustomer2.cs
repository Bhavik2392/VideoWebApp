namespace VideoWebApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddAnnotationDOBInCustomer2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Customers", "DateOfBirth", c => c.DateTime(storeType: "date"));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Customers", "DateOfBirth", c => c.DateTime());
        }
    }
}
