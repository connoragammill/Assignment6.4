namespace Assignment6._4
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//transpose the matrix
			//  1 2 3   (make the rows columns)     1 4 7   (Flip matrix horizontally )    7 4 1 
			//  4 5 6                               2 5 8                                  8 5 2
			//  7 8 9                               3 6 9                                  9 6 3
			int[][] matrix = new int[][]
			{
				new int[] { 1, 2, 3 },
				new int[] { 4, 5, 6 },
				new int[] { 7, 8, 9 }
			};
			Rotate(matrix);
			Print(matrix);
		}
	
		public static void Rotate(int[][] matrix)
		{
			int N = matrix.Length;
			//Transpose the matrix
			for (int i = 0; i < N; i++)//iterate through the loop
			{
				for (int j = i; j < N; j++)
				{
					int temp = matrix[i][j];
					matrix[i][j] = matrix[j][i];
					matrix[j][i] = temp;//temp is now the reversed matrix [j][i]
				}
			}
			for (int i = 0; i < N; i++)
			{
				for (int j = 0; j < (N / 2); j++)
				{
					int temp = matrix[i][j];
					matrix[i][j] = matrix[i][N - 1 - j];
					matrix[i][N - 1 - j] = temp;
				}
			}
		}

		public static void Print(int[][] matrix)
		{
			foreach (var i in matrix)
			{
				Console.WriteLine(string.Join(", ", i));
			}
		}
    }
}
