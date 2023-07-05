using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace omnes.Parametros.Pages;

[PageAuthorize(typeof(EtiquetasRow))]
public class EtiquetasPage : Controller
{
    [Route("Parametros/Etiquetas")]
    public ActionResult Index()
    {
        return this.GridPage("@/Parametros/Etiquetas/EtiquetasPage",
            EtiquetasRow.Fields.PageTitle());
    }
}