using Entidad;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using Proyectopweb.Models;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using WebPulsaciones.Config;



namespace WebPulsaciones
{
    public class JwtService 
    {
        private readonly AppSetting _appSettings;
        public JwtService(IOptions<AppSetting> appSettings)=> _appSettings = appSettings.Value;
        public UsuarioViewModel GenerateToken(Usuario userLogIn)
        {
            // return null if user not found
            if (userLogIn == null) return null;
            var userResponse = new UsuarioViewModel() { tipoUsuario=userLogIn.tipoUsuario,nombreUsuario = userLogIn.nombreUsuario, estado=userLogIn.estado};
            // authentication successful so generate jwt token
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_appSettings.Secret);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.Name, userLogIn.nombreUsuario.ToString()),
                    new Claim(ClaimTypes.Email, userLogIn.correo.ToString()),
                    new Claim(ClaimTypes.MobilePhone, userLogIn.telefono.ToString()),
                    new Claim(ClaimTypes.Role, userLogIn.tipoUsuario.ToString()),
                    
                }),
                Expires = DateTime.UtcNow.AddDays(7),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            userResponse.Token = tokenHandler.WriteToken(token);
            return userResponse;
        }
    }
}
