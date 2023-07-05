using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<omnes.Parametros.EstadosCivilesRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = omnes.Parametros.EstadosCivilesRow;

namespace omnes.Parametros;

public interface IEstadosCivilesSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

public class EstadosCivilesSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IEstadosCivilesSaveHandler
{
    public EstadosCivilesSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}