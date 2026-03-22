namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class crear_tabla_TipoCuenta_y_Cuenta : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cuentas",
                c => new
                    {
                        CuentaId = c.Int(nullable: false, identity: true),
                        NumeroCuenta = c.String(nullable: false, maxLength: 30),
                        ClienteId = c.Int(nullable: false),
                        TipoCuentaId = c.Int(nullable: false),
                        Saldo = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Estado = c.Byte(nullable: false),
                        FechaApertura = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                    })
                .PrimaryKey(t => t.CuentaId)
                .ForeignKey("dbo.Clientes", t => t.ClienteId, cascadeDelete: true)
                .ForeignKey("dbo.TipoCuentas", t => t.TipoCuentaId, cascadeDelete: true)
                .Index(t => t.NumeroCuenta, unique: true, name: "UQ_NumeroCuenta")
                .Index(t => t.ClienteId)
                .Index(t => t.TipoCuentaId);
            
            CreateTable(
                "dbo.TipoCuentas",
                c => new
                    {
                        TipoCuentaId = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 60),
                        Moneda = c.String(nullable: false, maxLength: 10),
                        Activa = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.TipoCuentaId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Cuentas", "TipoCuentaId", "dbo.TipoCuentas");
            DropForeignKey("dbo.Cuentas", "ClienteId", "dbo.Clientes");
            DropIndex("dbo.Cuentas", new[] { "TipoCuentaId" });
            DropIndex("dbo.Cuentas", new[] { "ClienteId" });
            DropIndex("dbo.Cuentas", "UQ_NumeroCuenta");
            DropTable("dbo.TipoCuentas");
            DropTable("dbo.Cuentas");
        }
    }
}
