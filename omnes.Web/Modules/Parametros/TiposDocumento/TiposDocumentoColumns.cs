using Serenity.ComponentModel;
using System.ComponentModel;

namespace omnes.Parametros.Columns;

[ColumnsScript("Parametros.TiposDocumento")]
[BasedOnRow(typeof(TiposDocumentoRow), CheckNames = true)]
public class TiposDocumentoColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    public int IdTipoDocumento { get; set; }
    [EditLink]
    public string NombreTipoDocumento { get; set; }
    public bool Baja { get; set; }
    public string Sigla { get; set; }
}