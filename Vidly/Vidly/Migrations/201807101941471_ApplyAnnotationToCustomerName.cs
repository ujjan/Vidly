namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ApplyAnnotationToCustomerName : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MembershipTypes", "DiscountRate", c => c.Byte(nullable: false));
            AlterColumn("dbo.Customers", "Name", c => c.String(nullable: false, maxLength: 225));
            DropColumn("dbo.MembershipTypes", "DiscountRte");
        }
        
        public override void Down()
        {
            AddColumn("dbo.MembershipTypes", "DiscountRte", c => c.Byte(nullable: false));
            AlterColumn("dbo.Customers", "Name", c => c.String());
            DropColumn("dbo.MembershipTypes", "DiscountRate");
        }
    }
}
