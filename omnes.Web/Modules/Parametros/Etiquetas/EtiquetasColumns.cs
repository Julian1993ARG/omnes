using Serenity.ComponentModel;
using System.ComponentModel;

namespace omnes.Parametros.Columns;

[ColumnsScript("Parametros.Etiquetas")]
[BasedOnRow(typeof(EtiquetasRow), CheckNames = true)]
public class EtiquetasColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    public int IdEtiqueta { get; set; }
    [EditLink]
    public string Descripcion { get; set; }
    public bool Baja { get; set; }
    public string Observaciones { get; set; }
    public string IdTennantDescripcion { get; set; }
}