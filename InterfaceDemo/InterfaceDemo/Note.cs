using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo
{
    //prwta klhronomikothta kai meta vazw to interface
    class Note : Storable
    {
        public void Write(object obj)
        {
            Console.WriteLine("Writing object to disk...");
        }

        public String Read()
        {
            return "Reading note from disk";
        }

        private ReturnStatus status;
        public ReturnStatus Status
        {
            get
            {
                return status;
            }
            set
            {
                status = value;
            }
        }
        
        public void otherMethod()
        {
            Console.WriteLine("This is another method");
        }
    }
}
