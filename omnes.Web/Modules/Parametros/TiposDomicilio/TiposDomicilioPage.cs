using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace omnes.Parametros.Pages;

[PageAuthorize(typeof(TiposDomicilioRow))]
public class TiposDomicilioPage : Controller
{
    [Route("Parametros/TiposDomicilio")]
    public ActionResult Index()
    {
        return this.GridPage("@/Parametros/TiposDomicilio/TiposDomicilioPage",
            TiposDomicilioRow.Fields.PageTitle());
    }
}