using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<omnes.Parametros.TiposCuentasBancariaRow>;
using MyRow = omnes.Parametros.TiposCuentasBancariaRow;

namespace omnes.Parametros;

public interface ITiposCuentasBancariaRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

public class TiposCuentasBancariaRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, ITiposCuentasBancariaRetrieveHandler
{
    public TiposCuentasBancariaRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}