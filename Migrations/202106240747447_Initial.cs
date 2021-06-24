namespace RegistrationAndLogin.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Prescricaos",
                c => new
                {
                    PrescricaoID = c.Int(nullable: false, identity: true),
                    CCUtente = c.String(),
                    CCAutorTerapeuta = c.String(),
                    Terapeuta = c.String(),
                    Medicamentos = c.String(),
                    Exercicios = c.String(),
                    Tratamentos = c.String(),
                    Validade = c.DateTime(nullable: true),
                })
                .PrimaryKey(t => t.PrescricaoID);

            CreateTable(
                "dbo.Terapeutas",
                c => new
                    {
                        TerapeutaID = c.Int(nullable: false, identity: true),
                        Username = c.String(),
                        Password = c.String(),
                        Address = c.String(),
                        FirstName = c.String(),
                        Lastname = c.String(),
                        Phonenumber = c.String(),
                        Borndate = c.DateTime(nullable: false),
                        CC = c.String(),
                    })
                .PrimaryKey(t => t.TerapeutaID);
            
            CreateTable(
                "dbo.Utentes",
                c => new
                    {
                        UtenteID = c.Int(nullable: false, identity: true),
                        Username = c.String(),
                        Password = c.String(),
                        Address = c.String(),
                        FirstName = c.String(),
                        Lastname = c.String(),
                        Phonenumber = c.String(),
                        Borndate = c.DateTime(nullable: false),
                        CC = c.String(),
                    })
                .PrimaryKey(t => t.UtenteID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Utentes");
            DropTable("dbo.Terapeutas");
            DropTable("dbo.Prescricaos");
        }
    }
}
