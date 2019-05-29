namespace Blazor.CQRS.WebUI.Core.Services
{
    public class CacheManager : ICacheManager
    {
        private int _clickCount = 0;

        public int GetClickCount()
        {
            return _clickCount;
        }

        public int IncrementClickCount()
        {
            _clickCount += 1;
            return GetClickCount();
        }
    }
}
