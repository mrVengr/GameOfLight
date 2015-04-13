using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLight.Lib
{
    public class User
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public User(string username)
        {
            Name = username;
        }

        public User()
        { 
        }

    }
}
