using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<omnes.Parametros.EmpresasRow>;
using MyRow = omnes.Parametros.EmpresasRow;

namespace omnes.Parametros;

public interface IEmpresasListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

public class EmpresasListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IEmpresasListHandler
{
    public EmpresasListHandler(IRequestContext context)
            : base(context)
    {
    }
}