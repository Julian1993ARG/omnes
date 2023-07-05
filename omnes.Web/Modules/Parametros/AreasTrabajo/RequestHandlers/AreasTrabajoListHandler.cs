using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<omnes.Parametros.AreasTrabajoRow>;
using MyRow = omnes.Parametros.AreasTrabajoRow;

namespace omnes.Parametros;

public interface IAreasTrabajoListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

public class AreasTrabajoListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IAreasTrabajoListHandler
{
    public AreasTrabajoListHandler(IRequestContext context)
            : base(context)
    {
    }
}