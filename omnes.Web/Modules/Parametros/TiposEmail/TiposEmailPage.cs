using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace omnes.Parametros.Pages;

[PageAuthorize(typeof(TiposEmailRow))]
public class TiposEmailPage : Controller
{
    [Route("Parametros/TiposEmail")]
    public ActionResult Index()
    {
        return this.GridPage("@/Parametros/TiposEmail/TiposEmailPage",
            TiposEmailRow.Fields.PageTitle());
    }
}