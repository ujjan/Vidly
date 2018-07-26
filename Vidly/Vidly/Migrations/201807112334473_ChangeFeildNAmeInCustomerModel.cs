namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeFeildNAmeInCustomerModel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "MembershipTypeId", c => c.Byte(nullable: false));
            DropColumn("dbo.Customers", "MembershipTypId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Customers", "MembershipTypId", c => c.Int(nullable: false));
            DropColumn("dbo.Customers", "MembershipTypeId");
        }
    }
}
