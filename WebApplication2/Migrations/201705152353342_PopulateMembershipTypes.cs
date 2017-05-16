namespace VidlyII.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMembershipTypes : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO MembershipTypes (ID, Name, SignUpFee, DurationInMonths, DiscountRate) VALUES (1, 'Pay as You Go', 0, 0, 0)");
            Sql("INSERT INTO MembershipTypes (ID, Name, SignUpFee, DurationInMonths, DiscountRate) VALUES (2, 'Monthly', 3, 1, 10)");
            Sql("INSERT INTO MembershipTypes (ID, Name, SignUpFee, DurationInMonths, DiscountRate) VALUES (3, 'Quaterly', 90, 3, 15)");
            Sql("INSERT INTO MembershipTypes (ID, Name, SignUpFee, DurationInMonths, DiscountRate) VALUES (4, 'Annual', 300, 12, 20)");
        }
        
        public override void Down()
        {
        }
    }
}
