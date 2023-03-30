using DadJokes.Web.Models;

namespace DadJokes.Web.Services.Jokes
{
    public interface IJokeService
    {
        Task<Joke> GetJokes();
        Task<int> GetJokesCount();
    }
}
