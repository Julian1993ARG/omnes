using Serenity.ComponentModel;

namespace omnes.Parametros.Forms;

[FormScript("Parametros.Etiquetas")]
[BasedOnRow(typeof(EtiquetasRow), CheckNames = true)]
public class EtiquetasForm
{
    public string Descripcion { get; set; }
    public bool Baja { get; set; }
    public string Observaciones { get; set; }
    public int IdTennant { get; set; }
}