using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<omnes.Administration.LanguageRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = omnes.Administration.LanguageRow;


namespace omnes.Administration
{
    public interface ILanguageSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> { }
    public class LanguageSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, ILanguageSaveHandler
    {
        public LanguageSaveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}