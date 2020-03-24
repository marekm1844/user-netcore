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

        public async Task<GetUserDto> getNoDb()
        {
            string user = @"{'id':'89251ab3-1cdc-4629-9086-ce022cf6669e','firstName':'Marek','lastName':'Majdak','email':'info@sufrago.com','name':'sufrago','createAt':'2019-12-17T17:58:07.533406','phoneNo':'+48666666666','companyName':'Sufrago sp z o.o.','vatId':'PL 9512468001'}";
            user = user.Replace("'", "\"");

            var userEntity = JsonSerializer.Deserialize<User>(user, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true,
            });

            return mapper.Map<GetUserDto>(userEntity);
        }
    }
}