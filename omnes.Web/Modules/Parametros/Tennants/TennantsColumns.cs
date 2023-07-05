using Serenity.ComponentModel;
using System.ComponentModel;

namespace omnes.Parametros.Columns;

[ColumnsScript("Parametros.Tennants")]
[BasedOnRow(typeof(TennantsRow), CheckNames = true)]
public class TennantsColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    public int IdTennant { get; set; }
    [EditLink]
    public string Descripcion { get; set; }
    public bool Baja { get; set; }
    public string Observaciones { get; set; }
}