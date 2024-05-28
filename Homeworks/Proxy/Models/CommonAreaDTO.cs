namespace Proxy.Models
{
    public class CommonAreaDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public CommonAreaType CommonAreaType { get; set; }
    }
}