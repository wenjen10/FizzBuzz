using System;
using System.Collections.Generic;
using System.Text;

namespace FizzBuzz
{
    public class FizzBuzz
    {
        public string Get(int num)
        {
            if (IsMultipleOf3(num))
            {
                return "Fizz";
            }
            if(num == 5)

            {
                return "Buzz";
            }
            return num.ToString();
        }
        private bool IsMultipleOf3(int numberToCheck)
        {
            return numberToCheck % 3 == 0;
        }
        
    }
}  
 

