using Serenity.ComponentModel;
using System.ComponentModel;

namespace omnes.Parametros.Columns;

[ColumnsScript("Parametros.Localidades")]
[BasedOnRow(typeof(LocalidadesRow), CheckNames = true)]
public class LocalidadesColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    public int IdLocalidad { get; set; }
    [EditLink]
    public string NombreLocalidad { get; set; }
    public bool Baja { get; set; }
    public string IdProvinciaNombreProvincia { get; set; }
    public string IdPaisNombrePais { get; set; }
}