using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
   public class Message
    {
        [Key]
        public int MessageId { get; set; }
       
        public string Text { get; set; }

       
        public DateTime Time { get; set; }

      
        public int UserId { get; set; }

     
        public int ReceiveId { get; set; }
    }
}
