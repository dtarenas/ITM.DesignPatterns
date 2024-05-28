using Proxy.Models;

namespace Proxy.Services
{
    public class CommonAreaService : ICommonAreaService
    {
        public IEnumerable<CommonAreaDTO> GetCommonAreas()
        {
            Console.ResetColor();
            Console.WriteLine("Fetching common areas from endpoint...");
            Thread.Sleep((int)TimeSpan.FromSeconds(3).TotalMilliseconds);
            return this.GetRandomCommonAreas();
        }
        
        private List<CommonAreaDTO> GetRandomCommonAreas()
        {
            List<CommonAreaDTO> commonAreas = [];
            string[] commonAreaNames = ["Salón de eventos", "Piscina", "Gimnasio", "Zona de parrillas", "Coworking"];

            string[] attractiveRemarks = [
                    "Organiza eventos inolvidables en nuestro elegante salón de eventos, perfecto para fiestas, reuniones y celebraciones especiales.",
                    "¡Disfruta de un refrescante chapuzón en nuestra impresionante piscina mientras disfrutas del sol y te relajas con amigos y familiares!",
                    "Mantente en forma y activo en nuestro moderno gimnasio, equipado con equipos de última generación para tus rutinas de ejercicio.",
                    "Disfruta de deliciosas barbacoas al aire libre con amigos y familiares en nuestra acogedora zona de parrillas, ¡sabores inolvidables garantizados!",
                    "Un espacio especializado para aumentar tu productividad"
                ];

            string[] images =
            [
                "https://cdn.pixabay.com/photo/2019/01/26/22/13/table-3957087_1280.jpg",
                "https://cdn.pixabay.com/photo/2023/10/10/15/20/swimming-pool-8306716_1280.jpg",
                "https://cdn.pixabay.com/photo/2020/07/02/21/15/gym-5364404_1280.jpg",
                "https://cdn.pixabay.com/photo/2016/11/19/12/44/burgers-1839090_1280.jpg",
                "https://cdn.pixabay.com/photo/2019/01/26/22/13/table-3957087_1280.jpg",
            ];

            for (int i = 0; i <= commonAreaNames.Length - 1; i++)
            {
                var code = $"CA{i + 1:D3}";
                var name = commonAreaNames[i];
                var remarks = attractiveRemarks[i];
                var image = images[i];
                var commonArea = new CommonAreaDTO
                {
                    Id = i + 1,
                    Code = code,
                    Name = name,
                    Description = remarks,
                    ImageUrl = image,
                    CommonAreaType = name switch
                    {
                        "Coworking" => CommonAreaType.Coworking,
                        "Piscina" => CommonAreaType.Recreational,
                        "Gimnasio" => CommonAreaType.Recreational,
                        _ => CommonAreaType.Social,
                    }
            };

                commonAreas.Add(commonArea);
            }

            return commonAreas;
        }
    }
}
