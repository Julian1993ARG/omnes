using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<omnes.Parametros.AreasTrabajoRow>;
using MyRow = omnes.Parametros.AreasTrabajoRow;

namespace omnes.Parametros;

public interface IAreasTrabajoRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

public class AreasTrabajoRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IAreasTrabajoRetrieveHandler
{
    public AreasTrabajoRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}