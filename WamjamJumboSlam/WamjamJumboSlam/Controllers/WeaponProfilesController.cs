using Microsoft.AspNetCore.Mvc;
using WamjamJumboSlam.DataLayer;

namespace WamjamJumboSlam.Controllers
{
    [ApiController]
    [Route("weaponprofiles")]
    public class WeaponProfilesController : ControllerBase
    {
        private readonly ILogger<WeaponProfilesController> _logger;
        private readonly DatabaseContext _databaseContext;

        public WeaponProfilesController(
            ILogger<WeaponProfilesController> logger,
            DatabaseContext databaseContext)
        {
            _logger = logger;
            _databaseContext = databaseContext;
        }

        [HttpGet]
        public ActionResult<string> Get()
        {
            return Ok("Foobar");
        }
    }
}