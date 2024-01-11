using EightToTen.Services.Magic8Ball;
using Microsoft.AspNetCore.Mvc;

namespace EightToTen.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class Magic8BallController : ControllerBase
    {
        private readonly IMagic8BallService _magic8Ball;

        public Magic8BallController(IMagic8BallService magic8Ball)
        {
            _magic8Ball = magic8Ball;
        }
        [HttpGet]
        [Route("/Magic8Ball")]
        public string Magic8Ball(string userQuestion = "Will I be blessed with good luck today?", string userName = "stranger")
        {
            return _magic8Ball.Magic8Ball(userQuestion, userName);
        }

    }
}