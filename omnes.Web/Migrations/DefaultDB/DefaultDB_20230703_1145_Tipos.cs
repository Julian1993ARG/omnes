using FluentMigrator;


namespace omnes.Migrations.DefaultDB
{
    [Migration(20230703_1145)]
    public class DefaultDB_20230703_1145_Tipos : AutoReversingMigration
    {
        public override void Up()
        {
            Create.Table("TiposDocumento")
                .WithColumn("IdTipoDocumento").AsInt32().Identity().PrimaryKey().NotNullable()
                .WithColumn("NombreTipoDocumento").AsString(200).NotNullable()
                .WithColumn("Baja").AsBoolean().NotNullable().WithDefaultValue(false)
                .WithColumn("Sigla").AsString(50).NotNullable();

            Insert.IntoTable("TiposDocumento").Row(new
            {
                NombreTipoDocumento = "Documento Nacional de Identidad",
                Sigla = "D.N.I."
            }).Row(new
            {
                NombreTipoDocumento = "Cédula de Identidad",
                Sigla = "C.I."
            }).Row(new
            {
                NombreTipoDocumento = "Pasaporte",
                Sigla = "PAS"
            }).Row(new
            {
                NombreTipoDocumento = "Otro",
                Sigla = "Otr."
            });
            //***********************************************************

            Create.Table("TiposEmail")
                .WithColumn("IdTipoEmail").AsInt32().Identity().PrimaryKey().NotNullable()
                .WithColumn("NombreTipoEmail").AsString(100).NotNullable();

            Insert.IntoTable("TiposEmail").Row(new
            {
                NombreTipoEmail = "PERSONAL"
            }).Row(new
            {
                NombreTipoEmail = "CORPORATIVO"
            }).Row(new
            {
                NombreTipoEmail = "OTRO"
            });
            //***************************************************************

            Create.Table("TiposTelefono")
                .WithColumn("IdTipoTelefono").AsInt32().Identity().PrimaryKey().NotNullable()
                .WithColumn("NombreTipoTelefono").AsString(100).NotNullable();

            Insert.IntoTable("TiposTelefono").Row(new
            {
                NombreTipoTelefono="CELULAR PERSONAL"
            }).Row(new
            {
                NombreTipoTelefono = "CELULAR CORPORATIVO"
            }).Row(new
            {
                NombreTipoTelefono = "FIJO CASA"
            }).Row(new
            {
                NombreTipoTelefono = "FIJO OFICINA"
            }).Row(new
            {
                NombreTipoTelefono = "OTRO"
            });
            //***************************************************************

            Create.Table("TiposDomicilio")
                .WithColumn("IdTipoDomicilio").AsInt32().Identity().PrimaryKey().NotNullable()
                .WithColumn("NombreTipoDomicilio").AsString(100).NotNullable();

            Insert.IntoTable("TiposDomicilio").Row(new
            {
                NombreTipoDomicilio = "LABORAL"
            }).Row(new
            {
                NombreTipoDomicilio = "PERSONAL PRINCIPAL"
            }).Row(new
            {
                NombreTipoDomicilio = "PERSONAL SECUNDARIO"
            }).Row(new
            {
                NombreTipoDomicilio = "ENVIO"
            });
            //***************************************************************

            Create.Table("TiposCuentasBancaria")
                .WithColumn("IdTipoCuentaBancaria").AsInt32().Identity().PrimaryKey().NotNullable()
                .WithColumn("Descripcion").AsString(100).NotNullable()
                .WithColumn("Baja").AsBoolean().NotNullable().WithDefaultValue(false)
                .WithColumn("Observaciones").AsString(int.MaxValue).Nullable();

            Insert.IntoTable("TiposCuentasBancaria").Row(new
            {
                Descripcion ="CAJA DE AHORRO EN MONEDA LOCAL"
            }).Row(new
            {
                Descripcion = "CAJA DE AHORRO EN MONEDA EXTRANJERA"
            }).Row(new
            {
                Descripcion = "CUENTA CORRIENTE"
            });
            //***************************************************************

            Create.Table("EstadosCiviles")
               .WithColumn("IdEstadoCivil").AsInt32().Identity().PrimaryKey().NotNullable()
               .WithColumn("DescripcionEstadoCivil").AsString(100).NotNullable()
               .WithColumn("Baja").AsBoolean().NotNullable().WithDefaultValue(false);

            Insert.IntoTable("EstadosCiviles").Row(new
            {
                DescripcionEstadoCivil ="SOLTERO/A"
            }).Row(new
            {
                DescripcionEstadoCivil = "CASADO/A"
            }).Row(new
            {
                DescripcionEstadoCivil = "DIVORCIADO/A"
            }).Row(new
            {
                DescripcionEstadoCivil = "VIUDO/A"
            });
            //***************************************************************

            Create.Table("NivelesFormacion")
             .WithColumn("IdNivelFormacion").AsInt32().Identity().PrimaryKey().NotNullable()
             .WithColumn("DescripcionNivelFormacion").AsString(100).NotNullable()
             .WithColumn("Baja").AsBoolean().NotNullable().WithDefaultValue(false);

            Insert.IntoTable("NivelesFormacion").Row(new
            {
                DescripcionNivelFormacion = "PRIMARIO INCOMPLETO"
            }).Row(new
            {
                DescripcionNivelFormacion = "PRIMARIO COMPLETO"
            }).Row(new
            {
                DescripcionNivelFormacion = "SECUNDARIO INCOMPLETO"
            }).Row(new
            {
                DescripcionNivelFormacion = "SECUNDARIO COMPLETO"
            }).Row(new
            {
                DescripcionNivelFormacion = "UNIVERSITARIO INCOMPLETO"
            }).Row(new
            {
                DescripcionNivelFormacion = "UNIVERSITARIO COMPLETO"
            }).Row(new
            {
                DescripcionNivelFormacion = "POSTGRADO - ESPECIALIZACIÓN"
            }).Row(new
            {
                DescripcionNivelFormacion = "POSTGRADO - MAESTRÍA"
            }).Row(new
            {
                DescripcionNivelFormacion = "POSTGRADO DOCTORADO"
            }).Row(new
            {
                DescripcionNivelFormacion = "POSTGRADO PhD"
            });

        }
    }
}