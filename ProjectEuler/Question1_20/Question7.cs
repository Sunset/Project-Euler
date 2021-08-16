using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.Question1_20
{
    public class Question7
    {
        public long QuestionExecute()
        {
            var count = 0;
            var value = 1;
            do
            {
                value++;
                if (FindIfPrime(value))
                {
                    count++;
                }
                if(count == 10000)
                {
                    var a = 0;
                }
            } while (count < 10001);

            return value;
        }

        public bool FindIfPrime(long i)
        {

            var k = (long)Math.Floor(Math.Sqrt(i));
            int a = 0;
            for (int j = 1; j <= k; j++)
            {
                if (i % j == 0)
                {
                    a++;
                    if (a >= 2)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
