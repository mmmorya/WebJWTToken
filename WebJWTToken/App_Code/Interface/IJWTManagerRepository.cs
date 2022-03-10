using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebJWTToken.Models;

namespace WebJWTToken.App_Code.MiddleLayer
{
    public interface IJWTManagerRepository
    {
        Tokens Authenticate(Users users);
    }
}
