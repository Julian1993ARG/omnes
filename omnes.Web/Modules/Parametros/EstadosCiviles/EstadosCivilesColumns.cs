using Serenity.ComponentModel;
using System.ComponentModel;

namespace omnes.Parametros.Columns;

[ColumnsScript("Parametros.EstadosCiviles")]
[BasedOnRow(typeof(EstadosCivilesRow), CheckNames = true)]
public class EstadosCivilesColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    public int IdEstadoCivil { get; set; }
    [EditLink]
    public string DescripcionEstadoCivil { get; set; }
    public bool Baja { get; set; }
}