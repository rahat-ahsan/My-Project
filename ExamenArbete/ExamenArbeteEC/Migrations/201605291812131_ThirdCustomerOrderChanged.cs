namespace ExamenArbeteEC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ThirdCustomerOrderChanged : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.CustomerOrders", "FirstName", c => c.String(nullable: false, maxLength: 160));
            AlterColumn("dbo.CustomerOrders", "LastName", c => c.String(nullable: false, maxLength: 160));
            AlterColumn("dbo.CustomerOrders", "Address", c => c.String(nullable: false, maxLength: 70));
            AlterColumn("dbo.CustomerOrders", "City", c => c.String(nullable: false, maxLength: 40));
            AlterColumn("dbo.CustomerOrders", "State", c => c.String(nullable: false, maxLength: 40));
            AlterColumn("dbo.CustomerOrders", "PostalCode", c => c.String(nullable: false, maxLength: 10));
            AlterColumn("dbo.CustomerOrders", "Country", c => c.String(nullable: false, maxLength: 40));
            AlterColumn("dbo.CustomerOrders", "Phone", c => c.String(nullable: false, maxLength: 24));
            AlterColumn("dbo.CustomerOrders", "DateCreated", c => c.DateTime(nullable: false, precision: 7, storeType: "datetime2"));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.CustomerOrders", "DateCreated", c => c.DateTime(nullable: false));
            AlterColumn("dbo.CustomerOrders", "Phone", c => c.String(nullable: false));
            AlterColumn("dbo.CustomerOrders", "Country", c => c.String(nullable: false));
            AlterColumn("dbo.CustomerOrders", "PostalCode", c => c.String(nullable: false));
            AlterColumn("dbo.CustomerOrders", "State", c => c.String(nullable: false));
            AlterColumn("dbo.CustomerOrders", "City", c => c.String(nullable: false));
            AlterColumn("dbo.CustomerOrders", "Address", c => c.String(nullable: false));
            AlterColumn("dbo.CustomerOrders", "LastName", c => c.String(nullable: false));
            AlterColumn("dbo.CustomerOrders", "FirstName", c => c.String(nullable: false));
        }
    }
}
