using Serenity.ComponentModel;
using System.ComponentModel;

namespace omnes.Parametros.Columns;

[ColumnsScript("Parametros.Paises")]
[BasedOnRow(typeof(PaisesRow), CheckNames = true)]
public class PaisesColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    public int IdPais { get; set; }
    [EditLink]
    public string NombrePais { get; set; }
    public bool Baja { get; set; }
}