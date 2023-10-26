using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceApplication.Service.Contracts
{
    public interface IAuthenticationService
    {
        Task<bool> Authenticate(string identifierUser, string pass, long? idCompany);
    }
}
