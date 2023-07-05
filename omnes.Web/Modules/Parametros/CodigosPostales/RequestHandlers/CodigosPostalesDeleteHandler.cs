using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = omnes.Parametros.CodigosPostalesRow;

namespace omnes.Parametros;

public interface ICodigosPostalesDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

public class CodigosPostalesDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, ICodigosPostalesDeleteHandler
{
    public CodigosPostalesDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}