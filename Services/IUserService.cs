using System.Collections.Generic;
using System.Threading.Tasks;
using user_netcore.Dtos;

namespace user_netcore.Services
{
    public interface IUserService
    {
        Task<List<GetUserDto>> get();
        Task<GetUserDto> getNoDb();
    }
}