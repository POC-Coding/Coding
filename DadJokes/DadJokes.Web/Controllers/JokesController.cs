using DadJokes.Web.Models;
using DadJokes.Web.Services.Jokes;
using Microsoft.AspNetCore.Mvc;

namespace DadJokes.Web.Controllers
{
    public class JokesController : Controller
    {
        private readonly IJokeService _iJokeService;
        public JokesController(IJokeService iJokeService)
        {
            _iJokeService = iJokeService;
        }
        public async Task<Joke> GetJokes()
        {
            return await _iJokeService.GetJokes();
        }
        public async Task<int> GetJokesCount()
        {
            return await _iJokeService.GetJokesCount();
        }
    }
}
