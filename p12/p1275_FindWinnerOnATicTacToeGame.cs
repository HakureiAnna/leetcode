public class Solution {   
      public string printWinner(int cell) {
         return cell == 1? "A": "B";
     }
     public bool hasEmpty(int x, int y, int z) {
         return x == 0 || y == 0 || z == 0;
     }
    public string solve(int[][] board) {
        if (board[0][0] == board[0][1] && board[0][1] == board[0][2]) {
            if (!hasEmpty(board[0][0], board[0][1], board[0][2]))
                return printWinner(board[0][0]);
        } 
        if (board[1][0] == board[1][1] && board[1][1] == board[1][2]) {
            if (!hasEmpty(board[1][0], board[1][1], board[1][2]))
                return printWinner(board[1][0]);
        } 
        if (board[2][0] == board[2][1] && board[2][1] == board[2][2]) {
            if (!hasEmpty(board[2][0], board[2][1], board[2][2]))
                return printWinner(board[2][0]);            
        } 
        if (board[0][0] == board[1][0] && board[1][0] == board[2][0]) {            
            if (!hasEmpty(board[0][0], board[1][0], board[2][0]))
                return printWinner(board[0][0]);
        }
        if (board[0][1] == board[1][1] && board[1][1] == board[2][1]) {            
            if (!hasEmpty(board[0][1], board[1][1], board[2][1]))
                return printWinner(board[0][1]);
        }
        if (board[0][2] == board[1][2] && board[1][2] == board[2][2]) {            
            if (!hasEmpty(board[0][2], board[1][2], board[2][2]))
                return printWinner(board[0][2]);
        }
        if (board[0][0] == board[1][1] && board[1][1] == board[2][2]) {            
            if (!hasEmpty(board[0][0], board[1][1], board[2][2]))
                return printWinner(board[0][0]);
        }
        if (board[0][2] == board[1][1] && board[1][1] == board[2][0]) {            
            if (!hasEmpty(board[0][2], board[1][1], board[2][0]))
                return printWinner(board[0][2]);
        }
        foreach (var row in board) {
            foreach (var cell in row) {
                if (cell == 0) {
                    return "Pending";
                }
            }
        }
        return "Draw";
    }
    public string Tictactoe(int[][] moves) {
        var board = new int[3][];
        for (int i=0; i<board.Length; ++i) {
            board[i] = new int[3];
        }
        var player = 1;
        foreach (var move in moves) {
            board[move[0]][move[1]] = player;
            player++;
            if (player > 2) {
                player = 1;
            }
        }
        return solve(board);
    }
}