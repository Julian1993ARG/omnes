using Serenity.ComponentModel;

namespace omnes.Parametros.Forms;

[FormScript("Parametros.Localidades")]
[BasedOnRow(typeof(LocalidadesRow), CheckNames = true)]
public class LocalidadesForm
{
    public string NombreLocalidad { get; set; }
    public bool Baja { get; set; }
    public int IdProvincia { get; set; }
    public int IdPais { get; set; }
}