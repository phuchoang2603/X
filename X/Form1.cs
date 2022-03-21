namespace CaroGame
{
    public partial class Form1 : Form
    {
        #region Properties
        ChessBoardManager ChessBoard;
        #endregion
        public Form1()
        {
            InitializeComponent();

            ChessBoard = new ChessBoardManager(panelChessBoard);
            ChessBoard.DrawChessBoard();
        }
    }
}