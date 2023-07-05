using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<omnes.Parametros.TiposEmailRow>;
using MyRow = omnes.Parametros.TiposEmailRow;

namespace omnes.Parametros;

public interface ITiposEmailListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

public class TiposEmailListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, ITiposEmailListHandler
{
    public TiposEmailListHandler(IRequestContext context)
            : base(context)
    {
    }
}