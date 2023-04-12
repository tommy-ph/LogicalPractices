using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPractices
{
    public class ReverseInteger
    {
        /*  Reverse Integer
         *  Given a signed 32-bit integer x, return x with its digits reversed. 
         *  If reversing x causes the value to go outside the signed 32-bit integer 
         *  range [-231, 231 - 1], then return 0.

            Assume the environment does not allow you to store 64-bit integers (signed or unsigned).
            Example 1:
            Input: x = 123
            Output: 321

            Example 2:
            Input: x = -123
            Output: -321

            Example 3:
            Input: x = 120
            Output: 21
         */
        /*
         * Function reverse(integer x)

            // Initialize a variable called 'reversed' to store the result
            Set reversed to 0

            // Check if the input integer is negative
            If n < 0:
                Set is_negative to True
                Set n to -n
            Else:
                Set is_negative to False

            // While the input integer is not equal to 0
            While n > 0:
        
                // Multiply the current value of 'reversed' by 10 to make room for the next digit
                Set reversed to reversed * 10
        
                // Extract the last digit of the input integer and add it to 'reversed'
                Set last_digit to n % 10
                Set reversed to reversed + last_digit
        
                // Remove the last digit from the input integer
                Set n to n / 10

            // If the input integer was negative, make the reversed integer negative as well
            If is_negative:
                Set reversed to -reversed

            Return reversed

        End Function

         */

        public int Reverse(int x)
        {
            int ReversNum = 0;
            int RemainNum;
            bool IsNagative = false;

            if(x < 0)
            {
                IsNagative= true;
                x =-x; 
            }
            else
            {
                IsNagative= false;
            }

            while(x> 0)
            {
                RemainNum = x % 10;
                ReversNum = (ReversNum * 10) + RemainNum;
                x = x/10;
                
            }

            if (IsNagative)
            {
                ReversNum = -ReversNum;
               
            }

            return ReversNum;
        }
    }
}
