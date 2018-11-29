using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace PrmDesignApi
{
    public class AuthOptions
    {
        public const string ISSUER = "PrmDesignServer"; // издатель токена
        public const string AUDIENCE = "PrmDesignClient"; // потребитель токена
        const string KEY = "prmdesign_secretkey!975";   // ключ для шифрации
        public const int LIFETIME = 1; // время жизни токена - 1 минута
        public static SymmetricSecurityKey GetSymmetricSecurityKey()
        {
            return new SymmetricSecurityKey(Encoding.ASCII.GetBytes(KEY));
        }
    }
}
