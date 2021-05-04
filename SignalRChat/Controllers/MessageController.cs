using BusinessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SignalRChat.Controllers
{
    public class MessageController : Controller
    {
        // GET: Message
        private UserManager userManager = new UserManager();
        private MessageManager messageManager = new MessageManager();
        public ActionResult Index()
        {
            User user = new User
            {
                Mail = Convert.ToString(Session["Mail"]),
                Password = Convert.ToString(Session["Password"])

            };


            var model = new UserMessageViewModel()
            {

                Users = userManager.GetOthers(user)
            };
            return View(model);
        }
        public ActionResult Users(int id)
        {
            User user = new User
            {
                Mail = Convert.ToString(Session["Mail"]),
                Password = Convert.ToString(Session["Password"])

            };

            Message message = new Message
            {
                UserId = Convert.ToInt32(Session["UserId"]),
                ReceiveId = id
            };


            Message othermessage = new Message
            {
                UserId = id,
                ReceiveId = Convert.ToInt32(Session["UserId"])
            };

            var model = new UserMessageViewModel()
            {
                Messages = messageManager.GetMessage(message).Concat(messageManager.GetMessage(othermessage)),
                RecieveName = userManager.GetReceivedUser(id).FirstName + " " + userManager.GetReceivedUser(id).LastName,
                OtherProfile = id,
                Users = userManager.GetOthers(user),
                SessionId = Convert.ToInt32(Session["UserId"])
            };
            return View(model);
        }
   
    }
}