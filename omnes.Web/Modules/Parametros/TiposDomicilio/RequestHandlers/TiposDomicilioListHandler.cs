using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<omnes.Parametros.TiposDomicilioRow>;
using MyRow = omnes.Parametros.TiposDomicilioRow;

namespace omnes.Parametros;

public interface ITiposDomicilioListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

public class TiposDomicilioListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, ITiposDomicilioListHandler
{
    public TiposDomicilioListHandler(IRequestContext context)
            : base(context)
    {
    }
}