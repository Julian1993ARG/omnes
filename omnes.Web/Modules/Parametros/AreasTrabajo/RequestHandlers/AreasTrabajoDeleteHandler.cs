using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = omnes.Parametros.AreasTrabajoRow;

namespace omnes.Parametros;

public interface IAreasTrabajoDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

public class AreasTrabajoDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IAreasTrabajoDeleteHandler
{
    public AreasTrabajoDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}