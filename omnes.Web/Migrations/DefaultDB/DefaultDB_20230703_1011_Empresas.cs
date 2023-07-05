using FluentMigrator;

namespace omnes.Migrations.DefaultDB
{
    [Migration(20230703_1011)]
    public class DefaultDB_20230703_1011_Empresas : AutoReversingMigration
    {
        public override void Up()
        {
            Create.Table("Tennants")
                .WithColumn("IdTennant").AsInt32().Identity().PrimaryKey().NotNullable()
                .WithColumn("Descripcion").AsString(200).NotNullable()
                .WithColumn("Baja").AsBoolean().NotNullable().WithDefaultValue(false)
                .WithColumn("Observaciones").AsString(int.MaxValue).NotNullable();

            //******************************************************************************************************

            Create.Table("Empresas")
                .WithColumn("IdEmpresa").AsInt32().Identity().PrimaryKey().NotNullable()
                .WithColumn("IdTennant").AsInt32().NotNullable()
                   .ForeignKey("FK_Empresas_Tennants", "Tennants", "IdTennant")
                .WithColumn("RazonSocial").AsString(150).NotNullable()
                .WithColumn("Cuit").AsString(15).NotNullable()
                .WithColumn("InicioActividades").AsDate().Nullable()
                .WithColumn("DireccionUrl").AsString(int.MaxValue).Nullable()
                .WithColumn("NombreFantasia").AsString(int.MaxValue).Nullable()
                .WithColumn("Mail").AsString(255).NotNullable()
                .WithColumn("NombreContacto").AsString(50).Nullable()
                .WithColumn("Telefono").AsString(50).Nullable()
                .WithColumn("Calle").AsString(200).Nullable()
                .WithColumn("Altura").AsString(50).Nullable()
                .WithColumn("Piso").AsString(50).Nullable()
                .WithColumn("Dpto").AsString(50).Nullable()
                .WithColumn("Latitud").AsString(200).Nullable()
                .WithColumn("Longitud").AsString(200).Nullable()
                .WithColumn("OtraReferencia").AsString(int.MaxValue).Nullable()
                .WithColumn("IdLocalidad").AsInt32().NotNullable()
                .WithColumn("IdCodPost").AsInt32().Nullable()
                   .ForeignKey("FK_Empresas_CodigosPostales", "CodigosPostales", "IdCodPostal")
                    .ForeignKey("Empresas_Localidades", "Localidades", "IdLocalidad")
                .WithColumn("IdProvincia").AsInt32().NotNullable()
                    .ForeignKey("Empresas_Provincias", "Provincias", "IdProvincia")
                .WithColumn("IdPais").AsInt32().NotNullable()
                    .ForeignKey("Empresas_Paises", "Paises", "IdPais")
                .WithColumn("Logo").AsString(int.MaxValue).Nullable()
                .WithColumn("DocumentosRelacionados").AsString(int.MaxValue).Nullable()
                .WithColumn("Baja").AsBoolean().NotNullable().WithDefaultValue(false)
                .WithColumn("Observaciones").AsString(int.MaxValue).NotNullable();

            //******************************************************************************************************

            Create.Table("AreasTrabajo")
               .WithColumn("IdAreaTrabajo").AsInt32().Identity().PrimaryKey().NotNullable()
               .WithColumn("IdTennant").AsInt32().NotNullable()
                   .ForeignKey("FK_AreasTrabajo_Tennants", "Tennants", "IdTennant")
               .WithColumn("IdEmpresa").AsInt32().Nullable()
                   .ForeignKey("FK_AreasTrabajo_Empresas", "Empresas", "IdEmpresa")
               .WithColumn("Descripcion").AsString(200).NotNullable()
               .WithColumn("Baja").AsBoolean().NotNullable().WithDefaultValue(false);

            //Insert.IntoTable("AreasTrabajo").Row(new
            //{
            //    Descripcion = "BASE DE DATOS",
            //}).Row(new
            //{
            //    Descripcion = "DESARROLLO",
            //}).Row(new
            //{
            //    Descripcion = "ADMINISTRACION",
            //}).Row(new
            //{
            //    Descripcion = "GERENCIA",
            //}).Row(new
            //{
            //    Descripcion = "RR.HH.",
            //}).Row(new
            //{
            //    Descripcion = "I.T.",
            //}).Row(new
            //{
            //    Descripcion = "CIBERSEGURIDAD",
            //});

            //******************************************************************************************************

            Create.Table("ModalidadesContrato")
             .WithColumn("IdModalidadContrato").AsInt32().Identity().PrimaryKey().NotNullable()
             .WithColumn("DescripcionModalidadContrato").AsString(100).NotNullable()
             .WithColumn("Baja").AsBoolean().NotNullable().WithDefaultValue(false)
             .WithColumn("Observaciones").AsString(int.MaxValue).Nullable()
             .WithColumn("IdEmpresa").AsInt32().Nullable()
                .ForeignKey("FK_ModalidadesContrato_Empresas", "Empresas", "IdEmpresa")
             .WithColumn("IdTennant").AsInt32().NotNullable()
                .ForeignKey("FK_ModalidadesContrato_Tennants", "Tennants", "IdTennant");

            //Insert.IntoTable("ModalidadesContrato").Row(new
            //{
            //    DescripcionModalidadContrato = "CONTRATO PERIODO INDEFINIDO MEDIA JORNADA"
            //}).Row(new
            //{
            //    DescripcionModalidadContrato = "CONTRATO PERIODO INDEFINIDO JORNADA COMPLETA"
            //}).Row(new
            //{
            //    DescripcionModalidadContrato = "CONTRATO PERIODO DEFINIDO"
            //}).Row(new
            //{
            //    DescripcionModalidadContrato = "CONSULTOR EXTERNO"
            //}).Row(new
            //{
            //    DescripcionModalidadContrato = "OTRO"
            //});

        }
    }
}