using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System.ComponentModel;

namespace omnes.Parametros;

[ConnectionKey("Default"), Module("Parametros"), TableName("Tennants")]
[DisplayName("Tennants"), InstanceName("Tennants")]
[ReadPermission("SuperAdmin")]
[ModifyPermission("SuperAdmin")]
public sealed partial class TennantsRow : Row<TennantsRow.RowFields>, IIdRow, INameRow
{
    class RowTemplate
    {
        [DisplayName("Id Tennant"), Identity, IdProperty]
        public int? IdTennant { get; set; }

        [DisplayName("Descripcion"), Size(200), NotNull, QuickSearch, NameProperty]
        public string Descripcion { get; set; }

        [DisplayName("Baja"), NotNull]
        public bool? Baja { get; set; }

        [DisplayName("Observaciones"), NotNull]
        public string Observaciones { get; set; }
    }
}