using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPractices
{
    /*
     * The string "PAYPALISHIRING" is written in a zigzag pattern on a given number of
        rows like this: (you may want to display this pattern in a fixed font for better
        legibility)
        P A H N A
        P L S I I GY I
        R
        And then read line by line: "PAHNAPLSIIGYIR"
        Write the code that will take a string and make this conversion given a number
        of rows:
        string convert(string s, int numRows);
        Example 1:
        Input: s = "PAYPALISHIRING", numRows = 3
        Output: "PAHNAPLSIIGYIR"
        Example 2:
        Input: s = "PAYPALISHIRING", numRows = 4
        Output: "PINALSIGYAHRPI"
        Explanation:
        P I N
        A L S I G
        Y A H R
        P I
     */
    /* Sudo code
     * function zigzag_conversion(string s, int numrows):
        if numrows == 1 or numrows >= length(s):
            return input_string

        rows = initialize an empty list of strings with size num_rows
        currentrow = 0
        direction = "down"

        for character in input_string:
            rows[current_row] += character

            if currentrow == 0:
                direction = "down"
            elif currentrow == numrows - 1:
                direction = "up"

            if direction == "down":
                currentrow += 1
            else:
                currentrow -= 1

        outputstring = concatenate all strings in rows
        return outputstring

     * 
     */
    public class ZigZagConversion
    {
        public string ConvertStringToRowNumber(string s, int numRows)
        {
            //If numRows is 1 or greater than or equal to the input string's length,
            //there's no need for any conversion;
            //simply return the input string as is:
            if (numRows == 1 || numRows >= s.Length)
            {
                return s;
            }
            //Initialize an array of StringBuilder objects called rows with the size equal to numRows.
            //This array will store each row of the zigzag pattern:
            StringBuilder[] Rows = new StringBuilder[numRows]; 
            for(int i = 0; i < numRows; i++)
            {
                Rows[i] = new StringBuilder();
            }

            //Initialize variables currentRow and direction to keep track of the current row position
            //and direction (up or down) while constructing the zigzag pattern:
            int CurrentRow = 0 ;
            string Direction = "Up" ;

            //Iterate through each character in the input string:
            foreach ( char c in s )
            {
                // Append the character to the corresponding row in the rows array:
                Rows[CurrentRow].Append( c );

                //Update the direction if needed.If currentRow is 0, set the direction to "down".
                //If currentRow is numRows - 1, set the direction to "up":
                if (CurrentRow == 0)
                {
                    Direction = "Down";
                }
                else if(CurrentRow == numRows- 1)
                {
                    Direction = "Up";
                }

                if(Direction == "Down")
                {
                    CurrentRow += 1;
                }
                else
                {
                    CurrentRow -= 1;
                }
            }

            //Concatenate all the strings in the rows array to create the final output string.
            //Use a StringBuilder called outputString to store the final result:
            StringBuilder outputString = new StringBuilder();
            for(int i = 0; i < numRows;i++) 
            {
                outputString.Append(Rows[i]);
            }
            //Return the output string
            return outputString.ToString();
        }
    }
}
