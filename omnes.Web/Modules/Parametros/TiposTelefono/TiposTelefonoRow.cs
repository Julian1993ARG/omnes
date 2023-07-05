using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System.ComponentModel;

namespace omnes.Parametros;

[ConnectionKey("Default"), Module("Parametros"), TableName("TiposTelefono")]
[DisplayName("Tipos Telefono"), InstanceName("Tipos Telefono")]
[ReadPermission("SuperAdmin")]
[ModifyPermission("SuperAdmin")]
public sealed partial class TiposTelefonoRow : Row<TiposTelefonoRow.RowFields>, IIdRow, INameRow
{
    class RowTemplate
    {
        [DisplayName("Id Tipo Telefono"), Identity, IdProperty]
        public int? IdTipoTelefono { get; set; }

        [DisplayName("Nombre Tipo Telefono"), Size(100), NotNull, QuickSearch, NameProperty]
        public string NombreTipoTelefono { get; set; }
    }
}