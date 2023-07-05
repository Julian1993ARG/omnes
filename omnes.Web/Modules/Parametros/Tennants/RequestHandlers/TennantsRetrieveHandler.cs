using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<omnes.Parametros.TennantsRow>;
using MyRow = omnes.Parametros.TennantsRow;

namespace omnes.Parametros;

public interface ITennantsRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

public class TennantsRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, ITennantsRetrieveHandler
{
    public TennantsRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}