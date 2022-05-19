using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.Question1_20
{
    public class Question13
    {
        public string QuestionExecute()
        {
            BigInteger result = new BigInteger();
            string line;

            using (var sr = new StreamReader("<PATH TO THE PROBLEM13Data.txt>"))
            {
                while ((line = sr.ReadLine()) != null)
                {
                    result += BigInteger.Parse(line);
                }
            }

            return result.ToString().Substring(0, 10);
        }
    }
}
