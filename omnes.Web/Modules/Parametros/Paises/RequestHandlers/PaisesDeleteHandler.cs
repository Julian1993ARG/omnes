using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = omnes.Parametros.PaisesRow;

namespace omnes.Parametros;

public interface IPaisesDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

public class PaisesDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IPaisesDeleteHandler
{
    public PaisesDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}