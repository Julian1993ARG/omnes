using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = omnes.Parametros.ProvinciasRow;

namespace omnes.Parametros;

public interface IProvinciasDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

public class ProvinciasDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IProvinciasDeleteHandler
{
    public ProvinciasDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}