using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = omnes.Parametros.TennantsRow;

namespace omnes.Parametros;

public interface ITennantsDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

public class TennantsDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, ITennantsDeleteHandler
{
    public TennantsDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}