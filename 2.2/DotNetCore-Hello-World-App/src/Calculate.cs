using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCore_Hello_World_App
{
    public class Calculate
    {
        

        public int Number1 { get; set; }
        public int Number2 { get; set; }

        public int Add(int value1, int value2)
        {
            return value1 + value2;
        }
    }
}
