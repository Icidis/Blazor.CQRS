using System.Threading;
using System.Threading.Tasks;

using Blazor.CQRS.WebUI.Core.Commands;
using Blazor.CQRS.WebUI.Core.Queries;
using Blazor.CQRS.WebUI.Core.Services;

using MediatR;

namespace Blazor.CQRS.WebUI.Core.RequestHandlers
{
    public class CounterHandler :
        IRequestHandler<GetClickCount, int>,
        IRequestHandler<IncrementCounter, int>
    {
        private readonly ICacheManager cacheManager;

        public CounterHandler(ICacheManager cacheManager)
        {
            this.cacheManager = cacheManager;
        }

        public Task<int> Handle(GetClickCount request, CancellationToken cancellationToken)
        {
            return Task.FromResult(cacheManager.GetClickCount());
        }

        public Task<int> Handle(IncrementCounter request, CancellationToken cancellationToken)
        {
            return Task.FromResult(cacheManager.IncrementClickCount());
        }

    }
}
