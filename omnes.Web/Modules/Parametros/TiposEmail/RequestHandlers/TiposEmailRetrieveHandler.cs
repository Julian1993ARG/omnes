using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<omnes.Parametros.TiposEmailRow>;
using MyRow = omnes.Parametros.TiposEmailRow;

namespace omnes.Parametros;

public interface ITiposEmailRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

public class TiposEmailRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, ITiposEmailRetrieveHandler
{
    public TiposEmailRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}