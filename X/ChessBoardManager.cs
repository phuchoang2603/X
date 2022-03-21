using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaroGame
{
    public class ChessBoardManager
    {
        #region Properties
        private Panel panelChessBoard;

        public Panel ChessBoard
        {
            get { return panelChessBoard; }
            set { panelChessBoard = value; }
        }
        #endregion

        #region Initialize
        public ChessBoardManager(Panel panelChessBoard) => this.ChessBoard = panelChessBoard;


        #endregion

        #region Methods
        public void DrawChessBoard()
        {
            Button oldButton = new Button() { Width = 0, Location = new Point(0, 0) };
            for (int i = 0; i < Cons.CHESS_BOARD_HEIGHT; i++)
            {

                for (int j = 0; j < Cons.CHESS_BOARD_WIDTH; j++)
                {
                    Button btn = new Button()
                    {
                        Width = Cons.CHESS_WIDTH,
                        Height = Cons.CHESS_HEIGHT,
                        Location = new Point(oldButton.Location.X + oldButton.Width, oldButton.Location.Y),
                        BackgroundImageLayout = ImageLayout.Stretch
                    };

                    btn.Click += btn_Click;

                    ChessBoard.Controls.Add(btn);

                    oldButton = btn;
                }

                oldButton.Location = new Point(0, oldButton.Location.Y + Cons.CHESS_HEIGHT);
                oldButton.Width = 0;
                oldButton.Height = 0;

            }


        }

        void btn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.BackgroundImage = X.Properties.Resources.x;
        }
        #endregion
    }
}
