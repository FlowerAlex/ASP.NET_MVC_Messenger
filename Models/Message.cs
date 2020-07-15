using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASP.NET__MVC_Messenger.Models
{
    public class Message
    {
        public int Id { get; set; }
        public string TextMessage{ get; set; }
        public User UserFrom { get; set; }
        public User UserTo { get; set; }
    }
}