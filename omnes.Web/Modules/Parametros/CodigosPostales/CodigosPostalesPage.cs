using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace omnes.Parametros.Pages;

[PageAuthorize(typeof(CodigosPostalesRow))]
public class CodigosPostalesPage : Controller
{
    [Route("Parametros/CodigosPostales")]
    public ActionResult Index()
    {
        return this.GridPage("@/Parametros/CodigosPostales/CodigosPostalesPage",
            CodigosPostalesRow.Fields.PageTitle());
    }
}