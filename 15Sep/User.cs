using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15Sep
{
    public class User
    {
        public string name;

        public User(string name)
        {
            this.name = name;
        }
        public User()
        {

        }
        public override string ToString()
        {
            return name;
        }
    }
}
