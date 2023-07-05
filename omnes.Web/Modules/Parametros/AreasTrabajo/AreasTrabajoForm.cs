using Serenity.ComponentModel;

namespace omnes.Parametros.Forms;

[FormScript("Parametros.AreasTrabajo")]
[BasedOnRow(typeof(AreasTrabajoRow), CheckNames = true)]
public class AreasTrabajoForm
{
    public int IdTennant { get; set; }
    public int IdEmpresa { get; set; }
    public string Descripcion { get; set; }
    public bool Baja { get; set; }
}