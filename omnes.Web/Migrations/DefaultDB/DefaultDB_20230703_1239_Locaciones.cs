using FluentMigrator;

namespace omnes.Migrations.DefaultDB
{
    [Migration(20230703_1239)]
    public class DefaultDB_20230703_1239_Locaciones : AutoReversingMigration
    {
        public override void Up()
        {
            Create.Table("Paises")
                .WithColumn("IdPais").AsInt32().Identity().PrimaryKey().NotNullable()
                .WithColumn("NombrePais").AsString(200).NotNullable()
                .WithColumn("Baja").AsBoolean().NotNullable().WithDefaultValue(false);


            Create.Table("Provincias")
                .WithColumn("IdProvincia").AsInt32().Identity().PrimaryKey().NotNullable()
                .WithColumn("NombreProvincia").AsString(200).NotNullable()
                .WithColumn("Baja").AsBoolean().NotNullable().WithDefaultValue(false)
                .WithColumn("IdPais").AsInt32().NotNullable()
                    .ForeignKey("FK_Provincias_Paises", "Paises", "IdPais");

            Create.Table("Localidades")
                .WithColumn("IdLocalidad").AsInt32().Identity().PrimaryKey().NotNullable()
                .WithColumn("NombreLocalidad").AsString(200).NotNullable()
                .WithColumn("Baja").AsBoolean().NotNullable().WithDefaultValue(false)
                .WithColumn("IdProvincia").AsInt32().NotNullable()
                    .ForeignKey("FK_Provincias_Provincias", "Provincias", "IdProvincia")
                .WithColumn("IdPais").AsInt32().NotNullable()
                    .ForeignKey("FK_Localidades_Paises", "Paises", "IdPais");

            Create.Table("CodigosPostales")
                .WithColumn("IdCodPostal").AsInt32().Identity().PrimaryKey().NotNullable()
                .WithColumn("CodPostal").AsString(200).NotNullable()
                .WithColumn("Baja").AsBoolean().NotNullable().WithDefaultValue(false)
                .WithColumn("IdLocalidad").AsInt32().NotNullable()
                    .ForeignKey("FK_CodigosPostales_Localidades", "Localidades", "IdLocalidad")
                .WithColumn("IdProvincia").AsInt32().NotNullable()
                    .ForeignKey("FK_CodigosPostales_Provincias", "Provincias", "IdProvincia")
                .WithColumn("IdPais").AsInt32().NotNullable()
                    .ForeignKey("FK_CodigosPostales_Paises", "Paises", "IdPais");

        }
    }
}