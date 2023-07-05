using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System.ComponentModel;

namespace omnes.Parametros;

[ConnectionKey("Default"), Module("Parametros"), TableName("TiposEmail")]
[DisplayName("Tipos Email"), InstanceName("Tipos Email")]
[ReadPermission("SuperAdmin")]
[ModifyPermission("SuperAdmin")]
public sealed partial class TiposEmailRow : Row<TiposEmailRow.RowFields>, IIdRow, INameRow
{
    class RowTemplate
    {
        [DisplayName("Id Tipo Email"), Identity, IdProperty]
        public int? IdTipoEmail { get; set; }

        [DisplayName("Nombre Tipo Email"), Size(100), NotNull, QuickSearch, NameProperty]
        public string NombreTipoEmail { get; set; }
    }
}