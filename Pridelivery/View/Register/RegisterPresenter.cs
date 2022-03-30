using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pridelivery.Repository;
using Pridelivery.Repository.Database.User;
using Pridelivery.Repository.Model;

namespace Pridelivery.View.Register
{
    internal class RegisterPresenter
    {
        public bool getRegistered(UserProfile user) {
            bool registered = false;
            Task.Run(() => {
                var task = UserRepository.registerUser(user);
                if (task.Result == 1) {
                    registered = true;
                }
            }).Wait();
            return registered;
        }
    }
}
