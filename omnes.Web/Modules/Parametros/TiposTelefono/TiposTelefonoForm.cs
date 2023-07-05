using Serenity.ComponentModel;

namespace omnes.Parametros.Forms;

[FormScript("Parametros.TiposTelefono")]
[BasedOnRow(typeof(TiposTelefonoRow), CheckNames = true)]
public class TiposTelefonoForm
{
    public string NombreTipoTelefono { get; set; }
}