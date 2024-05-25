using Proxy.Models;

namespace Proxy.Services
{
    public interface ICommonAreaService
    {
        IEnumerable<CommonAreaDTO> GetCommonAreas();
    }
}
