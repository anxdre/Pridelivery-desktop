using System;
using System.Collections.Generic;

namespace Pridelivery.Repository.Model
{
    public class UserProfile
    {
        private int id;
        private string name;
        private string email;
        private string phone;
        private int role;
        private string password;

        public UserProfile(int id, string name, string email, string phone, string password, int role)
        {
            this.Id = id;
            this.Name = name;
            this.Email = email;
            this.Phone = phone;
            this.Role = role;
            this.Password = password;
        }

        public int Id { get => id; set => id = value; }
        public string Name
        {
            get => name;
            set
            {
                if (value.Length != 0)
                {
                    name = value;
                }
                else
                {
                    throw new ArgumentException("Name cant be empty");
                }
            }
        }
        public string Email
        {
            get => email; set
            {
                if (value.Length != 0)
                {
                    email = value;
                }
                else
                {
                    throw new ArgumentException("Email cant be empty");
                }
            }
        }
        public string Phone
        {
            get => phone; set
            {
                if (value.Length != 0)
                {
                    phone = value;
                }
                else
                {
                    throw new ArgumentException("Phone cant be empty");
                }
            }
        }
        public string Password
        {
            get => password; set
            {
                if (value.Length != 0 && value.Length > 5)
                {
                    password = value;
                }
                else
                {
                    throw new ArgumentException("Password cant be empty & have 6 minimum character");
                }
            }
        }
        public int Role
        {
            get => role; set => role = value;
        }
    }
}
