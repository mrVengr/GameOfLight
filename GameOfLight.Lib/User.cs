using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLight.Lib
{
    public class User
    {
        private Guid userId;
        public Guid UserId
        {
            get { return userId; }
            set { userId = value; }
        }


        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public User(string username)
        {
            UserId = Guid.NewGuid();
            Name = username;
        }

        public User()
        {
            UserId = Guid.NewGuid();
        }

    }
}
