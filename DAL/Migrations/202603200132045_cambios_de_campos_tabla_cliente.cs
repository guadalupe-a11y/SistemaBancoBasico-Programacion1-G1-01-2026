namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class cambios_de_campos_tabla_cliente : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Clientes", "Nombres", c => c.String(nullable: false, maxLength: 80));
            AlterColumn("dbo.Clientes", "Apellidos", c => c.String(nullable: false, maxLength: 80));
            AlterColumn("dbo.Clientes", "Documento", c => c.String(nullable: false, maxLength: 25));
            AlterColumn("dbo.Clientes", "Email", c => c.String(maxLength: 120));
            AlterColumn("dbo.Clientes", "Telefono", c => c.String(maxLength: 30));
            AlterColumn("dbo.Clientes", "FechaRegistro", c => c.DateTime(nullable: false, precision: 7, storeType: "datetime2"));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Clientes", "FechaRegistro", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Clientes", "Telefono", c => c.String());
            AlterColumn("dbo.Clientes", "Email", c => c.String());
            AlterColumn("dbo.Clientes", "Documento", c => c.String());
            AlterColumn("dbo.Clientes", "Apellidos", c => c.String());
            AlterColumn("dbo.Clientes", "Nombres", c => c.String());
        }
    }
}
