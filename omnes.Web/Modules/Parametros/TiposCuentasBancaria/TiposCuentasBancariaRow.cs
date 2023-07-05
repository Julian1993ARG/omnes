using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System.ComponentModel;

namespace omnes.Parametros;

[ConnectionKey("Default"), Module("Parametros"), TableName("TiposCuentasBancaria")]
[DisplayName("Tipos Cuentas Bancaria"), InstanceName("Tipos Cuentas Bancaria")]
[ReadPermission("SuperAdmin")]
[ModifyPermission("SuperAdmin")]
public sealed partial class TiposCuentasBancariaRow : Row<TiposCuentasBancariaRow.RowFields>, IIdRow, INameRow
{
    class RowTemplate
    {
        [DisplayName("Id Tipo Cuenta Bancaria"), Identity, IdProperty]
        public int? IdTipoCuentaBancaria { get; set; }

        [DisplayName("Descripcion"), Size(100), NotNull, QuickSearch, NameProperty]
        public string Descripcion { get; set; }

        [DisplayName("Baja"), NotNull]
        public bool? Baja { get; set; }

        [DisplayName("Observaciones")]
        public string Observaciones { get; set; }
    }
}