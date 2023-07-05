using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<omnes.Parametros.TiposTelefonoRow>;
using MyRow = omnes.Parametros.TiposTelefonoRow;

namespace omnes.Parametros;

public interface ITiposTelefonoListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

public class TiposTelefonoListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, ITiposTelefonoListHandler
{
    public TiposTelefonoListHandler(IRequestContext context)
            : base(context)
    {
    }
}