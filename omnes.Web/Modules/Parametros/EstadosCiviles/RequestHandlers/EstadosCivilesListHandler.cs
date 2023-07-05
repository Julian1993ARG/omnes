using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<omnes.Parametros.EstadosCivilesRow>;
using MyRow = omnes.Parametros.EstadosCivilesRow;

namespace omnes.Parametros;

public interface IEstadosCivilesListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

public class EstadosCivilesListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IEstadosCivilesListHandler
{
    public EstadosCivilesListHandler(IRequestContext context)
            : base(context)
    {
    }
}