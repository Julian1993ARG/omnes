using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<omnes.Parametros.CodigosPostalesRow>;
using MyRow = omnes.Parametros.CodigosPostalesRow;

namespace omnes.Parametros;

public interface ICodigosPostalesRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

public class CodigosPostalesRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, ICodigosPostalesRetrieveHandler
{
    public CodigosPostalesRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}