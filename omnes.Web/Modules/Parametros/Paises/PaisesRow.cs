using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System.ComponentModel;

namespace omnes.Parametros;

[ConnectionKey("Default"), Module("Parametros"), TableName("Paises")]
[DisplayName("Paises"), InstanceName("Paises")]
[ReadPermission("SuperAdmin")]
[ModifyPermission("SuperAdmin")]
public sealed partial class PaisesRow : Row<PaisesRow.RowFields>, IIdRow, INameRow
{
    class RowTemplate
    {
        [DisplayName("Id Pais"), Identity, IdProperty]
        public int? IdPais { get; set; }

        [DisplayName("Nombre Pais"), Size(200), NotNull, QuickSearch, NameProperty]
        public string NombrePais { get; set; }

        [DisplayName("Baja"), NotNull]
        public bool? Baja { get; set; }
    }
}