using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BusinessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNet.SignalR;

namespace SignalRChat
{
    public class Chathub : Hub
    {
        public void SendMessage(String message, int receiveId,String receiveName , int userId)
        {
            Clients.Others.GetMessageOther(message, receiveName);

            Clients.Caller.GetMessageCaller(message); 

             MessageManager messageManeger = new MessageManager();

            Message messages = new Message
            {
                ReceiveId = receiveId,
                UserId = userId,
                Text = message,
                Time = DateTime.Now
            };
            messageManeger.AddMessage(messages);
        }
    }
}