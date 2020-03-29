using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using user_netcore.Data;
using user_netcore.Dtos;
using user_netcore.Models;


namespace user_netcore.Services
{
    public class UserService : IUserService
    {
        private readonly IMapper mapper;
        private readonly DataContext context;

        public UserService(IMapper mapper, DataContext context)
        {
            this.context = context;
            this.mapper = mapper;
        }

        public async Task<List<GetUserDto>> get()
        {
            List<User> dbUsers = await context.User.ToListAsync();

            return dbUsers.Select(r => mapper.Map<GetUserDto>(r)).ToList();
        }

        public async Task<GetUserDto> getOne()
        {
            throw new System.NotImplementedException();
        }
    }
}