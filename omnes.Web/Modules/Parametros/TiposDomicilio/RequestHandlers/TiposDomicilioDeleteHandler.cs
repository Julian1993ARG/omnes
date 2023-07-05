using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = omnes.Parametros.TiposDomicilioRow;

namespace omnes.Parametros;

public interface ITiposDomicilioDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

public class TiposDomicilioDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, ITiposDomicilioDeleteHandler
{
    public TiposDomicilioDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}