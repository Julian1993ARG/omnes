using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = omnes.Parametros.TiposTelefonoRow;

namespace omnes.Parametros;

public interface ITiposTelefonoDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

public class TiposTelefonoDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, ITiposTelefonoDeleteHandler
{
    public TiposTelefonoDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}