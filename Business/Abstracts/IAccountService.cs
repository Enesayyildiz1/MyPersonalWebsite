using Core.Entities.Concrete;
using Core.Utilities.Results;
using Core.Utilities.Security.JWT;
using Entity.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstracts
{
   public  interface IAccountService
    {
        IDataResult<User> Register(UserForRegisterDto userForRegisterDto);
        IDataResult<User> Login(UserForLoginDto userForLoginDto);
     
    }
}
