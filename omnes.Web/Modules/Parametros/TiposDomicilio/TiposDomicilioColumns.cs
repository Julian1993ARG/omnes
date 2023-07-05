using Serenity.ComponentModel;
using System.ComponentModel;

namespace omnes.Parametros.Columns;

[ColumnsScript("Parametros.TiposDomicilio")]
[BasedOnRow(typeof(TiposDomicilioRow), CheckNames = true)]
public class TiposDomicilioColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    public int IdTipoDomicilio { get; set; }
    [EditLink]
    public string NombreTipoDomicilio { get; set; }
}