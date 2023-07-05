using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace omnes.Parametros.Pages;

[PageAuthorize(typeof(EstadosCivilesRow))]
public class EstadosCivilesPage : Controller
{
    [Route("Parametros/EstadosCiviles")]
    public ActionResult Index()
    {
        return this.GridPage("@/Parametros/EstadosCiviles/EstadosCivilesPage",
            EstadosCivilesRow.Fields.PageTitle());
    }
}