using api_mcf.Entities;
using api_mcf.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;

namespace api_mcf.Controllers
{
    [ApiController]
    public class LocationController : Controller
    {
        private readonly LocationRepository locRepo;

        public LocationController(LocationRepository _locRepo)
        {
            this.locRepo = _locRepo;
        }

        [Route("api/location/getall")]
        [HttpGet]
        public ActionResult<List<MsStorageLocation>> GetList()
        {
            var result = locRepo.GetList();
            return Ok(result);
        }

    }
}
