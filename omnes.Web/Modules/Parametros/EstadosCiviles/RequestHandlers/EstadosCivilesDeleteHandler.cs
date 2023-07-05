using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = omnes.Parametros.EstadosCivilesRow;

namespace omnes.Parametros;

public interface IEstadosCivilesDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

public class EstadosCivilesDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IEstadosCivilesDeleteHandler
{
    public EstadosCivilesDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}