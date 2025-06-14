﻿using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicesAbstractions
{
    public interface IAuthService
    {
        Task<UserResultDto>LoginAsync(LoginDto loginDto);
        Task<UserResultDto> RegisterDto(RegisterDto registerDto);

    }
}
