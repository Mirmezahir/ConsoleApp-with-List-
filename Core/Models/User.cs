using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class User
    {
        public User(string name, string password)
        {
            Name = name;
            Password = password;
        }

        public User(string name, string password, int balance)
        {
            Name = name;
            Password = password;
            Balance = balance;
        }

        public  string  Name { get; set; }
        public string Password { get; set; }
        public int Balance { get; set; }

    }
}
