using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace omnes.Parametros.Pages;

[PageAuthorize(typeof(ProvinciasRow))]
public class ProvinciasPage : Controller
{
    [Route("Parametros/Provincias")]
    public ActionResult Index()
    {
        return this.GridPage("@/Parametros/Provincias/ProvinciasPage",
            ProvinciasRow.Fields.PageTitle());
    }
}