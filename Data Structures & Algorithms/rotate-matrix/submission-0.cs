public class Solution {
    public void Rotate(int[][] matrix) {
         int n = matrix.Length;

        for(int i = 0; i < n; i++){
            for(int j = 0; j < n; j++){
                if(j > i){
                    int temp = matrix[i][j];
                    matrix[i][j] = matrix[j][i];
                    matrix[j][i] = temp;
                }
            }
        }

        for(int i = 0; i < n; i++){
            for(int j = 0; j < n/2; j++){
                    int temp = matrix[i][j];
                    matrix[i][j] = matrix[i][n-1-j];
                    matrix[i][n-1-j] = temp;
                
            }
        }
    }
}
