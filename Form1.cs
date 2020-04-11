using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ConnectFour
{
    public partial class Form1 : Form
    {
        bool TurnBool = false; //red=false, yellow = true
        int turnCounter = 0;
        Pieces RedPiece = new Pieces();
        Pieces YellowPiece = new Pieces();
        char[] Column1 = new char[8];
        char[] Column2 = new char[8];
        char[] Column3 = new char[8];
        char[] Column4 = new char[8];
        char[] Column5 = new char[8];
        char[] Column6 = new char[8];
        char[] Column7 = new char[8];
        int column1Count;
        int column2Count;
        int column3Count;
        int column4Count;
        int column5Count;
        int column6Count;
        int column7Count;
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// drawing each piece, column by column.
        /// piece data is kept in a char array
        /// for each column. this function draws
        /// column by column, changing the color
        /// based on the current iteration of the
        /// char array
        /// </summary>
        public void Form1_Paint(object sender, PaintEventArgs e)
        {
            for (int i = 0; i < column7Count; i++)//COLUMN 7
            {
                if (i == 0)
                {
                    YellowPiece.y = 430;
                    RedPiece.y = 430;
                }
                else
                {
                    YellowPiece.y -= 70;
                    RedPiece.y -= 70;
                }
                if (Column7[i + 1] == 'R')//if red, draw red
                {
                    e.Graphics.FillEllipse(Brushes.Red, 428, YellowPiece.y - 70, 54, 54);
                }
                if (Column7[i + 1] == 'Y')//if yellow, draw yellow
                {
                    e.Graphics.FillEllipse(Brushes.Yellow, 428, YellowPiece.y - 70, 54, 54);
                }
            }
            for (int i = 0; i < column6Count; i++)//COLUMN 6
            {
                if (i == 0)
                {
                    YellowPiece.y = 430;
                    RedPiece.y = 430;
                }
                else
                {
                    YellowPiece.y -= 70;
                    RedPiece.y -= 70;
                }
                if (Column6[i + 1] == 'R')
                {
                    e.Graphics.FillEllipse(Brushes.Red, 358, YellowPiece.y - 70, 54, 54);
                }
                if (Column6[i + 1] == 'Y')
                {
                    e.Graphics.FillEllipse(Brushes.Yellow, 358, YellowPiece.y - 70, 54, 54);
                }
            }
            for (int i = 0; i < column5Count; i++)//COLUMN 5
            {
                if (i == 0)
                {
                    YellowPiece.y = 430;
                    RedPiece.y = 430;
                }
                else
                {
                    YellowPiece.y -= 70;
                    RedPiece.y -= 70;
                }
                if (Column5[i + 1] == 'R')
                {
                    e.Graphics.FillEllipse(Brushes.Red, 288, YellowPiece.y - 70, 54, 54);
                }
                if (Column5[i + 1] == 'Y')
                {
                    e.Graphics.FillEllipse(Brushes.Yellow, 288, YellowPiece.y - 70, 54, 54);
                }
            }
            for (int i = 0; i < column4Count; i++)//COLUMN 4
            {
                if (i == 0)
                {
                    YellowPiece.y = 430;
                    RedPiece.y = 430;
                }
                else
                {
                    YellowPiece.y -= 70;
                    RedPiece.y -= 70;
                }
                if (Column4[i + 1] == 'R')
                {
                    e.Graphics.FillEllipse(Brushes.Red, 218, YellowPiece.y - 70, 54, 54);
                }
                if (Column4[i + 1] == 'Y')
                {
                    e.Graphics.FillEllipse(Brushes.Yellow, 218, YellowPiece.y - 70, 54, 54);
                }
            }
            for (int i = 0; i < column3Count; i++)//COLUMN 3
            {
                if (i == 0)
                {
                    YellowPiece.y = 430;
                    RedPiece.y = 430;
                }
                else
                {
                    YellowPiece.y -= 70;
                    RedPiece.y -= 70;
                }
                if (Column3[i + 1] == 'R')
                {
                    e.Graphics.FillEllipse(Brushes.Red, 148, YellowPiece.y - 70, 54, 54);
                }
                if (Column3[i + 1] == 'Y')
                {
                    e.Graphics.FillEllipse(Brushes.Yellow, 148, YellowPiece.y - 70, 54, 54);
                }
            }
            for (int i = 0; i < column2Count; i++)//COLUMN 2
            {
                if (i == 0)
                {
                    YellowPiece.y = 430;
                    RedPiece.y = 430;
                }
                else
                {
                    YellowPiece.y -= 70;
                    RedPiece.y -= 70;
                }
                if (Column2[i + 1] == 'R')
                {
                    e.Graphics.FillEllipse(Brushes.Red, 78, YellowPiece.y - 70, 54, 54);
                }
                if (Column2[i + 1] == 'Y')
                {
                    e.Graphics.FillEllipse(Brushes.Yellow, 78, YellowPiece.y - 70, 54, 54);
                }
            }
            for (int i = 0; i < column1Count; i++)//COLUMN 1
            {
                if (i == 0)
                {
                    YellowPiece.y = 430;
                    RedPiece.y = 430;
                }
                else
                {
                    YellowPiece.y -= 70;
                    RedPiece.y -= 70;
                }
                if (Column1[i + 1] == 'R')
                {
                    e.Graphics.FillEllipse(Brushes.Red, 8, YellowPiece.y - 70, 54, 54);
                }
                if (Column1[i + 1] == 'Y')
                {
                    e.Graphics.FillEllipse(Brushes.Yellow, 8, YellowPiece.y - 70, 54, 54);
                }
            }
        }
        public void changeTurn()//called on every click.
        {
            if (turnCounter >= 42)
            {
                MessageBox.Show("Draw!", "Very Impressive",
                    MessageBoxButtons.OK, MessageBoxIcon.Question);
                NewGame();
            }
            turnCounter++;
            MoveCount.Text = turnCounter.ToString();
            TurnBool = !TurnBool;
        }

        #region ClickEventMethods
        private void C1Highlight_Click(object sender, EventArgs e)
        {
            changeTurn();
            if (column1Count < 7)
            {
                column1Count++;
                if (TurnBool)//add data to column array based on the turn
                {
                    Column1[column1Count] = 'R';
                }
                if (!TurnBool)
                {
                    Column1[column1Count] = 'Y';
                }
            }
            Refresh();
            CheckWinner();
        }

        private void C2Highlight_Click(object sender, EventArgs e)
        {
            changeTurn();
            if (column2Count < 7)
            {
                column2Count++;
                if (TurnBool)
                {
                    Column2[column2Count] = 'R';
                }
                if (!TurnBool)
                {
                    Column2[column2Count] = 'Y';
                }
            }
            Refresh();
            CheckWinner();
        }

        private void C3Highlight_Click(object sender, EventArgs e)
        {
            changeTurn();
            if (column3Count < 7)
            {
                column3Count++;
                if (TurnBool)
                {
                    Column3[column3Count] = 'R';
                }
                if (!TurnBool)
                {
                    Column3[column3Count] = 'Y';
                }
            }
            Refresh();
            CheckWinner();
        }

        private void C4Highlight_Click(object sender, EventArgs e)
        {
            changeTurn();
            if (column4Count < 7)
            {
                column4Count++;
                if (TurnBool)
                {
                    Column4[column4Count] = 'R';
                }
                if (!TurnBool)
                {
                    Column4[column4Count] = 'Y';
                }
            }
            Refresh();
            CheckWinner();
        }

        private void C5Highlight_Click(object sender, EventArgs e)
        {
            changeTurn();
            if (column5Count < 7)
            {
                column5Count++;
                if (TurnBool)
                {
                    Column5[column5Count] = 'R';
                }
                if (!TurnBool)
                {
                    Column5[column5Count] = 'Y';
                }
            }
            Refresh();
            CheckWinner();
        }

        private void C6Highlight_Click(object sender, EventArgs e)
        {
            changeTurn();
            if (column6Count < 7)
            {
                column6Count++;
                if (TurnBool)
                {
                    Column6[column6Count] = 'R';
                }
                if (!TurnBool)
                {
                    Column6[column6Count] = 'Y';
                }
            }
            Refresh();
            CheckWinner();
        }
        private void C7Highlight_Click(object sender, EventArgs e)
        {
            changeTurn();
            if (column7Count < 7)
            {
                column7Count++;
                if (TurnBool)
                {
                    Column7[column7Count] = 'R';
                }
                if (!TurnBool)
                {
                    Column7[column7Count] = 'Y';
                }
            }
            Refresh();
            CheckWinner();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            NewGame();
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Made for Genesis, April 2020", "Don't read the SRC!");
        }
        #endregion
        private void CheckWinner()
        {
            bool thereIsWinner = false;
            char[] redwinner = { 'R', 'R', 'R', 'R' };
            char[] yellowwinner = { 'Y', 'Y', 'Y', 'Y' };
            #region ROW|COLUMN|DIAGONAL DATA
            char[] row1 = { Column1[1], Column2[1], Column3[1], Column4[1],
            Column5[1], Column6[1], Column7[1]};
            char[] row2 = { Column1[2], Column2[2], Column3[2], Column4[2],
            Column5[2], Column6[2], Column7[2]};
            char[] row3 = { Column1[3], Column2[3], Column3[3], Column4[3],
            Column5[3], Column6[3], Column7[3]};
            char[] row4 = { Column1[4], Column2[4], Column3[4], Column4[4],
            Column5[4], Column6[4], Column7[4]};
            char[] row5 = { Column1[5], Column2[5], Column3[5], Column4[5],
            Column5[5], Column6[5], Column7[5]};
            char[] row6 = { Column1[6], Column2[6], Column3[6], Column4[6],
            Column5[6], Column6[6], Column7[6]};

            char[] Diagonal1 = { Column1[4], Column2[3], Column3[2], Column4[1] };
            char[] Diagonal2 = { Column1[5], Column2[4], Column3[3], Column4[2], Column5[1] };
            char[] Diagonal3 = { Column1[6], Column2[5], Column3[4], Column4[3], Column5[2], Column6[1] };

            char[] Diagonal4 = { Column2[6], Column3[5], Column4[4], Column5[3], Column6[2], Column7[1] };
            char[] Diagonal5 = { Column3[6], Column4[5], Column5[4], Column6[3], Column7[2] };
            char[] Diagonal6 = { Column3[6], Column4[5], Column5[4], Column6[3], Column7[2] };
            char[] Diagonal7 = { Column4[6], Column5[5], Column6[4], Column7[3] };

            char[] Diagonal8 = { Column7[4], Column6[3], Column5[2], Column4[1] };
            char[] Diagonal9 = { Column7[5], Column6[4], Column5[3], Column4[2], Column3[1] };
            char[] Diagonal10 = { Column7[6], Column6[5], Column5[4], Column4[3], Column3[2], Column2[1] };
            char[] Diagonal11 = { Column6[6], Column5[5], Column4[4], Column3[3], Column2[2], Column1[1]};
            char[] Diagonal12 = { Column5[6], Column4[5], Column3[4], Column2[3], Column1[2], };
            char[] Diagonal13 = { Column4[6], Column3[5], Column2[4], Column1[3]};
            #endregion
            #region ROWCHECKS
            ////////////////////
            ////ROW 1 CHECK/////
            ////////////////////

            for (int i = 0; i < 8 - yellowwinner.Length; i++)//YELLOW
            {
                if (row1.Skip(i).Take(yellowwinner.Length).SequenceEqual(yellowwinner))
                {
                    thereIsWinner = true;
                    MessageBox.Show("Yellow wins, Row 1");
                    break;
                }
                if (row1.Skip(i).Take(redwinner.Length).SequenceEqual(redwinner))
                {
                    thereIsWinner = true;
                    MessageBox.Show("Red wins, Row 1");
                    break;
                }
            }
            ////////////////////
            ////ROW 2 CHECK/////
            ////////////////////

            for (int i = 0; i <= 8 - yellowwinner.Length; i++)//YELLOW
            {
                if (row2.Skip(i).Take(yellowwinner.Length).SequenceEqual(yellowwinner))
                {
                    thereIsWinner = true;
                    MessageBox.Show("Yellow wins, Row 2");
                    break;
                }
                if (row2.Skip(i).Take(redwinner.Length).SequenceEqual(redwinner))
                {
                    thereIsWinner = true;
                    MessageBox.Show("Red wins, Row 2");
                    break;
                }
            }
            ////////////////////
            ////ROW 3 CHECK/////
            ////////////////////

            for (int i = 0; i < 8 - yellowwinner.Length; i++)//YELLOW
            {
                if (row3.Skip(i).Take(yellowwinner.Length).SequenceEqual(yellowwinner))
                {
                    thereIsWinner = true;
                    MessageBox.Show("Yellow wins, Row 3");
                    break;
                }
                if (row3.Skip(i).Take(redwinner.Length).SequenceEqual(redwinner))
                {
                    thereIsWinner = true;
                    MessageBox.Show("Red wins, Row 3");
                    break;
                }
            }
            ////////////////////
            ////ROW 4 CHECK/////
            ////////////////////

            for (int i = 0; i < 8 - yellowwinner.Length; i++)//YELLOW
            {
                if (row4.Skip(i).Take(yellowwinner.Length).SequenceEqual(yellowwinner))
                {
                    thereIsWinner = true;
                    MessageBox.Show("Yellow wins, Row 4");
                    break;
                }
                if (row4.Skip(i).Take(redwinner.Length).SequenceEqual(redwinner))
                {
                    thereIsWinner = true;
                    MessageBox.Show("Red wins, Row 4");
                    break;
                }
            }
            ////////////////////
            ////ROW 5 CHECK/////
            ////////////////////

            for (int i = 0; i < 8 - yellowwinner.Length; i++)//YELLOW
            {
                if (row5.Skip(i).Take(yellowwinner.Length).SequenceEqual(yellowwinner))
                {
                    thereIsWinner = true;
                    MessageBox.Show("Yellow wins, Row 5");
                    break;
                }
                if (row5.Skip(i).Take(redwinner.Length).SequenceEqual(redwinner))
                {
                    thereIsWinner = true;
                    MessageBox.Show("Red wins, Row 5");
                    break;
                }
            }
            ////////////////////
            ////ROW 6 CHECK/////
            ////////////////////

            for (int i = 0; i < 8 - yellowwinner.Length; i++)//YELLOW
            {
                if (row6.Skip(i).Take(yellowwinner.Length).SequenceEqual(yellowwinner))
                {
                    thereIsWinner = true;
                    MessageBox.Show("Yellow wins, Row 6");
                    break;
                }
                if (row6.Skip(i).Take(redwinner.Length).SequenceEqual(redwinner))
                {
                    thereIsWinner = true;
                    MessageBox.Show("Red wins, Row 6");
                    break;
                }
            }
            #endregion
            #region COLUMNCHECKS
            ////////////////////
            ///COLUMN 1 CHECK///
            ////////////////////
            for (int i = 0; i < Column1.Length - redwinner.Length; i++)//RED
            {
                if (Column1.Skip(i).Take(redwinner.Length).SequenceEqual(redwinner))
                {
                    thereIsWinner = true;
                    MessageBox.Show("Red wins. Column 1");
                    break;
                }
                if (Column1.Skip(i).Take(yellowwinner.Length).SequenceEqual(yellowwinner))
                {
                    thereIsWinner = true;
                    MessageBox.Show("Yellow wins. Column 1");
                    break;
                }
            }
            ////////////////////
            ///COLUMN 2 CHECK///
            ////////////////////
            for (int i = 0; i < Column2.Length - redwinner.Length; i++)//RED
            {
                if (Column2.Skip(i).Take(redwinner.Length).SequenceEqual(redwinner))
                {
                    thereIsWinner = true;
                    MessageBox.Show("Red wins. Column 2");
                    break;
                }
                if (Column2.Skip(i).Take(yellowwinner.Length).SequenceEqual(yellowwinner))
                {
                    thereIsWinner = true;
                    MessageBox.Show("Yellow wins. Column 2");
                    break;
                }
            }
            ////////////////////
            ///COLUMN 3 CHECK///
            ////////////////////
            for (int i = 0; i < Column3.Length - redwinner.Length; i++)//RED
            {
                if (Column3.Skip(i).Take(redwinner.Length).SequenceEqual(redwinner))
                {
                    thereIsWinner = true;
                    MessageBox.Show("Red wins. Column 3");
                    break;
                }
                if (Column3.Skip(i).Take(yellowwinner.Length).SequenceEqual(yellowwinner))
                {
                    thereIsWinner = true;
                    MessageBox.Show("Yellow wins. Column 3");
                    break;
                }
            }
            ////////////////////
            ///COLUMN 4 CHECK///
            ////////////////////
            for (int i = 0; i < Column4.Length - redwinner.Length; i++)//RED
            {
                if (Column4.Skip(i).Take(redwinner.Length).SequenceEqual(redwinner))
                {
                    thereIsWinner = true;
                    MessageBox.Show("Red wins. Column 4");
                    break;
                }
                if (Column4.Skip(i).Take(yellowwinner.Length).SequenceEqual(yellowwinner))
                {
                    thereIsWinner = true;
                    MessageBox.Show("Yellow wins. Column 4");
                    break;
                }
            }
            ////////////////////
            ///COLUMN 5 CHECK///
            ////////////////////
            for (int i = 0; i < Column5.Length - redwinner.Length; i++)//RED
            {
                if (Column5.Skip(i).Take(redwinner.Length).SequenceEqual(redwinner))
                {
                    thereIsWinner = true;
                    MessageBox.Show("Red wins. Column 5");
                    break;
                }
                if (Column5.Skip(i).Take(yellowwinner.Length).SequenceEqual(yellowwinner))
                {
                    thereIsWinner = true;
                    MessageBox.Show("Yellow wins. Column 5");
                    break;
                }
            }
            ////////////////////
            ///COLUMN 6 CHECK///
            ////////////////////
            for (int i = 0; i < Column6.Length - redwinner.Length; i++)//RED
            {
                if (Column6.Skip(i).Take(redwinner.Length).SequenceEqual(redwinner))
                {
                    thereIsWinner = true;
                    MessageBox.Show("Red wins. Column 6");
                    break;
                }
                if (Column6.Skip(i).Take(yellowwinner.Length).SequenceEqual(yellowwinner))
                {
                    thereIsWinner = true;
                    MessageBox.Show("Yellow wins. Column 6");
                    break;
                }
            }
            ////////////////////
            ///COLUMN 7 CHECK///
            ////////////////////
            for (int i = 0; i < Column7.Length - redwinner.Length; i++)//RED
            {
                if (Column7.Skip(i).Take(redwinner.Length).SequenceEqual(redwinner))
                {
                    thereIsWinner = true;
                    MessageBox.Show("Red wins. Column 7");
                    break;
                }
                if (Column7.Skip(i).Take(yellowwinner.Length).SequenceEqual(yellowwinner))
                {
                    thereIsWinner = true;
                    MessageBox.Show("Yellow wins. Column 7");
                    break;
                }
            }
            #endregion
            #region DIAGONALCHECKS
            //////////////////////
            ///DIAGONAL CHECK 1///
            //////////////////////
            for (int i = 0; i < 7 - yellowwinner.Length; i++)//YELLOW
            {
                if (Diagonal1.Skip(i).Take(yellowwinner.Length).SequenceEqual(yellowwinner))
                {
                    thereIsWinner = true;
                    MessageBox.Show("Yellow wins, Diagonal");
                    break;
                }
                if (Diagonal1.Skip(i).Take(redwinner.Length).SequenceEqual(redwinner))
                {
                    thereIsWinner = true;
                    MessageBox.Show("Red wins, Diagonal");
                    break;
                }
            }
            //////////////////////
            ///DIAGONAL CHECK 2///
            //////////////////////
            for (int i = 0; i < 7 - yellowwinner.Length; i++)//YELLOW
            {
                if (Diagonal2.Skip(i).Take(yellowwinner.Length).SequenceEqual(yellowwinner))
                {
                    thereIsWinner = true;
                    MessageBox.Show("Yellow wins, Diagonal");
                    break;
                }
                if (Diagonal2.Skip(i).Take(redwinner.Length).SequenceEqual(redwinner))
                {
                    thereIsWinner = true;
                    MessageBox.Show("Red wins, Diagonal");
                    break;
                }
            }
            //////////////////////
            ///DIAGONAL CHECK 3///
            //////////////////////
            for (int i = 0; i < 7 - yellowwinner.Length; i++)//YELLOW
            {
                if (Diagonal3.Skip(i).Take(yellowwinner.Length).SequenceEqual(yellowwinner))
                {
                    thereIsWinner = true;
                    MessageBox.Show("Yellow wins, Diagonal");
                    break;
                }
                if (Diagonal3.Skip(i).Take(redwinner.Length).SequenceEqual(redwinner))
                {
                    thereIsWinner = true;
                    MessageBox.Show("Red wins, Diagonal");
                    break;
                }
            }
            //////////////////////
            ///DIAGONAL CHECK 4///
            //////////////////////
            for (int i = 0; i < 7 - yellowwinner.Length; i++)//YELLOW
            {
                if (Diagonal4.Skip(i).Take(yellowwinner.Length).SequenceEqual(yellowwinner))
                {
                    thereIsWinner = true;
                    MessageBox.Show("Yellow wins, Diagonal");
                    break;
                }
                if (Diagonal4.Skip(i).Take(redwinner.Length).SequenceEqual(redwinner))
                {
                    thereIsWinner = true;
                    MessageBox.Show("Red wins, Diagonal");
                    break;
                }
            }
            //////////////////////
            ///DIAGONAL CHECK 5///
            //////////////////////
            for (int i = 0; i < 7 - yellowwinner.Length; i++)//YELLOW
            {
                if (Diagonal5.Skip(i).Take(yellowwinner.Length).SequenceEqual(yellowwinner))
                {
                    thereIsWinner = true;
                    MessageBox.Show("Yellow wins, Diagonal");
                    break;
                }
                if (Diagonal5.Skip(i).Take(redwinner.Length).SequenceEqual(redwinner))
                {
                    thereIsWinner = true;
                    MessageBox.Show("Red wins, Diagonal");
                    break;
                }
            }
            //////////////////////
            ///DIAGONAL CHECK 6///
            //////////////////////
            for (int i = 0; i < 7 - yellowwinner.Length; i++)//YELLOW
            {
                if (Diagonal6.Skip(i).Take(yellowwinner.Length).SequenceEqual(yellowwinner))
                {
                    thereIsWinner = true;
                    MessageBox.Show("Yellow wins, Diagonal");
                    break;
                }
                if (Diagonal6.Skip(i).Take(redwinner.Length).SequenceEqual(redwinner))
                {
                    thereIsWinner = true;
                    MessageBox.Show("Red wins, Diagonal");
                    break;
                }
            }
            //////////////////////
            ///DIAGONAL CHECK 7///
            //////////////////////
            for (int i = 0; i < 7 - yellowwinner.Length; i++)//YELLOW
            {
                if (Diagonal7.Skip(i).Take(yellowwinner.Length).SequenceEqual(yellowwinner))
                {
                    thereIsWinner = true;
                    MessageBox.Show("Yellow wins, Diagonal");
                    break;
                }
                if (Diagonal7.Skip(i).Take(redwinner.Length).SequenceEqual(redwinner))
                {
                    thereIsWinner = true;
                    MessageBox.Show("Red wins, Diagonal");
                    break;
                }
            }
            //////////////////////
            ///DIAGONAL CHECK 8///
            //////////////////////
            for (int i = 0; i < 7 - yellowwinner.Length; i++)//YELLOW
            {
                if (Diagonal8.Skip(i).Take(yellowwinner.Length).SequenceEqual(yellowwinner))
                {
                    thereIsWinner = true;
                    MessageBox.Show("Yellow wins, Diagonal");
                    break;
                }
                if (Diagonal8.Skip(i).Take(redwinner.Length).SequenceEqual(redwinner))
                {
                    thereIsWinner = true;
                    MessageBox.Show("Red wins, Diagonal");
                    break;
                }
            }
            //////////////////////
            ///DIAGONAL CHECK 9///
            //////////////////////
            for (int i = 0; i < 7 - yellowwinner.Length; i++)//YELLOW
            {
                if (Diagonal9.Skip(i).Take(yellowwinner.Length).SequenceEqual(yellowwinner))
                {
                    thereIsWinner = true;
                    MessageBox.Show("Yellow wins, Diagonal");
                    break;
                }
                if (Diagonal9.Skip(i).Take(redwinner.Length).SequenceEqual(redwinner))
                {
                    thereIsWinner = true;
                    MessageBox.Show("Red wins, Diagonal");
                    break;
                }
            }
            /////////////////////
            //DIAGONAL CHECK 10//
            /////////////////////
            for (int i = 0; i < 7 - yellowwinner.Length; i++)//YELLOW
            {
                if (Diagonal10.Skip(i).Take(yellowwinner.Length).SequenceEqual(yellowwinner))
                {
                    thereIsWinner = true;
                    MessageBox.Show("Yellow wins, Diagonal");
                    break;
                }
                if (Diagonal10.Skip(i).Take(redwinner.Length).SequenceEqual(redwinner))
                {
                    thereIsWinner = true;
                    MessageBox.Show("Red wins, Diagonal");
                    break;
                }
            }
            /////////////////////
            //DIAGONAL CHECK 11//
            /////////////////////
            for (int i = 0; i < 7 - yellowwinner.Length; i++)//YELLOW
            {
                if (Diagonal11.Skip(i).Take(yellowwinner.Length).SequenceEqual(yellowwinner))
                {
                    thereIsWinner = true;
                    MessageBox.Show("Yellow wins, Diagonal");
                    break;
                }
                if (Diagonal11.Skip(i).Take(redwinner.Length).SequenceEqual(redwinner))
                {
                    thereIsWinner = true;
                    MessageBox.Show("Red wins, Diagonal");
                    break;
                }
            }
            /////////////////////
            //DIAGONAL CHECK 12//
            /////////////////////
            for (int i = 0; i < 7 - yellowwinner.Length; i++)//YELLOW
            {
                if (Diagonal12.Skip(i).Take(yellowwinner.Length).SequenceEqual(yellowwinner))
                {
                    thereIsWinner = true;
                    MessageBox.Show("Yellow wins, Diagonal");
                    break;
                }
                if (Diagonal12.Skip(i).Take(redwinner.Length).SequenceEqual(redwinner))
                {
                    thereIsWinner = true;
                    MessageBox.Show("Red wins, Diagonal");
                    break;
                }
            }
            /////////////////////
            //DIAGONAL CHECK 13//
            /////////////////////
            for (int i = 0; i < 7 - yellowwinner.Length; i++)//YELLOW
            {
                if (Diagonal13.Skip(i).Take(yellowwinner.Length).SequenceEqual(yellowwinner))
                {
                    thereIsWinner = true;
                    MessageBox.Show("Yellow wins, Diagonal");
                    break;
                }
                if (Diagonal13.Skip(i).Take(redwinner.Length).SequenceEqual(redwinner))
                {
                    thereIsWinner = true;
                    MessageBox.Show("Red wins, Diagonal");
                    break;
                }
            }
            #endregion

            if (thereIsWinner)
                NewGame();
        }

        public void NewGame()
        {
            Array.Clear(Column1, 0, 8);
            Array.Clear(Column2, 0, 8);
            Array.Clear(Column3, 0, 8);
            Array.Clear(Column4, 0, 8);
            Array.Clear(Column5, 0, 8);
            Array.Clear(Column6, 0, 8);
            Array.Clear(Column7, 0, 8);

            column1Count = 0;
            column2Count = 0;
            column3Count = 0;
            column4Count = 0;
            column5Count = 0;
            column6Count = 0;
            column7Count = 0;

            TurnBool = false;
            turnCounter = 0;
            MoveCount.Text = turnCounter.ToString();

            Refresh();
        }

    }
}