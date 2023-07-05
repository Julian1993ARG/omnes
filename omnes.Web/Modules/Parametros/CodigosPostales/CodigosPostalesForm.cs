using Serenity.ComponentModel;

namespace omnes.Parametros.Forms;

[FormScript("Parametros.CodigosPostales")]
[BasedOnRow(typeof(CodigosPostalesRow), CheckNames = true)]
public class CodigosPostalesForm
{
    public string CodPostal { get; set; }
    public bool Baja { get; set; }
    public int IdLocalidad { get; set; }
    public int IdProvincia { get; set; }
    public int IdPais { get; set; }
}