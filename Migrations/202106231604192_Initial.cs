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
                        Validade = c.DateTime(nullable: false),
                        AutorTerapeuta_TerapeutaID = c.Int(),
                        Utente__UtenteID = c.Int(),
                    })
                .PrimaryKey(t => t.PrescricaoID)
                .ForeignKey("dbo.Terapeutas", t => t.AutorTerapeuta_TerapeutaID)
                .ForeignKey("dbo.Utentes", t => t.Utente__UtenteID)
                .Index(t => t.AutorTerapeuta_TerapeutaID)
                .Index(t => t.Utente__UtenteID);
            
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
                        Prescricao_PrescricaoID = c.Int(),
                    })
                .PrimaryKey(t => t.TerapeutaID)
                .ForeignKey("dbo.Prescricaos", t => t.Prescricao_PrescricaoID)
                .Index(t => t.Prescricao_PrescricaoID);
            
            CreateTable(
                "dbo.Exercicios",
                c => new
                    {
                        ExercicioID = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        Prescricao_PrescricaoID = c.Int(),
                    })
                .PrimaryKey(t => t.ExercicioID)
                .ForeignKey("dbo.Prescricaos", t => t.Prescricao_PrescricaoID)
                .Index(t => t.Prescricao_PrescricaoID);
            
            CreateTable(
                "dbo.Medicamentoes",
                c => new
                    {
                        MedicamentoID = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        Prescricao_PrescricaoID = c.Int(),
                    })
                .PrimaryKey(t => t.MedicamentoID)
                .ForeignKey("dbo.Prescricaos", t => t.Prescricao_PrescricaoID)
                .Index(t => t.Prescricao_PrescricaoID);
            
            CreateTable(
                "dbo.Tratamentoes",
                c => new
                    {
                        TratamentoID = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        Prescricao_PrescricaoID = c.Int(),
                    })
                .PrimaryKey(t => t.TratamentoID)
                .ForeignKey("dbo.Prescricaos", t => t.Prescricao_PrescricaoID)
                .Index(t => t.Prescricao_PrescricaoID);
            
            CreateTable(
                "dbo.Utentes",
                c => new
                    {
                        _UtenteID = c.Int(nullable: false, identity: true),
                        Username = c.String(),
                        Password = c.String(),
                        Address = c.String(),
                        FirstName = c.String(),
                        Lastname = c.String(),
                        Phonenumber = c.String(),
                        Borndate = c.DateTime(nullable: false),
                        CC = c.String(),
                    })
                .PrimaryKey(t => t._UtenteID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Prescricaos", "Utente__UtenteID", "dbo.Utentes");
            DropForeignKey("dbo.Tratamentoes", "Prescricao_PrescricaoID", "dbo.Prescricaos");
            DropForeignKey("dbo.Terapeutas", "Prescricao_PrescricaoID", "dbo.Prescricaos");
            DropForeignKey("dbo.Medicamentoes", "Prescricao_PrescricaoID", "dbo.Prescricaos");
            DropForeignKey("dbo.Exercicios", "Prescricao_PrescricaoID", "dbo.Prescricaos");
            DropForeignKey("dbo.Prescricaos", "AutorTerapeuta_TerapeutaID", "dbo.Terapeutas");
            DropIndex("dbo.Tratamentoes", new[] { "Prescricao_PrescricaoID" });
            DropIndex("dbo.Medicamentoes", new[] { "Prescricao_PrescricaoID" });
            DropIndex("dbo.Exercicios", new[] { "Prescricao_PrescricaoID" });
            DropIndex("dbo.Terapeutas", new[] { "Prescricao_PrescricaoID" });
            DropIndex("dbo.Prescricaos", new[] { "Utente__UtenteID" });
            DropIndex("dbo.Prescricaos", new[] { "AutorTerapeuta_TerapeutaID" });
            DropTable("dbo.Utentes");
            DropTable("dbo.Tratamentoes");
            DropTable("dbo.Medicamentoes");
            DropTable("dbo.Exercicios");
            DropTable("dbo.Terapeutas");
            DropTable("dbo.Prescricaos");
        }
    }
}
