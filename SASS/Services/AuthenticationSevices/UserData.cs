using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using SASS.Models;
using System.Threading.Tasks;

namespace SASS.Services.AuthenticationSevices
{
   public class UserData : IUserData<User>
    {
        string path_;
        private SQLiteAsyncConnection connection { get; set; }
        

        public UserData(string path)
        {
            path_ = path;
        }


        async void Init()
        {
            if (connection.Table<User>() != null)
                return;

            connection = new SQLiteAsyncConnection(path_);
           await connection.CreateTableAsync<User>();
            

        }

     
    

        public async Task<bool> AddUser(User user)
        {
            Init();
           
           await connection.InsertAsync(user);

            return await Task.FromResult(true);
               
            
        }

        public async Task<User> GetUser(string userName, string password)
        {
            Init();
            return await Task.FromResult(await connection.Table<User>().FirstOrDefaultAsync(x => x.UserName == userName && x.Password == password));
        }
    }
}
