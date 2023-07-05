using Serenity.ComponentModel;

namespace omnes.Parametros.Forms;

[FormScript("Parametros.Paises")]
[BasedOnRow(typeof(PaisesRow), CheckNames = true)]
public class PaisesForm
{
    public string NombrePais { get; set; }
    public bool Baja { get; set; }
}