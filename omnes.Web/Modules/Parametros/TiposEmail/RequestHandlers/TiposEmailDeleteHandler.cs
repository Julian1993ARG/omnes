using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = omnes.Parametros.TiposEmailRow;

namespace omnes.Parametros;

public interface ITiposEmailDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

public class TiposEmailDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, ITiposEmailDeleteHandler
{
    public TiposEmailDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}