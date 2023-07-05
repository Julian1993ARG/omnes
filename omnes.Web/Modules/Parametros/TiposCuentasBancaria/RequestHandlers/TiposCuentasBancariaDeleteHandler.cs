using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = omnes.Parametros.TiposCuentasBancariaRow;

namespace omnes.Parametros;

public interface ITiposCuentasBancariaDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

public class TiposCuentasBancariaDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, ITiposCuentasBancariaDeleteHandler
{
    public TiposCuentasBancariaDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}