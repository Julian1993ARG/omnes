using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<omnes.Parametros.ProvinciasRow>;
using MyRow = omnes.Parametros.ProvinciasRow;

namespace omnes.Parametros;

public interface IProvinciasRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

public class ProvinciasRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IProvinciasRetrieveHandler
{
    public ProvinciasRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}