using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<omnes.Parametros.CodigosPostalesRow>;
using MyRow = omnes.Parametros.CodigosPostalesRow;

namespace omnes.Parametros;

public interface ICodigosPostalesListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

public class CodigosPostalesListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, ICodigosPostalesListHandler
{
    public CodigosPostalesListHandler(IRequestContext context)
            : base(context)
    {
    }
}