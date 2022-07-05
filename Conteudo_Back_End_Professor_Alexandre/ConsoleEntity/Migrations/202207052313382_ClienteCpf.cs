namespace ConsoleEntity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ClienteCpf : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Clientes", "Cpf", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Clientes", "Cpf");
        }
    }
}
