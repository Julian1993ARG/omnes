using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace omnes.Parametros.Pages;

[PageAuthorize(typeof(AreasTrabajoRow))]
public class AreasTrabajoPage : Controller
{
    [Route("Parametros/AreasTrabajo")]
    public ActionResult Index()
    {
        return this.GridPage("@/Parametros/AreasTrabajo/AreasTrabajoPage",
            AreasTrabajoRow.Fields.PageTitle());
    }
}