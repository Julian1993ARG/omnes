using FluentMigrator;

namespace omnes.Migrations.DefaultDB
{
    [Migration(20230703_1137)]
    public class DefaultDB_20230703_1137_Etiquetas : AutoReversingMigration
    {
        public override void Up()
        {
            Create.Table("Etiquetas")
                .WithColumn("IdEtiqueta").AsInt32().Identity().PrimaryKey().NotNullable()
                .WithColumn("Descripcion").AsString(200).NotNullable()
                .WithColumn("Baja").AsBoolean().NotNullable().WithDefaultValue(false)
                .WithColumn("Observaciones").AsString(int.MaxValue).NotNullable()
                .WithColumn("IdTennant").AsInt32().NotNullable()
                    .ForeignKey("FK_Etiquetas_Tennants", "Tennants", "IdTennant");
        }
    }
}