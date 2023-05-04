using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPractices
{
    public class ValidSudoku
    {
        /*
         * Determine if a 9 x 9 Sudoku board is valid. Only the filled cells need to be validated according to the following rules:

            Each row must contain the digits 1-9 without repetition.
            Each column must contain the digits 1-9 without repetition.
            Each of the nine 3 x 3 sub-boxes of the grid must contain the digits 1-9 without repetition.
            Note:

            A Sudoku board (partially filled) could be valid but is not necessarily solvable.
            Only the filled cells need to be validated according to the mentioned rules.
         */
        /*
         * HashSet
         * Key(r/3, c/3)
         * Val set
         */
        public bool IsValidSudoku(char[][] board)
        {

            var rows = new Dictionary<int, HashSet<char>>();
            var cols=new Dictionary<int, HashSet<char>>();
            var subBox = new Dictionary<(int, int), HashSet<char>>();

            for (int r = 0; r< 9; r++)
            {
                rows[r] = new HashSet<char>();
                cols[r] = new HashSet<char>();
                subBox[(r/3, r % 3)] = new HashSet<char> ();
            }

            for (int r = 0; r < 9; ++r)
            {
                for (int c = 0; c < 9; c++)
                {
                    if (board[r][c] == '.')
                    {
                        continue;
                    }
                    if (rows[r].Contains(board[r][c]) || cols[c].Contains(board[r][c]) || subBox[(r/3, c / 3)].Contains(board[r][c]))
                    {
                        return false;
                    }
                    rows[r].Add(board[r][c]);
                    cols[c].Add(board[r][c]);
                    subBox[(r / 3, c / 3)].Add(board[r][c]);
                }
            }
            return true;
        }
    }
}
