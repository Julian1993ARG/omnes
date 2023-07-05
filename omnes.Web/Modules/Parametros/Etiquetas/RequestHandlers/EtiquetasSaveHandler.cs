using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<omnes.Parametros.EtiquetasRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = omnes.Parametros.EtiquetasRow;

namespace omnes.Parametros;

public interface IEtiquetasSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

public class EtiquetasSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IEtiquetasSaveHandler
{
    public EtiquetasSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}