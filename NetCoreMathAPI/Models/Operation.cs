using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreMathAPI.Models
{
    public class Operation
    {
        public static int Addition(int param1, int param2)
        {
            return param1 + param2;
        }

        public static int Subtraction(int param1, int param2)
        {
            return param1 - param2;
        }

        public static double Pow(int param1, int param2)
        {
            return Math.Pow(param1, param2);
        }
    }
}
