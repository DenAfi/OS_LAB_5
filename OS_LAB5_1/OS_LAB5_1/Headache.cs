using System;
using System.Collections.Generic;
using System.Text;

namespace OS_LAB5_1
{
    class Headache
    {
        public int[,] arr;
        public int sum;
        public string ThreadID;
        public Headache(ref int[,] arr,ref int sum)
        {
            this.sum = sum;
            this.arr = arr;
        }
    }
}
