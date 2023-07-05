using Serenity.ComponentModel;

namespace omnes.Parametros.Forms;

[FormScript("Parametros.TiposDocumento")]
[BasedOnRow(typeof(TiposDocumentoRow), CheckNames = true)]
public class TiposDocumentoForm
{
    public string NombreTipoDocumento { get; set; }
    public bool Baja { get; set; }
    public string Sigla { get; set; }
}