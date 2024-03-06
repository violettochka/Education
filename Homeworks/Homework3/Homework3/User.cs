using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    public class User
    {
        public Guid UserId { get; private set; }
        public string UserRole { get; set; }

        public User(Guid userId, string userRole)
        {
            UserId = userId;
            UserRole = userRole;
        }

        public override string ToString()
        {
            return UserRole;
        }
    }
}
