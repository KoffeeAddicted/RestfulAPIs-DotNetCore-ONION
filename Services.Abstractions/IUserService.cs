﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contracts.DTOs.Stories;
using Contracts;
using Contracts.DTOs.Users;

namespace Services.Absractions
{
    public interface IUserService
    {
        Task<UserResponseDTO> CreateUserAsync(UserCreateCustomerAuthen userCreateCustomerAuthen);
    }
}
