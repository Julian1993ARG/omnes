using Serenity.ComponentModel;
using System.ComponentModel;

namespace omnes.Parametros.Columns;

[ColumnsScript("Parametros.CodigosPostales")]
[BasedOnRow(typeof(CodigosPostalesRow), CheckNames = true)]
public class CodigosPostalesColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    public int IdCodPostal { get; set; }
    [EditLink]
    public string CodPostal { get; set; }
    public bool Baja { get; set; }
    public string IdLocalidadNombreLocalidad { get; set; }
    public string IdProvinciaNombreProvincia { get; set; }
    public string IdPaisNombrePais { get; set; }
}