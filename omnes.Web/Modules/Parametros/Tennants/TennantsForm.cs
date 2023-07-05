using Serenity.ComponentModel;

namespace omnes.Parametros.Forms;

[FormScript("Parametros.Tennants")]
[BasedOnRow(typeof(TennantsRow), CheckNames = true)]
public class TennantsForm
{
    public string Descripcion { get; set; }
    public bool Baja { get; set; }
    public string Observaciones { get; set; }
}