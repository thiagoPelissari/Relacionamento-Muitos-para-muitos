namespace Relacionamento.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class criacaoPostsETags2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Posts", "Nome", c => c.String());
            AlterColumn("dbo.Posts", "Descricao", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Posts", "Descricao", c => c.Int(nullable: false));
            AlterColumn("dbo.Posts", "Nome", c => c.Int(nullable: false));
        }
    }
}
