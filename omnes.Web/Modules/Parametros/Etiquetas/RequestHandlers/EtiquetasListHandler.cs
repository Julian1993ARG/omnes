using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<omnes.Parametros.EtiquetasRow>;
using MyRow = omnes.Parametros.EtiquetasRow;

namespace omnes.Parametros;

public interface IEtiquetasListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

public class EtiquetasListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IEtiquetasListHandler
{
    public EtiquetasListHandler(IRequestContext context)
            : base(context)
    {
    }
}