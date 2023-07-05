using Serenity.ComponentModel;
using System.ComponentModel;

namespace omnes.Parametros.Columns;

[ColumnsScript("Parametros.Provincias")]
[BasedOnRow(typeof(ProvinciasRow), CheckNames = true)]
public class ProvinciasColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    public int IdProvincia { get; set; }
    [EditLink]
    public string NombreProvincia { get; set; }
    public bool Baja { get; set; }
    public string IdPaisNombrePais { get; set; }
}