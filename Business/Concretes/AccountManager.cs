using Business.Abstracts;
using Core.Entities.Concrete;
using Core.Utilities.Results;
using DataAccess.Abstracts;
using Entity.Dtos;
using System;
using System.Web;

using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;


namespace Business.Concretes
{
    public class AccountManager : IAccountService
    {
        private readonly IAccountDal _accountDal;

        public AccountManager(IAccountDal accountDal)
        {
            _accountDal = accountDal;
        }
        public IDataResult<User> GetByUserNameAndPassword(string userName)
        {
            return new SuccessDataResult<User>(_accountDal.Get(x => x.UserName == userName));
        }
        public IDataResult<User> Login(UserForLoginDto userForLoginDto)
        {
            User user = GetByUserNameAndPassword(userForLoginDto.UserName).Data;
            if (user == null)
            {
                return new ErrorDataResult<User>("Kullanıcı yok");
            }

            using (var hmac = new System.Security.Cryptography.HMACSHA512(user.PasswordSalt))
            {
                var computedHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(userForLoginDto.Password));
                for (int i = 0; i < computedHash.Length; i++)
                {
                    if (computedHash[i] != user.PasswordHash[i])
                    {
                        return new ErrorDataResult<User>("Şifreler Eşleşmiyor");
                    }
                }
              
                return new SuccessDataResult<User>(user);
            }


        }
       
        public IDataResult<User> Register(UserForRegisterDto userForRegisterDto)
        {
            userForRegisterDto.Password = "1234";
            userForRegisterDto.Email="ayyildiz@gmail.com";
            userForRegisterDto.FirstName = "Enes";
            userForRegisterDto.LastName = "Ayyıldız";
            userForRegisterDto.UserName = "yozgatli";
            var hmac = new System.Security.Cryptography.HMACSHA512();
            byte[] passwordHash, passwordSalt;
            passwordSalt = hmac.Key;
            passwordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(userForRegisterDto.Password));
            var user = new User
            {
                UserName = userForRegisterDto.UserName,
                Email = userForRegisterDto.Email,
                FirstName = userForRegisterDto.FirstName,
                LastName = userForRegisterDto.LastName,
                PasswordHash = passwordHash,
                PasswordSalt = passwordSalt,

            };
            _accountDal.Add(user);
            return new SuccessDataResult<User>(user);
        }
    }
}
