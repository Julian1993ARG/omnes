using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<omnes.Parametros.TiposDocumentoRow>;
using MyRow = omnes.Parametros.TiposDocumentoRow;

namespace omnes.Parametros;

public interface ITiposDocumentoRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

public class TiposDocumentoRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, ITiposDocumentoRetrieveHandler
{
    public TiposDocumentoRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}