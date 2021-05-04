using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SignalRChat
{
    public class UserMessageViewModel
    {
        public IEnumerable<User> Users { get; set; }
        public IEnumerable<Message> Messages { get; set; }

        public string RecieveName { get; set; }

        public int OtherProfile { get; set; }

        public int SessionId { get; set; }
    }
}