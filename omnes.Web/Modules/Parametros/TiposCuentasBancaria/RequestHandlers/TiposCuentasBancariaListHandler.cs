using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<omnes.Parametros.TiposCuentasBancariaRow>;
using MyRow = omnes.Parametros.TiposCuentasBancariaRow;

namespace omnes.Parametros;

public interface ITiposCuentasBancariaListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

public class TiposCuentasBancariaListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, ITiposCuentasBancariaListHandler
{
    public TiposCuentasBancariaListHandler(IRequestContext context)
            : base(context)
    {
    }
}