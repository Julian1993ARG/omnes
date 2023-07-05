using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<omnes.Parametros.LocalidadesRow>;
using MyRow = omnes.Parametros.LocalidadesRow;

namespace omnes.Parametros;

public interface ILocalidadesRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

public class LocalidadesRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, ILocalidadesRetrieveHandler
{
    public LocalidadesRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}