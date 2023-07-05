using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<omnes.Parametros.TiposTelefonoRow>;
using MyRow = omnes.Parametros.TiposTelefonoRow;

namespace omnes.Parametros;

public interface ITiposTelefonoRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

public class TiposTelefonoRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, ITiposTelefonoRetrieveHandler
{
    public TiposTelefonoRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}