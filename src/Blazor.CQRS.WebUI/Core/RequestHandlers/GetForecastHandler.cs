using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Components;
using Blazor.CQRS.WebUI.Core.Queries;
using Blazor.CQRS.WebUI.Core.ViewModels;

using MediatR;

namespace Blazor.CQRS.WebUI.Core.RequestHandlers
{
    public class GetForecastHandler : IRequestHandler<GetForecast, WeatherForecast[]>
    {
        private readonly HttpClient _httpClient;

        public GetForecastHandler(HttpClient httpClient)
        {
            this._httpClient = httpClient;
        }

        public async Task<WeatherForecast[]> Handle(GetForecast request, CancellationToken cancellationToken)
        {
            var response = await _httpClient.GetJsonAsync<WeatherForecast[]>("sample-data/weather.json");
            return response?.Take(request.PageSize).ToArray();
        }
    }
}
