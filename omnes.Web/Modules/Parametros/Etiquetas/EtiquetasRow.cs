using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System.ComponentModel;

namespace omnes.Parametros;

[ConnectionKey("Default"), Module("Parametros"), TableName("Etiquetas")]
[DisplayName("Etiquetas"), InstanceName("Etiquetas")]
[ReadPermission("RRHH")]
[ModifyPermission("RRHH")]
public sealed partial class EtiquetasRow : Row<EtiquetasRow.RowFields>, IIdRow, INameRow
{
    const string jIdTennant = nameof(jIdTennant);

    class RowTemplate
    {
        [DisplayName("Id Etiqueta"), Identity, IdProperty]
        public int? IdEtiqueta { get; set; }

        [DisplayName("Descripcion"), Size(200), NotNull, QuickSearch, NameProperty]
        public string Descripcion { get; set; }

        [DisplayName("Baja"), NotNull]
        public bool? Baja { get; set; }

        [DisplayName("Observaciones"), NotNull]
        public string Observaciones { get; set; }

        [DisplayName("Id Tennant"), NotNull, ForeignKey("Tennants", "IdTennant"), LeftJoin(jIdTennant), TextualField(nameof(IdTennantDescripcion))]
        public int? IdTennant { get; set; }

        [DisplayName("Id Tennant Descripcion"), Expression($"{jIdTennant}.[Descripcion]")]
        public string IdTennantDescripcion { get; set; }
    }
}