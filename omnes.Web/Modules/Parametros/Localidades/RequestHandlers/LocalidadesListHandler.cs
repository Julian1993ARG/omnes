using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<omnes.Parametros.LocalidadesRow>;
using MyRow = omnes.Parametros.LocalidadesRow;

namespace omnes.Parametros;

public interface ILocalidadesListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

public class LocalidadesListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, ILocalidadesListHandler
{
    public LocalidadesListHandler(IRequestContext context)
            : base(context)
    {
    }
}