using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.Question21_40
{
    public class Question30
    {
        public long QuestionExecute()
        {
            //max is 9^5 *5 = 295245. max 6 digits
            int maxNum = 999999;

            long returnSum = 0;

            for(int i = 2; i< maxNum; i++)
            {
                var valToCheck = isEqualPow5(i);
                if(valToCheck != 0)
                {
                    returnSum += valToCheck;
                }
            }

            return returnSum;
        }

        public long isEqualPow5(int i)
        {
            var temp = i;

            List<int> listOfInts = new List<int>();
            while(i > 0)
            {
                listOfInts.Add(i % 10);
                i = i / 10;
            }
            listOfInts.Reverse();

            long valToCheck = 0;
            foreach(var integer in listOfInts)
            {
                valToCheck += (long)Math.Pow(integer, 5);
            }
            if( temp == valToCheck)
            {
                Console.WriteLine(valToCheck);
                return valToCheck;
            }
            else
            {
                return 0;
            }
        }
    }
}
