using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace omnes.Parametros.Pages;

[PageAuthorize(typeof(EmpresasRow))]
public class EmpresasPage : Controller
{
    [Route("Parametros/Empresas")]
    public ActionResult Index()
    {
        return this.GridPage("@/Parametros/Empresas/EmpresasPage",
            EmpresasRow.Fields.PageTitle());
    }
}