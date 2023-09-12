using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Mikroservice_uge_2.Stores;

namespace Mikroservice_uge_2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlayCardController : ControllerBase
    {

        private readonly IPlayCardStore _playCardStore;

        public PlayCardController(IPlayCardStore playCardStore)
        {
            _playCardStore = playCardStore;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_playCardStore.GetAll());
        }

        [HttpGet("random")]
        public IActionResult GetRandom()
        {
            return Ok(Helper.PlayCardHelper.GetRandomCard(_playCardStore.GetAll()));
        }
    }
}
