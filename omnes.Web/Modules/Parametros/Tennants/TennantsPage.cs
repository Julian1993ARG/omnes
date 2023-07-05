using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace omnes.Parametros.Pages;

[PageAuthorize(typeof(TennantsRow))]
public class TennantsPage : Controller
{
    [Route("Parametros/Tennants")]
    public ActionResult Index()
    {
        return this.GridPage("@/Parametros/Tennants/TennantsPage",
            TennantsRow.Fields.PageTitle());
    }
}