using System.Text.Json;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace WebApiAuthentication.Models
{
    public class UserService
    {
        private const string JsonFilePath = "users.json";


        public User user = new User();
        public User GetUsers()
        {
            user.Id = 1;
            user.Username = "admin";
            user.Password = "F1tprotr@cker!";
            return user;
        }

       

        public User Authenticate(string username, string password)
        {

            var users = GetUsers();
            if(users != null || user.Username == username && user.Password == password)
            {
                return users;
            }
            return null;
        }
    }
}
