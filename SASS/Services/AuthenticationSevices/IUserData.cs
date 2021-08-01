using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SASS.Services.AuthenticationSevices
{
   public interface IUserData<T>
    {

        Task<T> GetUser(string userName, string password);
        Task<bool> AddUser(T user);
        


    }
}
