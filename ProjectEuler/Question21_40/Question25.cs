using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
namespace ProjectEuler.Question21_40
{
    public class Question25
    {
        public BigInteger QuestionExecute()
        {
            BigInteger twelvethDigit = 1;
            BigInteger startDigit = 1;
            BigInteger nextDigit = 1;
            BigInteger counter = 2;
            do
            {
                twelvethDigit = startDigit + nextDigit;
                startDigit = nextDigit;
                nextDigit = twelvethDigit;
                counter++;

            } while (twelvethDigit.ToString().Length != 1000);
            
            return counter;
        }
    }
}
