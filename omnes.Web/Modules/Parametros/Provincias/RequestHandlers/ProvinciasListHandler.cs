using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<omnes.Parametros.ProvinciasRow>;
using MyRow = omnes.Parametros.ProvinciasRow;

namespace omnes.Parametros;

public interface IProvinciasListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

public class ProvinciasListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IProvinciasListHandler
{
    public ProvinciasListHandler(IRequestContext context)
            : base(context)
    {
    }
}