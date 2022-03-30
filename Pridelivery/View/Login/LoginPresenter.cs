using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pridelivery.Repository.Database.User;
using Pridelivery.Repository.Model;

namespace Pridelivery.View.Login
{
    internal class LoginPresenter
    {
        public UserProfile getAuthentication(string email, string password)
        {
            UserProfile data = null;
                Task.Run(() =>
                {
                    var task = UserRepository.getAuthentication(email, password);
                    data = task.Result;
                }).Wait();
            return data;
        }
    }
}
