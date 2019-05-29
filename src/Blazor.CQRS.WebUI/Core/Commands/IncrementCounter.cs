using MediatR;

namespace Blazor.CQRS.WebUI.Core.Commands
{
    public class IncrementCounter : IRequest<int>
    {
    }
}
