using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace omnes.Parametros.Pages;

[PageAuthorize(typeof(TiposTelefonoRow))]
public class TiposTelefonoPage : Controller
{
    [Route("Parametros/TiposTelefono")]
    public ActionResult Index()
    {
        return this.GridPage("@/Parametros/TiposTelefono/TiposTelefonoPage",
            TiposTelefonoRow.Fields.PageTitle());
    }
}