using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASP.NET__MVC_Messenger.Models
{
    public class Chat
    {
        User user1, user2;
        List<Message> messages;

        public Chat(User user1, User user2, List<Message> messages)
        {
            this.user1 = user1;
            this.user2 = user2;
            this.messages = messages;
        }
    }
}