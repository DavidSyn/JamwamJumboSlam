using Contacts.V1.Requests;
using Microsoft.AspNetCore.Mvc;
using WamjamJumboSlam.DataLayer;

namespace WamjamJumboSlam.Controllers
{
    [ApiController]
    [Route("weapons")]
    public class WeaponsController : ControllerBase
    {
        private readonly ILogger<WeaponsController> _logger;
        private readonly DatabaseContext _databaseContext;

        public WeaponsController(
            ILogger<WeaponsController> logger,
            DatabaseContext databaseContext)
        {
            _logger = logger;
            _databaseContext = databaseContext;
        }

        [HttpPost]
        public ActionResult<string> Post(
            [FromBody]PostWeaponRequest request)
        {
            return Ok("Foobar");
        }
    }
}