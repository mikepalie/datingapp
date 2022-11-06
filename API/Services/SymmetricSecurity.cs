using Microsoft.IdentityModel.Tokens;

namespace API.Services
{
    internal class SymmetricSecurity
    {
        public static implicit operator SymmetricSecurity(SymmetricSecurityKey v)
        {
            throw new NotImplementedException();
        }
    }
}