using Serenity.ComponentModel;
using System.ComponentModel;

namespace omnes.Parametros.Columns;

[ColumnsScript("Parametros.TiposEmail")]
[BasedOnRow(typeof(TiposEmailRow), CheckNames = true)]
public class TiposEmailColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    public int IdTipoEmail { get; set; }
    [EditLink]
    public string NombreTipoEmail { get; set; }
}