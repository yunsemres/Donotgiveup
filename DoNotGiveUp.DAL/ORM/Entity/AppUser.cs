using DoNotGiveUp.DAL.ORM.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoNotGiveUp.DAL.ORM.Entity
{
    public class AppUser : BaseEntity
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public Role Role { get; set; }
    }
}
