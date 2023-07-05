using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<omnes.Parametros.AreasTrabajoRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = omnes.Parametros.AreasTrabajoRow;

namespace omnes.Parametros;

public interface IAreasTrabajoSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

public class AreasTrabajoSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IAreasTrabajoSaveHandler
{
    public AreasTrabajoSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}