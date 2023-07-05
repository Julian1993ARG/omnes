using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = omnes.Parametros.LocalidadesRow;

namespace omnes.Parametros;

public interface ILocalidadesDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

public class LocalidadesDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, ILocalidadesDeleteHandler
{
    public LocalidadesDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}