using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.Question1_20
{
    public class Question10
    {
        public long QuestionExecute()
        {
            long primeAdditionTotal = 0;

            for (long i = 2; i < 2000000; i++)
            {
                if (FindIfPrime(i))
                {
                    primeAdditionTotal += i;
                }
            }

            return primeAdditionTotal;
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
