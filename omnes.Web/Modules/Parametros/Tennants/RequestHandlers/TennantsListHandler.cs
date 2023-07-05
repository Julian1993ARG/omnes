using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<omnes.Parametros.TennantsRow>;
using MyRow = omnes.Parametros.TennantsRow;

namespace omnes.Parametros;

public interface ITennantsListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

public class TennantsListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, ITennantsListHandler
{
    public TennantsListHandler(IRequestContext context)
            : base(context)
    {
    }
}