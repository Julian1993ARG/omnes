using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<omnes.Parametros.PaisesRow>;
using MyRow = omnes.Parametros.PaisesRow;

namespace omnes.Parametros;

public interface IPaisesListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

public class PaisesListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IPaisesListHandler
{
    public PaisesListHandler(IRequestContext context)
            : base(context)
    {
    }
}