using Serenity.ComponentModel;
using System.ComponentModel;

namespace omnes.Parametros.Columns;

[ColumnsScript("Parametros.TiposTelefono")]
[BasedOnRow(typeof(TiposTelefonoRow), CheckNames = true)]
public class TiposTelefonoColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    public int IdTipoTelefono { get; set; }
    [EditLink]
    public string NombreTipoTelefono { get; set; }
}