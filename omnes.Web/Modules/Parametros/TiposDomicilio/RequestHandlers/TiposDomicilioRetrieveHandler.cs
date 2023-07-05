using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<omnes.Parametros.TiposDomicilioRow>;
using MyRow = omnes.Parametros.TiposDomicilioRow;

namespace omnes.Parametros;

public interface ITiposDomicilioRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

public class TiposDomicilioRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, ITiposDomicilioRetrieveHandler
{
    public TiposDomicilioRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}