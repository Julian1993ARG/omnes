using Serenity.ComponentModel;

namespace omnes.Parametros.Forms;

[FormScript("Parametros.EstadosCiviles")]
[BasedOnRow(typeof(EstadosCivilesRow), CheckNames = true)]
public class EstadosCivilesForm
{
    public string DescripcionEstadoCivil { get; set; }
    public bool Baja { get; set; }
}