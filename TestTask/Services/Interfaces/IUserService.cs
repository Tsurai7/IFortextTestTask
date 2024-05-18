using TestTask.Models;

namespace TestTask.Services.Interfaces
{
    /// <summary>
    /// IUserService.
    /// DO NOT change anything here. Use created contract and provide only needed implementation.
    /// </summary>
    public interface IUserService
    {
        public Task<User> GetUser();

        public Task<List<User>> GetUsers();
    }
}
