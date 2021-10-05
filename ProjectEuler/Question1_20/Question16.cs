using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
namespace ProjectEuler.Question1_20
{
    public class Question16
    {
        public void QuestionExecute()
        {
            BigInteger bigint = new BigInteger();
            bigint = (BigInteger)Math.Pow(2.0, 1000);

            string bigIntString = bigint.ToString();

            long bigIntTotal = 0;

            for(int i = 0; i<bigIntString.Count(); i++)
            {
                bigIntTotal += long.Parse(bigIntString.Substring(i,1));
            }
            Console.WriteLine(bigIntTotal);
        }
    }
}
