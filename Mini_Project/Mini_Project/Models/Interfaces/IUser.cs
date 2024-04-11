﻿using Mini_Project.Dto;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Mini_Project.Models.Interfaces
{
    public interface IUser
    {
        Task<List<UserDto>> GetAllUsers();
        Task AddUser(User user);
        Task UpdateUser();
        Task DeleteUser();

    }
}
