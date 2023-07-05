using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace omnes.Parametros.Pages;

[PageAuthorize(typeof(TiposCuentasBancariaRow))]
public class TiposCuentasBancariaPage : Controller
{
    [Route("Parametros/TiposCuentasBancaria")]
    public ActionResult Index()
    {
        return this.GridPage("@/Parametros/TiposCuentasBancaria/TiposCuentasBancariaPage",
            TiposCuentasBancariaRow.Fields.PageTitle());
    }
}