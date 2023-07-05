using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System.ComponentModel;

namespace omnes.Parametros;

[ConnectionKey("Default"), Module("Parametros"), TableName("EstadosCiviles")]
[DisplayName("Estados Civiles"), InstanceName("Estados Civiles")]
[ReadPermission("SuperAdmin")]
[ModifyPermission("SuperAdmin")]
public sealed partial class EstadosCivilesRow : Row<EstadosCivilesRow.RowFields>, IIdRow, INameRow
{
    class RowTemplate
    {
        [DisplayName("Id Estado Civil"), Identity, IdProperty]
        public int? IdEstadoCivil { get; set; }

        [DisplayName("Descripcion Estado Civil"), Size(100), NotNull, QuickSearch, NameProperty]
        public string DescripcionEstadoCivil { get; set; }

        [DisplayName("Baja"), NotNull]
        public bool? Baja { get; set; }
    }
}