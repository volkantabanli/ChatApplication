using DataAccessLayer.Concrete.Repository;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class MessageManager
    {
        GenericRepository<Message> repo = new GenericRepository<Message>();
        public List<Message> GetMessage(Message message)
        {

            return repo.List(m => m.UserId == message.UserId && m.ReceiveId == message.ReceiveId);
        }
    
        public void AddMessage(Message message)
        {
            repo.Insert(message);
        }
    }

  
}
