using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace MyStoriesApi
{
    public class AuthOptions
    {
        public const string ISSUER = "MyStoriesApi"; // издатель токена
        public const string AUDIENCE = "MyStories"; // потребитель токена
        const string KEY = "mySuperSecretKey-1337";   // ключ для шифрации
        public const int LIFETIME = 1; // время жизни токена - 1 минута
        public static SymmetricSecurityKey GetSymmetricSecurityKey()
        {
            return new SymmetricSecurityKey(Encoding.ASCII.GetBytes(KEY));
        }
    }
}
