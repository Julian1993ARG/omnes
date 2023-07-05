using Serenity.ComponentModel;

namespace omnes.Parametros.Forms;

[FormScript("Parametros.TiposCuentasBancaria")]
[BasedOnRow(typeof(TiposCuentasBancariaRow), CheckNames = true)]
public class TiposCuentasBancariaForm
{
    public string Descripcion { get; set; }
    public bool Baja { get; set; }
    public string Observaciones { get; set; }
}