using Serenity.ComponentModel;

namespace omnes.Parametros.Forms;

[FormScript("Parametros.TiposDomicilio")]
[BasedOnRow(typeof(TiposDomicilioRow), CheckNames = true)]
public class TiposDomicilioForm
{
    public string NombreTipoDomicilio { get; set; }
}