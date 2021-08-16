using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.Question1_20
{
    public class Question4
    {
        public int QuestionExecute()
        {
            var a = 100;
            var b = 100;
            var result = 0;
            for(int i = a; i<999; i++)
            {
                for (int j = b; j < 999; j++)
                {
                    var c = i * j;
                    var cReverse = ReverseMe(c.ToString());
                    if (IsPallendrome(c.ToString(), cReverse))
                    {
                        if (c > result)
                        {
                            result = c;
                        }
                    }
                }
            }

            return result;
        }

        public string ReverseMe(string value)
        {
            return new string(value.Reverse().ToArray());
        }

        public bool IsPallendrome(string a, string b)
        {
            return a.Equals(b);
        }
    }
}
