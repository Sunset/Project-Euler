using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.Question1_20
{
    //Problem URL: https://projecteuler.net/problem=2
    public class Question2
    {
        public float a = 1;
        public float b = 2;
        public float QuestionExecute()
        {
            float total = 2;
            float next = a + b;

            while(next<4000000)
            {
                if (next % 2 == 0)
                {
                    total += next;
                }
                a = b;
                b = next;
                next = a + b;
            }

            return total;
        }
    }
}
