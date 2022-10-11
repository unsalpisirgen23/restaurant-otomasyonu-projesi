namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Addresses",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Country = c.String(),
                        Province = c.String(),
                        District = c.String(),
                        Neighborhood = c.String(),
                        Street = c.String(),
                        DoorNumber = c.String(),
                        CustomerID = c.Int(),
                        EmployeID = c.Int(),
                        AddDate = c.DateTime(),
                        UpdateDate = c.DateTime(),
                        DeleteDate = c.DateTime(),
                        SessionMovementLoginID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Customers", t => t.CustomerID)
                .ForeignKey("dbo.Employes", t => t.EmployeID)
                .Index(t => t.CustomerID)
                .Index(t => t.EmployeID);
            
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Surname = c.String(),
                        FullName = c.String(),
                        Gender = c.Int(nullable: false),
                        Status = c.Int(nullable: false),
                        AddDate = c.DateTime(),
                        UpdateDate = c.DateTime(),
                        DeleteDate = c.DateTime(),
                        SessionMovementLoginID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Communications",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Phone = c.String(),
                        EMail = c.String(),
                        Instagram = c.String(),
                        Twitter = c.String(),
                        Facebook = c.String(),
                        Linkedin = c.String(),
                        CustomerID = c.Int(),
                        EmployeID = c.Int(),
                        AddDate = c.DateTime(),
                        UpdateDate = c.DateTime(),
                        DeleteDate = c.DateTime(),
                        SessionMovementLoginID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Customers", t => t.CustomerID)
                .ForeignKey("dbo.Employes", t => t.EmployeID)
                .Index(t => t.CustomerID)
                .Index(t => t.EmployeID);
            
            CreateTable(
                "dbo.Employes",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Surname = c.String(),
                        FullName = c.String(),
                        Gender = c.Int(),
                        CitizenshipNumber = c.String(),
                        Avatar = c.Binary(),
                        DateOfBirth = c.DateTime(),
                        MaritalStatus = c.Int(),
                        Username = c.String(),
                        Password = c.String(),
                        Status = c.Int(),
                        AddDate = c.DateTime(),
                        UpdateDate = c.DateTime(),
                        DeleteDate = c.DateTime(),
                        SessionMovementLoginID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.OrderCancellations",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        OrderID = c.Int(),
                        PlugID = c.Int(),
                        EmployeID = c.Int(),
                        CustomerID = c.Int(),
                        AddDate = c.DateTime(),
                        UpdateDate = c.DateTime(),
                        DeleteDate = c.DateTime(),
                        SessionMovementLoginID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Price = c.Decimal(precision: 18, scale: 2),
                        Piece = c.Int(),
                        ProductID = c.Int(),
                        PlugID = c.Int(),
                        EmployeID = c.Int(),
                        CustomerID = c.Int(),
                        AddDate = c.DateTime(),
                        UpdateDate = c.DateTime(),
                        DeleteDate = c.DateTime(),
                        SessionMovementLoginID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Customers", t => t.CustomerID)
                .ForeignKey("dbo.Employes", t => t.EmployeID)
                .ForeignKey("dbo.Plugs", t => t.PlugID)
                .ForeignKey("dbo.Products", t => t.ProductID)
                .Index(t => t.ProductID)
                .Index(t => t.PlugID)
                .Index(t => t.EmployeID)
                .Index(t => t.CustomerID);
            
            CreateTable(
                "dbo.Plugs",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        TableID = c.Int(),
                        AddDate = c.DateTime(),
                        UpdateDate = c.DateTime(),
                        DeleteDate = c.DateTime(),
                        SessionMovementLoginID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Tables", t => t.TableID)
                .Index(t => t.TableID);
            
            CreateTable(
                "dbo.Payments",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        PlugID = c.Int(),
                        EmployeID = c.Int(),
                        PaymentType = c.Int(nullable: false),
                        Amount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        TotalAmount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        EnterAmount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        RemainingAmount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        AddDate = c.DateTime(),
                        UpdateDate = c.DateTime(),
                        DeleteDate = c.DateTime(),
                        SessionMovementLoginID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Plugs", t => t.PlugID)
                .Index(t => t.PlugID);
            
            CreateTable(
                "dbo.Tables",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        No = c.String(),
                        Capacity = c.Int(),
                        Status = c.Int(nullable: false),
                        TableGroupID = c.Int(),
                        AddDate = c.DateTime(),
                        UpdateDate = c.DateTime(),
                        DeleteDate = c.DateTime(),
                        SessionMovementLoginID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.TableGroups", t => t.TableGroupID)
                .Index(t => t.TableGroupID);
            
            CreateTable(
                "dbo.TableGroups",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Status = c.Int(),
                        AddDate = c.DateTime(),
                        UpdateDate = c.DateTime(),
                        DeleteDate = c.DateTime(),
                        SessionMovementLoginID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Picture = c.Binary(),
                        Status = c.Int(nullable: false),
                        ProductGroupID = c.Int(),
                        AddDate = c.DateTime(),
                        UpdateDate = c.DateTime(),
                        DeleteDate = c.DateTime(),
                        SessionMovementLoginID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.ProductGroups", t => t.ProductGroupID)
                .Index(t => t.ProductGroupID);
            
            CreateTable(
                "dbo.ProductGroups",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Picture = c.Binary(),
                        Status = c.Int(nullable: false),
                        AddDate = c.DateTime(),
                        UpdateDate = c.DateTime(),
                        DeleteDate = c.DateTime(),
                        SessionMovementLoginID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Orders", "ProductID", "dbo.Products");
            DropForeignKey("dbo.Products", "ProductGroupID", "dbo.ProductGroups");
            DropForeignKey("dbo.Tables", "TableGroupID", "dbo.TableGroups");
            DropForeignKey("dbo.Plugs", "TableID", "dbo.Tables");
            DropForeignKey("dbo.Payments", "PlugID", "dbo.Plugs");
            DropForeignKey("dbo.Orders", "PlugID", "dbo.Plugs");
            DropForeignKey("dbo.Orders", "EmployeID", "dbo.Employes");
            DropForeignKey("dbo.Orders", "CustomerID", "dbo.Customers");
            DropForeignKey("dbo.Communications", "EmployeID", "dbo.Employes");
            DropForeignKey("dbo.Addresses", "EmployeID", "dbo.Employes");
            DropForeignKey("dbo.Communications", "CustomerID", "dbo.Customers");
            DropForeignKey("dbo.Addresses", "CustomerID", "dbo.Customers");
            DropIndex("dbo.Products", new[] { "ProductGroupID" });
            DropIndex("dbo.Tables", new[] { "TableGroupID" });
            DropIndex("dbo.Payments", new[] { "PlugID" });
            DropIndex("dbo.Plugs", new[] { "TableID" });
            DropIndex("dbo.Orders", new[] { "CustomerID" });
            DropIndex("dbo.Orders", new[] { "EmployeID" });
            DropIndex("dbo.Orders", new[] { "PlugID" });
            DropIndex("dbo.Orders", new[] { "ProductID" });
            DropIndex("dbo.Communications", new[] { "EmployeID" });
            DropIndex("dbo.Communications", new[] { "CustomerID" });
            DropIndex("dbo.Addresses", new[] { "EmployeID" });
            DropIndex("dbo.Addresses", new[] { "CustomerID" });
            DropTable("dbo.ProductGroups");
            DropTable("dbo.Products");
            DropTable("dbo.TableGroups");
            DropTable("dbo.Tables");
            DropTable("dbo.Payments");
            DropTable("dbo.Plugs");
            DropTable("dbo.Orders");
            DropTable("dbo.OrderCancellations");
            DropTable("dbo.Employes");
            DropTable("dbo.Communications");
            DropTable("dbo.Customers");
            DropTable("dbo.Addresses");
        }
    }
}
