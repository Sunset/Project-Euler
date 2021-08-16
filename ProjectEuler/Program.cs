using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Question1_20.Question10 question = new Question1_20.Question10();
            Console.WriteLine("Answer is: " + question.QuestionExecute());
        }
    }
}
