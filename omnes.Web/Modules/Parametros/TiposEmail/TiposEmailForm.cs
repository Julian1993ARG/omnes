using Serenity.ComponentModel;

namespace omnes.Parametros.Forms;

[FormScript("Parametros.TiposEmail")]
[BasedOnRow(typeof(TiposEmailRow), CheckNames = true)]
public class TiposEmailForm
{
    public string NombreTipoEmail { get; set; }
}