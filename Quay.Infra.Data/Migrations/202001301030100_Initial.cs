namespace Quay.Infra.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Previsao",
                c => new
                    {
                        PrevisaoId = c.Int(nullable: false, identity: true),
                        Atualizacao = c.DateTime(nullable: false),
                        Dia = c.DateTime(nullable: false),
                        Tempo = c.String(maxLength: 100, unicode: false),
                        Cidade = c.String(nullable: false, maxLength: 150, unicode: false),
                        Estado = c.String(nullable: false, maxLength: 150, unicode: false),
                        Minima = c.Int(nullable: false),
                        Maxima = c.Int(nullable: false),
                        Ativo = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.PrevisaoId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Previsao");
        }
    }
}
