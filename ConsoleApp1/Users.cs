using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Users
    {
        public Users() { }

        private int v;

        public Users(int v, string name)
        {
            this.v = v;
            Name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public static Users operator ++(Users users)
        {
            users.Id++;
            return users;
        }
    }
}
