using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASP.NET__MVC_Messenger.Models
{
    public class User
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        List<User> friends;
        public User(string id, string name, string surname, List<User> friends)
        {
            Id = id;
            Name = name;
            Surname = surname;
            this.friends = friends;
        }
    }
}