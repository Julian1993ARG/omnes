using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace omnes.Parametros.Pages;

[PageAuthorize(typeof(LocalidadesRow))]
public class LocalidadesPage : Controller
{
    [Route("Parametros/Localidades")]
    public ActionResult Index()
    {
        return this.GridPage("@/Parametros/Localidades/LocalidadesPage",
            LocalidadesRow.Fields.PageTitle());
    }
}