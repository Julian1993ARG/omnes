using Serenity.ComponentModel;
using System.ComponentModel;

namespace omnes.Parametros.Columns;

[ColumnsScript("Parametros.AreasTrabajo")]
[BasedOnRow(typeof(AreasTrabajoRow), CheckNames = true)]
public class AreasTrabajoColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    public int IdAreaTrabajo { get; set; }
    public string IdTennantDescripcion { get; set; }
    public string IdEmpresaRazonSocial { get; set; }
    [EditLink]
    public string Descripcion { get; set; }
    public bool Baja { get; set; }
}