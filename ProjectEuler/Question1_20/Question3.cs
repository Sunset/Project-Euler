using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.Question1_20
{
    //Problem URL: https://projecteuler.net/problem=3
    public class Question3
    {
        public long max = 600851475143;
        public float QuestionExecute()
        {
            float result = 0;

            for (long i = 2; i < max; i++)
            {
                if (max % i == 0)
                {
                    if (FindIfPrime(i))
                    {
                        result = i;
                    }
                }
            }

            return result;
        }

        public bool FindIfPrime(long i)
        {

            var k = (long)Math.Floor(Math.Sqrt(i));
            int a = 0;
            for(int j = 1; j <= k; j++)
            {
                if (i % j == 0)
                {
                    a++;
                }
            }
            if (a < 2)
                return true;
            else
                return false;
        }
    }
}
