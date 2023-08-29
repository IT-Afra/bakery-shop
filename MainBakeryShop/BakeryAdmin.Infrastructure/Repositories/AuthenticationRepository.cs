using AutoMapper;
using BakeryAdmin.Domain.Dtos;
using BakeryAdmin.Domain.IRepositories;
using Bakeryshop.Framework;
using Bakeryshop.Infrastructure.EntityFramework;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace BakeryAdmin.Infrastructure.Repositories
{
    public class AuthenticationRepository : IAuthenticationRepository
    {

        private readonly BakeryshopContext _dbContext;
        private readonly IMapper _mapper;
        private readonly IConfiguration _configuration; 

        public AuthenticationRepository(BakeryshopContext dbContext, IMapper mapper, IConfiguration configuration)
        {
            _dbContext = dbContext;
            _mapper = mapper;
            _configuration = configuration;
        }

        public AuthResultDto Login(LoginDto objDto)
        {
            var objUser = _dbContext.gtUsers.Where(a => a.UserName == objDto.UserName && a.Password == objDto.Password).FirstOrDefault();
            if (objUser == null)
                throw new ApplicationException(ErrorReource.InvalidUserOrPassword);

            var claims = new List<Claim>();
            claims.Add(new Claim("userId" , objUser.Id.ToString()));
            claims.Add(new Claim("name", objUser.Name.ToString()));
            claims.Add(new Claim("role", objUser.RoleName.ToString()));

            var authSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JwtSetting:SecretKey"]));
            var authCredential = new SigningCredentials(authSigningKey, SecurityAlgorithms.HmacSha256Signature);
            var expire = DateTime.Now.AddMinutes(_configuration["JwtSetting:AccessTokenExpiration"].ToInt());
            var jwtToken = new JwtSecurityToken(
                _configuration["JwtSetting:ValidIssuer"],
                _configuration["JwtSetting:ValidAudience"],
                claims,
                expires: expire,
                signingCredentials: authCredential);
            var accessToken = new JwtSecurityTokenHandler().WriteToken(jwtToken);

            return new AuthResultDto
            {
                AccessToken = accessToken
            };
        }
    }
}
