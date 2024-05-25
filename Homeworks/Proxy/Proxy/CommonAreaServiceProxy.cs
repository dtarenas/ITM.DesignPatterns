using Proxy.Models;
using Proxy.Services;

namespace Proxy.Proxy
{
    public class CommonAreaServiceProxy : ICommonAreaService
    {
        private readonly CommonAreaService _commonAreasService;
        private IEnumerable<CommonAreaDTO> _cachedCommonAreas;
        private DateTime _cacheTimestamp;
        private readonly TimeSpan _cacheDuration = TimeSpan.FromSeconds(30);

        public CommonAreaServiceProxy()
        {
            this._commonAreasService = new CommonAreaService();
            this._cachedCommonAreas = null;
            this._cacheTimestamp = DateTime.MinValue;
        }

        public IEnumerable<CommonAreaDTO> GetCommonAreas()
        {
            if (this._cachedCommonAreas == null || DateTime.Now - this._cacheTimestamp > this._cacheDuration)
            {
                this._cachedCommonAreas = this._commonAreasService.GetCommonAreas();
                this._cacheTimestamp = DateTime.Now;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("************** Returning cached Common Areas... ****************");
                Console.ResetColor();
            }

            return this._cachedCommonAreas;
        }
    }
}