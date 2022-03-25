using System;
using System.Threading.Tasks;
using Pridelivery.Repository.Model;

namespace Pridelivery.Repository.Database.User
{
    public abstract class UserRepository
    {
        public static async Task<UserProfile> getAuthentication(string email, string password)
        {
            var query = $"select * from user where email = '{email}' and password = SHA2('{password}', 512);";
            var reader = DbFactory.runQueryCommand(query).Result;

            if (!reader.HasRows)
            {
                throw new Exception("data not found, please check your email or password");
            }

            UserProfile profile = null;

            for (int i = 0; i < reader.FieldCount; i++)
            {
                // Process each column as appropriate
                object obj = await reader.GetFieldValueAsync<object>(i);
                profile = (UserProfile)obj;
                Console.WriteLine(obj);
            }
            return profile;
        }

        public static Task<int> registerUser(UserProfile data)
        {
            var query = $"insert into user values( null ,'{data.Name}','{data.Email}','{data.Phone}',SHA2(\"{data.Password}\", 512), '{data.Role}', now());";
            var task = DbFactory.runNonQueryCommand(query);
            return task;
        }
    }
}
