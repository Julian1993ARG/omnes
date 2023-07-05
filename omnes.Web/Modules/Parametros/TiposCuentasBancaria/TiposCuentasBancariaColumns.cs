using Serenity.ComponentModel;
using System.ComponentModel;

namespace omnes.Parametros.Columns;

[ColumnsScript("Parametros.TiposCuentasBancaria")]
[BasedOnRow(typeof(TiposCuentasBancariaRow), CheckNames = true)]
public class TiposCuentasBancariaColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    public int IdTipoCuentaBancaria { get; set; }
    [EditLink]
    public string Descripcion { get; set; }
    public bool Baja { get; set; }
    public string Observaciones { get; set; }
}