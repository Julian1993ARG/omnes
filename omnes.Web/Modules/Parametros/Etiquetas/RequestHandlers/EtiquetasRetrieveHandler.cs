using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<omnes.Parametros.EtiquetasRow>;
using MyRow = omnes.Parametros.EtiquetasRow;

namespace omnes.Parametros;

public interface IEtiquetasRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

public class EtiquetasRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IEtiquetasRetrieveHandler
{
    public EtiquetasRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}