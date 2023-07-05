using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System.ComponentModel;

namespace omnes.Parametros;

[ConnectionKey("Default"), Module("Parametros"), TableName("TiposDomicilio")]
[DisplayName("Tipos Domicilio"), InstanceName("Tipos Domicilio")]
[ReadPermission("SuperAdmin")]
[ModifyPermission("SuperAdmin")]
public sealed partial class TiposDomicilioRow : Row<TiposDomicilioRow.RowFields>, IIdRow, INameRow
{
    class RowTemplate
    {
        [DisplayName("Id Tipo Domicilio"), Identity, IdProperty]
        public int? IdTipoDomicilio { get; set; }

        [DisplayName("Nombre Tipo Domicilio"), Size(100), NotNull, QuickSearch, NameProperty]
        public string NombreTipoDomicilio { get; set; }
    }
}