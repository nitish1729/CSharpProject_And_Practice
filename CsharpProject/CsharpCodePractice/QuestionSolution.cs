using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpCodePractice
{
    public class QuestionSolution
    {
        public void PresAbs()
        {
            int present = 1;
            int absent = 0;

            Random random = new Random();
            int AttenCheck = random.Next(0, 9);
            if (AttenCheck == present)
            {
                Console.WriteLine("Emp is Present");
            }
            else { Console.WriteLine("Emp is not Present"); }
        }

    }  
}
