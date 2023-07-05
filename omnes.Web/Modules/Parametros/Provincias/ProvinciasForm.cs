using Serenity.ComponentModel;

namespace omnes.Parametros.Forms;

[FormScript("Parametros.Provincias")]
[BasedOnRow(typeof(ProvinciasRow), CheckNames = true)]
public class ProvinciasForm
{
    public string NombreProvincia { get; set; }
    public bool Baja { get; set; }
    public int IdPais { get; set; }
}