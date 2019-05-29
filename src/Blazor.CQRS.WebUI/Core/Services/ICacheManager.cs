namespace Blazor.CQRS.WebUI.Core.Services
{
    public interface ICacheManager
    {
        int IncrementClickCount();
        int GetClickCount();
    }
}
