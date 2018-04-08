namespace Erasmus.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DodavanjeSlikeNaStudentModel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Students", "RokLjetni", c => c.Boolean(nullable: false));
            AddColumn("dbo.Students", "RokZimski", c => c.Boolean(nullable: false));
            AddColumn("dbo.Students", "SlikaDatoteka", c => c.Binary());
            AddColumn("dbo.Students", "MimeTypeSlika", c => c.String());
            DropColumn("dbo.Students", "Rok");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Students", "Rok", c => c.String());
            DropColumn("dbo.Students", "MimeTypeSlika");
            DropColumn("dbo.Students", "SlikaDatoteka");
            DropColumn("dbo.Students", "RokZimski");
            DropColumn("dbo.Students", "RokLjetni");
        }
    }
}
