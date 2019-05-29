using Blazor.CQRS.WebUI.Core.ViewModels;

using MediatR;

namespace Blazor.CQRS.WebUI.Core.Queries
{
    public class GetForecast : IRequest<WeatherForecast[]>
    {
        public int PageSize { get; set; }

        public GetForecast(int pageSize = 10)
        {
            this.PageSize = pageSize;
        }
    }
}
