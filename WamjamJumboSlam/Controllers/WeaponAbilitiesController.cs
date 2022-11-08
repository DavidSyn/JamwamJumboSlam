using Contacts.V1.Requests;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using WamjamJumboSlam.DataLayer.Repositories.Interfaces;
using WamjamJumboSlam.LogicLayer.Mapper;
using WamjamJumboSlam.LogicLayer.Validators.Interfaces;

namespace WamjamJumboSlam.Controllers
{
    [ApiController]
    [Route("weaponabilities")]
    public class WeaponAbilitiesController : ControllerBase
    {
        private readonly ILogger<WeaponAbilitiesController> _logger;
        private readonly IWeaponAbilitiesRepository _repository;
        private readonly IWeaponAbilityValidator _validator;

        public WeaponAbilitiesController(
            ILogger<WeaponAbilitiesController> logger,
            IWeaponAbilitiesRepository repository,
            IWeaponAbilityValidator validator)
        {
            _logger = logger;
            _repository = repository;
            _validator = validator;
        }

        [HttpGet("{id:Guid}")]
        public async Task<ActionResult<Guid>> Get(
            [FromRoute]Guid id)
        {
            var errors = _validator.Validate(id);
            if (errors.Count > 0)
            {
                return BadRequest(string.Join(", ", errors));
            }

            try
            {
                var weaponAbility = await _repository
                    .Get(id);
                var result = weaponAbility.ToContract();

                return Ok(result);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.ToString());
                return StatusCode((int)HttpStatusCode.InternalServerError);
            }
        }

        [HttpPost]
        public async Task<ActionResult<Guid>> Post(
            [FromBody]PostWeaponAbilityRequest request)
        {
            var errors = _validator.Validate(request);
            if (errors.Count > 0)
            {
                return BadRequest(string.Join(", ", errors));
            }

            try
            {
                Guid weaponAbilityId = await _repository
                    .Post(request.ToModel());

                return Created("", weaponAbilityId);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.ToString());
                return StatusCode((int)HttpStatusCode.InternalServerError);
            }            
        }
    }
}
