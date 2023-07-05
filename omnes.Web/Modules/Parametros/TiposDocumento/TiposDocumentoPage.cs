using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace omnes.Parametros.Pages;

[PageAuthorize(typeof(TiposDocumentoRow))]
public class TiposDocumentoPage : Controller
{
    [Route("Parametros/TiposDocumento")]
    public ActionResult Index()
    {
        return this.GridPage("@/Parametros/TiposDocumento/TiposDocumentoPage",
            TiposDocumentoRow.Fields.PageTitle());
    }
}