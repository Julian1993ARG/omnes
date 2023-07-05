using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<omnes.Parametros.PaisesRow>;
using MyRow = omnes.Parametros.PaisesRow;

namespace omnes.Parametros;

public interface IPaisesRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

public class PaisesRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IPaisesRetrieveHandler
{
    public PaisesRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}