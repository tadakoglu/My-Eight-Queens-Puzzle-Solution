using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

        
namespace TADAKOGLUHOMEWORK1
{       
    public partial class NQUEENS : Form
    {       
        
        /// <summary>
        ///  ALL BY PROGRAMMED BY TAYFUN ADAKOĞLU. ALGORITHMS REASEARCHED AT UNIVERSITY WEB PAGES. 
        ///  I TRIED TO DO SOME ANIMATIONS FOR STEPPING SECTION,BUT COULD NOT... THANKS.
        /// </summary>
        public NQUEENS()
        {
            InitializeComponent();
            board = new bool[8, 8];

            for (int ROW = 0; ROW < 8; ROW++)
            {
                for (int COL = 0; COL < 8; COL++)
                {
                    board[ROW, COL] = false;
                }
            }
        }
        public static bool[,] board; // TO KEEP TRACK OF QUEENS
        public void Fill(bool[,] board )
        {
            Image queen = Properties.Resources.DDD; // QUEEN IMAGE
            for ( int column = 0; column < 8; column++)
            {
                for (int row = 0; row < 8; row++)
                {
#region A1-A1....H8
                    if (row == 0 && column == 0)
                    {
                        if (board[row, column])
                        A8.Image = queen;
                        else
                        A8.Image = null;                     
                    }
                    if (row == 1 && column == 0)
                    {
                        if (board[row, column])
                            A7.Image = queen;
                        else
                            A7.Image = null;
                    }
                    if (row == 2 && column == 0)
                    {
                        if (board[row, column])
                            A6.Image = queen;
                        else
                            A6.Image = null;
                    }
                    if (row == 3 && column == 0)
                    {
                        if (board[row, column])
                            A5.Image = queen;
                        else
                            A5.Image = null;
                    }
                    if (row == 4 && column == 0)
                    {
                        if (board[row, column])
                            A4.Image = queen;
                        else
                            A4.Image = null;
                    }
                    if (row == 5 && column == 0)
                    {
                        if (board[row, column])
                            A3.Image = queen;
                        else
                            A3.Image = null;
                    }
                    if (row == 6 && column == 0)
                    {
                        if (board[row, column])
                            A2.Image = queen;
                        else
                            A2.Image = null;
                    }
                    if (row == 7 && column == 0)
                    {
                        if (board[row, column])
                            A1.Image = queen;
                        else
                            A1.Image = null;
                    }
                    
                    if (row == 0 && column == 1)
                    {
                        if (board[row, column])
                            B8.Image = queen;
                        else
                            B8.Image = null;
                    }
                    if (row == 1 && column == 1)
                    {
                        if (board[row, column])
                            B7.Image = queen;
                        else
                            B7.Image = null;
                    }
                    if (row == 2 && column == 1)
                    {
                        if (board[row, column])
                            B6.Image = queen;
                        else
                            B6.Image = null;
                    }
                    if (row == 3 && column == 1)
                    {
                        if (board[row, column])
                            B5.Image = queen;
                        else
                            B5.Image = null;
                    }
                    if (row == 4 && column == 1)
                    {
                        if (board[row, column])
                            B4.Image = queen;
                        else
                            B4.Image = null;
                    }
                    if (row == 5 && column == 1)
                    {
                        if (board[row, column])
                            B3.Image = queen;
                        else
                            B3.Image = null;
                    }
                    if (row == 6 && column ==1)
                    {
                        if (board[row, column])
                            B2.Image = queen;
                        else
                            B2.Image = null;
                    }
                    if (row == 7 && column == 1)
                    {
                        if (board[row, column])
                            B1.Image = queen;
                        else
                            B1.Image = null;
                    }
                    if (row == 0  && column == 2)
                    {
                        if (board[row, column])
                            C8.Image = queen;
                        else
                            C8.Image = null;
                    }
                    if (row == 1 && column == 2)
                    {
                        if (board[row, column])
                            C7.Image = queen;
                        else
                            C7.Image = null;
                    }
                    if (row == 2 && column == 2)
                    {
                        if (board[row, column])
                            C6.Image = queen;
                        else
                            C6.Image = null;
                    }
                    if (row == 3 && column == 2)
                    {
                        if (board[row, column])
                            C5.Image = queen;
                        else
                            C5.Image = null;
                    }
                    if (row == 4 && column == 2)
                    {
                        if (board[row, column])
                            C4.Image = queen;
                        else
                            C4.Image = null;
                    }
                    if (row == 5 && column == 2)
                    {
                        if (board[row, column])
                            C3.Image = queen;
                        else
                            C3.Image = null;
                    }
                    if (row == 6 && column == 2)
                    {
                        if (board[row, column])
                            C2.Image = queen;
                        else
                            C2.Image = null;
                    }
                    if (row == 7 && column == 2)
                    {
                        if (board[row, column])
                            C1.Image = queen;
                        else
                            C1.Image = null;
                        
                    }
                    if (row == 0 && column == 3)
                    {
                        if (board[row, column])
                            D8.Image = queen;
                        else
                            D8.Image = null;
                    }
                    if (row == 1 && column == 3)
                    {
                        if (board[row, column])
                            D7.Image = queen;
                        else
                            D7.Image = null;
                    }
                    if (row == 2 && column == 3)
                    {
                        if (board[row, column])
                            D6.Image = queen;
                        else
                            D6.Image = null;
                    }
                    if (row == 3 && column == 3)
                    {
                        if (board[row, column])
                            D5.Image = queen;
                        else
                            D5.Image = null;
                    }
                    if (row == 4 && column == 3)
                    {
                        if (board[row, column])
                            D4.Image = queen;
                        else
                            D4.Image = null;
                    }
                    if (row == 5 && column == 3)
                    {
                        if (board[row, column])
                            D3.Image = queen;
                        else
                            D3.Image = null;
                    }
                    if (row == 6 && column == 3)
                    {
                        if (board[row, column])
                            D2.Image = queen;
                        else
                            D2.Image = null;
                    }
                    if (row == 7 && column == 3)
                    {
                        if (board[row, column])
                            D1.Image = queen;
                        else
                            D1.Image = null;
                    }
                    if (row == 0 && column == 4)
                    {
                        if (board[row, column])
                            E8.Image = queen;
                        else
                            E8.Image = null;
                    }
                    if (row == 1 && column == 4)
                    {
                        if (board[row, column])
                            E7.Image = queen;
                        else
                            E7.Image = null;
                    }
                    if (row == 2 && column == 4)
                    {
                        if (board[row, column])
                            E6.Image = queen;
                        else
                            E6.Image = null;
                    }
                    if (row == 3 && column == 4)
                    {
                        if (board[row, column])
                            E5.Image = queen;
                        else
                            E5.Image = null;
                    }
                    if (row == 4 && column == 4)
                    {
                        if (board[row, column])
                            E4.Image = queen;
                        else
                            E4.Image = null;
                    }
                    if (row == 5 && column == 4)
                    {
                        if (board[row, column])
                            E3.Image = queen;
                        else
                            E3.Image = null;
                    }
                    if (row == 6 && column == 4)
                    {
                        if (board[row, column])
                            E2.Image = queen;
                        else
                            E2.Image = null;
                    }
                    if (row == 7 && column == 4)
                    {
                        if (board[row, column])
                            E1.Image = queen;
                        else
                            E1.Image = null;
                    }
                    if (row == 0 && column == 5)
                    {
                        if (board[row, column])
                            F8.Image = queen;
                        else
                            F8.Image = null;
                    }
                    if (row == 1 && column == 5)
                    {
                        if (board[row, column])
                            F7.Image = queen;
                        else
                            F7.Image = null;
                    }
                    if (row == 2 && column == 5)
                    {
                        if (board[row, column])
                            F6.Image = queen;
                        else
                            F6.Image = null;
                    }
                    if (row == 3 && column == 5)
                    {
                        if (board[row, column])
                            F5.Image = queen;
                        else
                            F5.Image = null;
                    }
                    if (row == 4 && column == 5)
                    {
                        if (board[row, column])
                            F4.Image = queen;
                        else
                            F4.Image = null;
                    }
                    if (row == 5 && column == 5)
                    {
                        if (board[row, column])
                            F3.Image = queen;
                        else
                            F3.Image = null;
                    }
                    if (row == 6 && column == 5)
                    {
                        if (board[row, column])
                            F2.Image = queen;
                        else
                            F2.Image = null;
                    }
                    if (row == 7 && column == 5)
                    {
                        if (board[row, column])
                            F1.Image = queen;
                        else
                            F1.Image = null;
                    }
                    if (row == 0 && column == 6)
                    {
                        if (board[row, column])
                            G8.Image = queen;
                        else
                            G8.Image = null;
                    }
                    if (row == 1 && column == 6)
                    {
                        if (board[row, column])
                            G7.Image = queen;
                        else
                            G7.Image = null;
                    }
                    if (row == 2 && column == 6)
                    {
                        if (board[row, column])
                            G6.Image = queen;
                        else
                            G6.Image = null;
                    }
                    if (row == 3 && column == 6)
                    {
                        if (board[row, column])
                        G5.Image = queen;
                        else
                        G5.Image = null;                     
                    }
                    if (row == 4 && column == 6)
                    {
                        if (board[row, column])
                        G4.Image = queen;
                        else
                        G4.Image = null;                     
                    }
                    if (row == 5 && column == 6)
                    {
                        if (board[row, column])
                        G3.Image = queen;
                        else
                        G3.Image = null;                     
                    }
                    if (row == 6 && column == 6)
                    {
                        if (board[row, column])
                        G2.Image = queen;
                        else
                        G2.Image = null;                     
                    }
                    if (row == 7 && column == 6)
                    {
                        if (board[row, column])
                        G1.Image = queen;
                        else
                        G1.Image = null;                     
                    }
                    if (row == 0 && column == 7)
                    {
                        if (board[row, column])
                        H8.Image = queen;
                        else
                        H8.Image = null;                     
                    }
                    if (row == 1 && column == 7)
                    {
                        if (board[row, column])
                        H7.Image = queen;
                        else
                        H7.Image = null;                     
                    }
                    if (row == 2 && column == 7)
                    {
                        if (board[row, column])
                        H6.Image = queen;
                        else
                        H6.Image = null;                     
                    }
                    if (row == 3 && column == 7)
                    {
                        if (board[row, column])
                        H5.Image = queen;
                        else
                        H5.Image = null;                     
                    }
                    if (row == 4 && column == 7)
                    {
                        if (board[row, column])
                        H4.Image = queen;
                        else
                        H4.Image = null;                     
                    }
                    if (row == 5 && column == 7)
                    {
                        if (board[row, column])
                            H3.Image = queen;
                        else
                            H3.Image = null;
                    }
                    if (row == 6 && column == 7)
                    {
                        if (board[row, column])
                            H2.Image = queen;
                        else
                            H2.Image = null;
                    }
                    if (row == 7 && column == 7)
                    {
                        if (board[row, column])
                            H1.Image = queen;
                        else
                            H1.Image = null;
                    }
#endregion   // FOR PLACING THE QUEEN PICTURES

                }

            }
        } // COMPLETE FILLING METHOD
        public void Fillstepbystep(int row,int column) /// OVERLOADED STEP BY STEP FILLING METHOD
        {
            Image queen = Properties.Resources.DDD; // queen image
            
                    #region A1-A1....H8
                    if (row == 0 && column == 0)
                    {
                        if (board[row, column])
                            A8.Image = queen;
                        else
                            A8.Image = null;
                    }
                    if (row == 1 && column == 0)
                    {
                        if (board[row, column])
                            A7.Image = queen;
                        else
                            A7.Image = null;
                    }
                    if (row == 2 && column == 0)
                    {
                        if (board[row, column])
                            A6.Image = queen;
                        else
                            A6.Image = null;
                    }
                    if (row == 3 && column == 0)
                    {
                        if (board[row, column])
                            A5.Image = queen;
                        else
                            A5.Image = null;
                    }
                    if (row == 4 && column == 0)
                    {
                        if (board[row, column])
                            A4.Image = queen;
                        else
                            A4.Image = null;
                    }
                    if (row == 5 && column == 0)
                    {
                        if (board[row, column])
                            A3.Image = queen;
                        else
                            A3.Image = null;
                    }
                    if (row == 6 && column == 0)
                    {
                        if (board[row, column])
                            A2.Image = queen;
                        else
                            A2.Image = null;
                    }
                    if (row == 7 && column == 0)
                    {
                        if (board[row, column])
                            A1.Image = queen;
                        else
                            A1.Image = null;
                    }

                    if (row == 0 && column == 1)
                    {
                        if (board[row, column])
                            B8.Image = queen;
                        else
                            B8.Image = null;
                    }
                    if (row == 1 && column == 1)
                    {
                        if (board[row, column])
                            B7.Image = queen;
                        else
                            B7.Image = null;
                    }
                    if (row == 2 && column == 1)
                    {
                        if (board[row, column])
                            B6.Image = queen;
                        else
                            B6.Image = null;
                    }
                    if (row == 3 && column == 1)
                    {
                        if (board[row, column])
                            B5.Image = queen;
                        else
                            B5.Image = null;
                    }
                    if (row == 4 && column == 1)
                    {
                        if (board[row, column])
                            B4.Image = queen;
                        else
                            B4.Image = null;
                    }
                    if (row == 5 && column == 1)
                    {
                        if (board[row, column])
                            B3.Image = queen;
                        else
                            B3.Image = null;
                    }
                    if (row == 6 && column == 1)
                    {
                        if (board[row, column])
                            B2.Image = queen;
                        else
                            B2.Image = null;
                    }
                    if (row == 7 && column == 1)
                    {
                        if (board[row, column])
                            B1.Image = queen;
                        else
                            B1.Image = null;
                    }
                    if (row == 0 && column == 2)
                    {
                        if (board[row, column])
                            C8.Image = queen;
                        else
                            C8.Image = null;
                    }
                    if (row == 1 && column == 2)
                    {
                        if (board[row, column])
                            C7.Image = queen;
                        else
                            C7.Image = null;
                    }
                    if (row == 2 && column == 2)
                    {
                        if (board[row, column])
                            C6.Image = queen;
                        else
                            C6.Image = null;
                    }
                    if (row == 3 && column == 2)
                    {
                        if (board[row, column])
                            C5.Image = queen;
                        else
                            C5.Image = null;
                    }
                    if (row == 4 && column == 2)
                    {
                        if (board[row, column])
                            C4.Image = queen;
                        else
                            C4.Image = null;
                    }
                    if (row == 5 && column == 2)
                    {
                        if (board[row, column])
                            C3.Image = queen;
                        else
                            C3.Image = null;
                    }
                    if (row == 6 && column == 2)
                    {
                        if (board[row, column])
                            C2.Image = queen;
                        else
                            C2.Image = null;
                    }
                    if (row == 7 && column == 2)
                    {
                        if (board[row, column])
                            C1.Image = queen;
                        else
                            C1.Image = null;

                    }
                    if (row == 0 && column == 3)
                    {
                        if (board[row, column])
                            D8.Image = queen;
                        else
                            D8.Image = null;
                    }
                    if (row == 1 && column == 3)
                    {
                        if (board[row, column])
                            D7.Image = queen;
                        else
                            D7.Image = null;
                    }
                    if (row == 2 && column == 3)
                    {
                        if (board[row, column])
                            D6.Image = queen;
                        else
                            D6.Image = null;
                    }
                    if (row == 3 && column == 3)
                    {
                        if (board[row, column])
                            D5.Image = queen;
                        else
                            D5.Image = null;
                    }
                    if (row == 4 && column == 3)
                    {
                        if (board[row, column])
                            D4.Image = queen;
                        else
                            D4.Image = null;
                    }
                    if (row == 5 && column == 3)
                    {
                        if (board[row, column])
                            D3.Image = queen;
                        else
                            D3.Image = null;
                    }
                    if (row == 6 && column == 3)
                    {
                        if (board[row, column])
                            D2.Image = queen;
                        else
                            D2.Image = null;
                    }
                    if (row == 7 && column == 3)
                    {
                        if (board[row, column])
                            D1.Image = queen;
                        else
                            D1.Image = null;
                    }
                    if (row == 0 && column == 4)
                    {
                        if (board[row, column])
                            E8.Image = queen;
                        else
                            E8.Image = null;
                    }
                    if (row == 1 && column == 4)
                    {
                        if (board[row, column])
                            E7.Image = queen;
                        else
                            E7.Image = null;
                    }
                    if (row == 2 && column == 4)
                    {
                        if (board[row, column])
                            E6.Image = queen;
                        else
                            E6.Image = null;
                    }
                    if (row == 3 && column == 4)
                    {
                        if (board[row, column])
                            E5.Image = queen;
                        else
                            E5.Image = null;
                    }
                    if (row == 4 && column == 4)
                    {
                        if (board[row, column])
                            E4.Image = queen;
                        else
                            E4.Image = null;
                    }
                    if (row == 5 && column == 4)
                    {
                        if (board[row, column])
                            E3.Image = queen;
                        else
                            E3.Image = null;
                    }
                    if (row == 6 && column == 4)
                    {
                        if (board[row, column])
                            E2.Image = queen;
                        else
                            E2.Image = null;
                    }
                    if (row == 7 && column == 4)
                    {
                        if (board[row, column])
                            E1.Image = queen;
                        else
                            E1.Image = null;
                    }
                    if (row == 0 && column == 5)
                    {
                        if (board[row, column])
                            F8.Image = queen;
                        else
                            F8.Image = null;
                    }
                    if (row == 1 && column == 5)
                    {
                        if (board[row, column])
                            F7.Image = queen;
                        else
                            F7.Image = null;
                    }
                    if (row == 2 && column == 5)
                    {
                        if (board[row, column])
                            F6.Image = queen;
                        else
                            F6.Image = null;
                    }
                    if (row == 3 && column == 5)
                    {
                        if (board[row, column])
                            F5.Image = queen;
                        else
                            F5.Image = null;
                    }
                    if (row == 4 && column == 5)
                    {
                        if (board[row, column])
                            F4.Image = queen;
                        else
                            F4.Image = null;
                    }
                    if (row == 5 && column == 5)
                    {
                        if (board[row, column])
                            F3.Image = queen;
                        else
                            F3.Image = null;
                    }
                    if (row == 6 && column == 5)
                    {
                        if (board[row, column])
                            F2.Image = queen;
                        else
                            F2.Image = null;
                    }
                    if (row == 7 && column == 5)
                    {
                        if (board[row, column])
                            F1.Image = queen;
                        else
                            F1.Image = null;
                    }
                    if (row == 0 && column == 6)
                    {
                        if (board[row, column])
                            G8.Image = queen;
                        else
                            G8.Image = null;
                    }
                    if (row == 1 && column == 6)
                    {
                        if (board[row, column])
                            G7.Image = queen;
                        else
                            G7.Image = null;
                    }
                    if (row == 2 && column == 6)
                    {
                        if (board[row, column])
                            G6.Image = queen;
                        else
                            G6.Image = null;
                    }
                    if (row == 3 && column == 6)
                    {
                        if (board[row, column])
                            G5.Image = queen;
                        else
                            G5.Image = null;
                    }
                    if (row == 4 && column == 6)
                    {
                        if (board[row, column])
                            G4.Image = queen;
                        else
                            G4.Image = null;
                    }
                    if (row == 5 && column == 6)
                    {
                        if (board[row, column])
                            G3.Image = queen;
                        else
                            G3.Image = null;
                    }
                    if (row == 6 && column == 6)
                    {
                        if (board[row, column])
                            G2.Image = queen;
                        else
                            G2.Image = null;
                    }
                    if (row == 7 && column == 6)
                    {
                        if (board[row, column])
                            G1.Image = queen;
                        else
                            G1.Image = null;
                    }
                    if (row == 0 && column == 7)
                    {
                        if (board[row, column])
                            H8.Image = queen;
                        else
                            H8.Image = null;
                    }
                    if (row == 1 && column == 7)
                    {
                        if (board[row, column])
                            H7.Image = queen;
                        else
                            H7.Image = null;
                    }
                    if (row == 2 && column == 7)
                    {
                        if (board[row, column])
                            H6.Image = queen;
                        else
                            H6.Image = null;
                    }
                    if (row == 3 && column == 7)
                    {
                        if (board[row, column])
                            H5.Image = queen;
                        else
                            H5.Image = null;
                    }
                    if (row == 4 && column == 7)
                    {
                        if (board[row, column])
                            H4.Image = queen;
                        else
                            H4.Image = null;
                    }
                    if (row == 5 && column == 7)
                    {
                        if (board[row, column])
                            H3.Image = queen;
                        else
                            H3.Image = null;
                    }
                    if (row == 6 && column == 7)
                    {
                        if (board[row, column])
                            H2.Image = queen;
                        else
                            H2.Image = null;
                    }
                    if (row == 7 && column == 7)
                    {
                        if (board[row, column])
                            H1.Image = queen;
                        else
                            H1.Image = null;
                    }
                    #endregion               
        }
        private void button5_Click(object sender, EventArgs e) // SINGLE SOLUTION BUTTON
        {
            
            Board.singlesol = true;
            Fill(Board.Solve());
            button6.Text = "Solutions(Click:N)";
            Board.qrow = 0;
            NQUEENS.counter = 0;
         
       
           
         
            i = Board.mystack.Count - 1; ;
        }
        #region TITLE BAR EVENTS
        bool toggle; // FOR TITLE BAR EVENTS
        int x, y; // FOR TITLE BAR EVENTS

        private void button7_MouseDown(object sender, MouseEventArgs e)
        {
            toggle = true;
            x = e.X;
            y = e.Y;
        } // FOR TITLE BAR EVENTS
        private void button7_MouseMove(object sender, MouseEventArgs e)
        {
            if (toggle)
                this.SetDesktopLocation(MousePosition.X - x, MousePosition.Y - y);

        } // FOR TITLE BAR EVENTS
        private void button7_MouseUp(object sender, MouseEventArgs e)
        {
            toggle = false;
        } // FOR TITLE BAR EVENTS
        #endregion
        public static int counter = 0;
        Random rc;   // FOR RANDOM SOLUTIONS       
        private void button6_Click(object sender, EventArgs e)
        {
            int temp1, temp2;
            
            rc = new Random();            
            if (Board.qrow != (temp1 = rc.Next(1,7)) && Board.qcol != (temp2 = rc.Next(7)))
            {
                Board.qrow = temp1;
                Board.qcol = temp2;
                while (!Board.ISOKAY(Board.Solve()))
                {
                    Board.qrow = rc.Next(1, 7);
                    Board.qcol = rc.Next(1, 7);
                }

            
            }
            Board.singlesol = false;
            //MessageBox.Show(Board.qrow.ToString() + "," + Board.qcol.ToString());
            counter++;          
            Fill(Board.Solve());               
           
           
            button6.Text = "Solutions(Click:" + counter + ")";

            
           
            i = Board.mystack.Count - 1; ;

            
        } // RANDOM SOLUTIONS BUTTON
        private void button4_Click(object sender, EventArgs e)
        {
            if(Board.mystack!=null)
            Board.mystack.Clear();
            next.Enabled = false;
          
            next.Text = "Locked:>";
      
            button6.Text = "Solutions(Click:N)";
            Board.qrow = 0;
            NQUEENS.counter = 0;
            A1.Image = null;
                A2.Image = null;
                A3.Image = null;
                    A4.Image = null;
                    A5.Image = null;
                        A6.Image = null;
                        A7.Image = null;
                            A8.Image = null;
                            B1.Image = null;
                                B2.Image = null;
                                B3.Image = null;
                                    B4.Image = null;
                                    B5.Image = null;
                                        B6.Image = null;

                                        B7.Image = null;
                                            B8.Image = null;
                                            C1.Image = null;
                                                C2.Image = null;
                                                C3.Image = null;
                                                    C4.Image = null;
                                                    C5.Image = null;
                                                        C6.Image = null;
                                                        C7.Image = null;
                                                            C8.Image = null;
                                                            D1.Image = null;
                                                                D2.Image = null;
                                                                D3.Image = null;
                                                                    D4.Image = null;
                                                                    D5.Image = null;
                                                                        D6.Image = null;
                                                                        D7.Image = null;
                                                                            D8.Image = null;
                                                                            E1.Image = null;
                                                                                E2.Image = null;
                                                                                E3.Image = null;
                                                                                    E4.Image = null;
                                                                                    E5.Image = null;
                                                                                        E6.Image = null;
                                                                                        E7.Image = null;
                                                                                            E8.Image = null;
                                                                                            F1.Image = null;
                                                                                                F2.Image = null;
                                                                                                F3.Image = null;
                                                                                                    F4.Image = null;
                                                                                                    F5.Image = null;
                                                                                                        F6.Image = null;
                                                                                                        F7.Image = null;
                                                                                                            F8.Image = null;
                                                                                            G1.Image = null;
                                                                                                G2.Image = null;
                                                                                                G3.Image = null;
                                                                                                    G4.Image = null;
                                                                                                    G5.Image = null;
                                                                                                        G6.Image = null;
                                                                                                        G7.Image = null;
                                                                                                            G8.Image = null;
                                                                                                            H1.Image = null;
                                                                                                                H2.Image = null;

                                                                                                                H3.Image = null;
                                                                                                                    H4.Image = null;
                                                                                                                    H5.Image = null;
                                                                                                                        H6.Image = null;
                                                                                                                        H7.Image = null;
                                                                                                                            H8.Image = null;
                                                                                            

        } // CLEAR BOARD BUTTON
        private void button1_Click(object sender, EventArgs e)  // EXIT BUTTON
        {
            this.Close();
        }      
        private void NQUEENS_Load(object sender, EventArgs e)
        {
            next.Enabled = false;
       
            next.Text = "Locked:>";
          
        } // MAIN FORM LOAD
        int i; // STEP COUNTER
        private void next_Click(object sender, EventArgs e)
        {

            for (; i <= 7; )
            {
                int row = ((Point)Board.mystack.Items(i)).Row;
                int column = ((Point)Board.mystack.Items(i)).Column;
                board[row, column] = true;
                Fillstepbystep(row, column);
                //SCREEN IT.
                i++;
                break;
            }

          
            
            
        } // NEXT STEP BUTTON      

        

        private void button2_Click(object sender, EventArgs e)
        {
            i = 1;
            if (Board.mystack == null || Board.mystack.Count == 0)
            {
                MessageBox.Show("At first,please show any solution on board!", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            next.Enabled = true;
            next.Text = "NEXT STEP";
            int row, col;
            for ( row = 0; row < 8; row++)
            {
                for ( col = 0; col < 8; col++)
                {
                    board[row, col] = false;
                    
                }
            }

                Fill(board);
                row = ((Point)Board.mystack.Items(0)).Row;
                col = ((Point)Board.mystack.Items(0)).Column;
                board[row, col] = true;
                Fillstepbystep(row, col);
                //SCREEN IT.
            
         } // START STEPPING BUTTON

        
    }
}
