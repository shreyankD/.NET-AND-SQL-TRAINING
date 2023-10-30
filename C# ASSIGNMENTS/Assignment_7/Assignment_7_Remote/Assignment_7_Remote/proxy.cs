using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_7_Remote
{
    public class YourRemoteObject : MarshalByRefObject

    {

        public string HelloWorld()

        {

            return "Hello World from Remote Object!";
              
        }
    }
}
