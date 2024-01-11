using EightToTen.Services.GuessIt;
using Microsoft.AspNetCore.Mvc;

namespace EightToTen.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GuessItController : ControllerBase
    {
        private readonly IGuessItService _guessIt;

        public GuessItController(IGuessItService guessIt)
        {
            _guessIt = guessIt;
        }
        [HttpGet]
        [Route("/GuessIt")]
        public string GuessIt(string difficulty, string userGuess)
        {
            return _guessIt.GuessIt(difficulty, userGuess);
        }

    }
}