using Contracts.V1.Requests;
using Microsoft.AspNetCore.Mvc;
using Api.DataLayer;
using Api.LogicLayer.Validators.Interfaces;
using System.Net;

namespace Api.Controllers
{
    [ApiController]
    [Route("weapons")]
    public class WeaponsController : ControllerBase
    {
        private readonly ILogger<WeaponsController> _logger;
        private readonly IWeaponValidator _validator;

        public WeaponsController(
            ILogger<WeaponsController> logger,
            IWeaponValidator validator)
        {
            _logger = logger;
            _validator = validator;
        }

        [HttpPost]
        public ActionResult<string> Post(
            [FromBody]PostWeaponRequest request)
        {
            var errors = _validator.Validate(request);
            if (errors.Count > 0)
            {
                return BadRequest(string.Join(", ", errors));
            }

            try
            {
                return Ok("Foobar");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.ToString());
                return StatusCode((int)HttpStatusCode.InternalServerError);
            }
        }
    }
}