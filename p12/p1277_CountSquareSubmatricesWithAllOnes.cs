using System;
using System.Linq;

public class Solution {
     public int CountSquares(int[][] matrix) {
        var count = 0;
        foreach (var row in matrix) {
            foreach (var column in row) {
                if (column == 1)
                    count++;
            }
        }

        var sideLimit = Math.Max(matrix.Length, matrix[0].Length);
        for (var i=2; i<=matrix.Length; ++i) {
            for (var j=0; j<=matrix.Length-i; ++j) {
                for (var k=0; k<=matrix[0].Length-i; ++k) {
                    var isSquare = true;
                    for (var l=0; l<i; ++l) {
                        for (var m=0; m<i; ++m) {
                            if (matrix[j+l][k+m] != 1) {
                                isSquare = false;
                                break;
                            }
                        }
                        if (!isSquare)
                            break;
                    }
                    if (isSquare)
                        count++;
                   // System.Console.WriteLine(i + ", " + j + ", " + k + ", " + isSquare);
                }
            }
        }
        return count;
    }
}