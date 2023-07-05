using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<omnes.Parametros.EstadosCivilesRow>;
using MyRow = omnes.Parametros.EstadosCivilesRow;

namespace omnes.Parametros;

public interface IEstadosCivilesRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

public class EstadosCivilesRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IEstadosCivilesRetrieveHandler
{
    public EstadosCivilesRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}