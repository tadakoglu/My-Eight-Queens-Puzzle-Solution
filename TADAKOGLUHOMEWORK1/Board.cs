using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TADAKOGLUHOMEWORK1
{
    public static class Board
    {
      
        
        public static bool singlesol = false; // INDICATES WHETHER SINGLE SOLUTION BUTTON IS CLICKED OR NOT.
        public static int qrow ;  /// FIRST QUEEN ROW
        public static int qcol ; /// FIRT QUEEN COLUMN
        
        public static int N = 8;  // SOME CLASSES IS ARRANGED FOR 8,BUT CAN BE CHANGED TO N
        public static Stack mystack;  // OUR STACK
        public static bool isSafe(bool[,] board, Stack mystack, int row, int col)
        {

            int i, j; //3,5 row,col

            /* Check this row on right and left side */
            for (i = 0; i < 8; i++)
            {
                if (board[row, i])
                    return false;
            }
            /* Check this column on upper and lower side */
            for (i = 0; i < 8; i++)
            {
                if (board[i, col])
                    return false;
            }

          
            /* * Check upper diagonal on left side */
            for (i = row, j = col; i >= 0 && j >= 0; i--, j--)
            {
                if (board[i, j])
                    return false;
            }
            /* * Check upper diagonal on right side */
            for (i = row, j = col; i >= 0 && j < 8; i--, j++)
            {
                if (board[i, j])
                    return false;
            }


            /* Check lower diagonal on left side */
            for (i = row, j = col; j >= 0 && i < 8; i++, j--)
            {
                if (board[i, j])
                    return false;
            }
            /* Check lower diagonal on RİGHT side */
            for (i = row, j = col; j < 8 && i < 8; i++, j++)
            {
                if (board[i, j])
                    return false;
            }



            return true;
        } // METHOD TRYING TO FIND AN APPROPRIATE LOCATION FOR THE NEXT QUEEN
        public static bool ISOKAY(bool[,] board)
        {

            int i, j; //3,5 row,col                   
            int CT = 0;
             //Check Y=-X;
            for (i = 0, j = 0; j < 8 && i < 8; i++, j++)
            {
                if (board[i, j])
                    CT++;
                               
            }
            if(CT>1)
            return false;
            return true;
        } /// FINAL CONTROL AT SOME PROBLEMATİC POİNTS FOR SOLUTIONS BUTTON
        public static void Move(bool[,] board, Stack mystack)
        {
            // FROM STACK TO BOARD
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    board[i, j] = false;
                }

            }
            for (int i = 0; i < mystack.Count; i++)
            {
                int row = ((Point)mystack.Items(i)).Row;
                int column = ((Point)mystack.Items(i)).Column;
                board[row, column] = true;
            }

        }  // TRANSPORTER FROM STACK TO BOARD               
        public static bool[,] Solve()
        {
                     
            #region BOARD DEFINITONS
            bool[,] board = new bool[N, N]; // 8X8  COORDINATES - BOARD 
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    board[i, j] = false;
                }
            }
            #endregion
            mystack = new Stack(); // FOR 8 QUEENS TO KEEP TRACK OF COORDINATES           
          
            
            int row = 0;
            int column = 0;

            if (singlesol == false)
            {
               
                mystack.Push(new Point(qrow,qcol)); // FIRST QUEEN
                if (qcol == 0)
                    column = 1;
                if (qrow == 0)  
                    row = 1;   
             
             
            }
            bool exitloop = false;
           
            do
            {
                
                while (row < N )
                {
                    
                    exitloop = false;
                    if (isSafe(board, mystack, row, column) == true) //  if there are no conflicts with the queens...
                    {
                        mystack.Push(new Point(row, column)); /*board[row, column]*/
                        Move(board, mystack);
                        column++;
                        
                        if (singlesol == false)/// SIGNLESOL INDICATES THESE THINGS FOR SINGLE SOLUTION BUTTON
                        {
                            if (column == qcol && column != 7)
                                column++;
                        }
                        row = 0;                        
                        exitloop = true;
                    }
                    if (exitloop == true)
                    break;
                    row++;
                    if (singlesol == false)
                    {
                        if (row == qrow)
                            row++;
                    }
                }
                // else if there is a conflict and there is room to shift the current queen rightward...

                if (row == N) // else if there is a conflict and there is *NO ROOM* to shift the current queen rightward...
                {
                    column--;
                    if (singlesol == false)
                    {
                        if (column == qcol && column != 0)
                            column--;
                    }

                    if (mystack.Count == 0)
                    {
                        MessageBox.Show("Stack is empty, means no solution");
                        return null;
                    }
                   
                    row = ((Point)mystack.Pop()).Row + 1; //  PASSING THE NEXT COLUMN                
                    Move(board, mystack);
                   // POP THE QUEEN OFF AND CONTINUE...
                }
            }
            while (column < N ); //BIGWHILE 

            Move(board, mystack);
            return board;
            

        } // SOLVING LOOPS AND THE MAIN PART OF THE PROGRAM.
        
    }
}
