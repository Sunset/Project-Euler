using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.Question1_20
{
    public class Question6
    {
        public long QuestionExecute()
        {
            long SumOfSquares = 0;
            long SquareOfSums = 0;

            for (int i = 1; i <= 100; i++)
            {
                SumOfSquares += (long)Math.Pow(i, 2);
            }

            for (int i = 1; i <= 100; i++)
            {
                SquareOfSums += i;
            }
            SquareOfSums = (long)Math.Pow(SquareOfSums, 2);

            var result = SquareOfSums - SumOfSquares;
            return result;
        }
    }
}
