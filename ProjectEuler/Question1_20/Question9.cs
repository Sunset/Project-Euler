using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.Question1_20
{
    public class Question9
    {
        public long QuestionExecute()
        {
            var curMaxProduct = 0;

            for(int a = 1; a < 988; a++)
            {
                for (int b = a + 1; b < 988; b++)
                {
                    for (int c = b + 1; c < 988; c++)
                    {
                        if (isCondition(a, b, c))
                        {
                            curMaxProduct = a * b * c;
                        }
                    }
                }
            }

            return curMaxProduct;
        }

        public bool isCondition(int a, int b, int c)
        {
            if((a + b + c == 1000) && (c == Math.Sqrt(Math.Pow(a,2) + Math.Pow(b, 2))))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
