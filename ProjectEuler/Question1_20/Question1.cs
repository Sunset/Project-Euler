using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.Question1_20
{
    //PROBLEM URL: https://projecteuler.net/problem=1

    public class Question1
    {
        public int Max = 1000;
        public float total = 0;
        public int a = 3;
        public int b = 5;
        public float QuestionExecute()
        {
            for(int i = 1; i<Max; i++)
            {
                if((i % a == 0) || (i % b == 0))
                {
                    total += i;
                }
            }
            return total;
        }
    }
}
