using BakeryAdmin.Domain.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakeryAdmin.Domain.IRepositories
{
    public interface IAuthenticationRepository
    {
        public AuthResultDto Login(LoginDto objDto);

    }
}
