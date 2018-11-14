using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLFromConsole
{
    class User
    {
        public int ID { get; set; }
        public string Name { get; set;}
        public string Password { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb
                .Append($"User ID is {ID}\n")
                .Append($"User Name is {Name}\n")
                .Append($"User Password is {Password}\n");
            return sb.ToString();
        }
    }
}
