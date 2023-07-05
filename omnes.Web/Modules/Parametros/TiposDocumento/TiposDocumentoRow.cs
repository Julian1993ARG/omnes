using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System.ComponentModel;

namespace omnes.Parametros;

[ConnectionKey("Default"), Module("Parametros"), TableName("TiposDocumento")]
[DisplayName("Tipos Documento"), InstanceName("Tipos Documento")]
[ReadPermission("SuperAdmin")]
[ModifyPermission("SuperAdmin")]
public sealed partial class TiposDocumentoRow : Row<TiposDocumentoRow.RowFields>, IIdRow, INameRow
{
    class RowTemplate
    {
        [DisplayName("Id Tipo Documento"), Identity, IdProperty]
        public int? IdTipoDocumento { get; set; }

        [DisplayName("Nombre Tipo Documento"), Size(200), NotNull, QuickSearch, NameProperty]
        public string NombreTipoDocumento { get; set; }

        [DisplayName("Baja"), NotNull]
        public bool? Baja { get; set; }

        [DisplayName("Sigla"), Size(50), NotNull]
        public string Sigla { get; set; }
    }
}