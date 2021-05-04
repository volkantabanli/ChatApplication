using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class User
    {
        public User()
        {

            Messages = new HashSet<Message>();
        }


        [Key]
        public int UserId { get; set; }

        public string FirstName{ get; set; }


        public string LastName { get; set; }


        public string Mail { get; set; }


        public string Password { get; set; }
        public virtual ICollection<Message> Messages { get; set; }
    }
}
