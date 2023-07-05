using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace omnes.Parametros.Pages;

[PageAuthorize(typeof(PaisesRow))]
public class PaisesPage : Controller
{
    [Route("Parametros/Paises")]
    public ActionResult Index()
    {
        return this.GridPage("@/Parametros/Paises/PaisesPage",
            PaisesRow.Fields.PageTitle());
    }
}