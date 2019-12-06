using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities.Concreate;
using Entities.Concrete;
using Microsoft.Extensions.Configuration;

namespace Core.Utilities.Security.Jwt
{
    public class JwtHelper:ITokenHelper
    {
        public JwtHelper(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get;}
        public AccessToken CreateToken(User user, List<OperationClaim> operationClaims)
        {
            throw new NotImplementedException();
        }
    }
}
