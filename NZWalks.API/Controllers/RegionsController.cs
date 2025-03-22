using Microsoft.AspNetCore.Mvc;
using NZWalks.API.Models.Domain;

namespace NZWalks.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegionsController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAll()
        {
            var regions = new List<Region>
            {
                new Region
                {
                    Id = Guid.NewGuid(),
                    Name = "Auckland Region",
                    Code = "AKL",
                    RegionImageUrl = "https://images.pexels.com/photos/31256164/pexels-photo-31256164/free-photo-of-dramatic-coastal-landscape-in-auckland-new-zealand.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1"
                },
                new Region
                {
                    Id = Guid.NewGuid(),
                    Name = "Wellington Region",
                    Code = "WLG",
                    RegionImageUrl = "https://images.pexels.com/photos/31256164/pexels-photo-31256164/free-photo-of-dramatic-coastal-landscape-in-auckland-new-zealand.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1"
                }
            };

            return Ok(regions);
        }
    }
}
