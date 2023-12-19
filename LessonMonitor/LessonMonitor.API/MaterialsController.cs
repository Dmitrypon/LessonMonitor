using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace LessonMonitor.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class MaterialsController: ControllerBase
    {
        public MaterialsController()
        {

        }

        [HttpGet]
        public Materials[] Get(string NameMaterial)
      
        {
            var materials = new List<Materials>();
            var random = new Random();

            for (int i = 0; i < 10; i++)
            {
                var material = new Materials();

                material.NameMaterial = NameMaterial + i;
                material.Id = random.Next(10, 100);

                materials.Add(material);
            }
            return materials.ToArray();
        }
        
    }
}
