using MediatR;

namespace Blazor.CQRS.WebUI.Core.Queries
{
    public class GetClickCount : IRequest<int>
    {
    }
}
