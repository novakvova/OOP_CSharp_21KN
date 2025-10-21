namespace TwoArray;

public class MatrixCalculator
{
    // Наш масив у сеердині класу
    private int [,] matrix;
    public MatrixCalculator()
    {
        matrix = new int[2,2];
    }

    public void InitRandomMatrix(int min=1, int max=10)
    {
        Random random = new Random();
        int n = matrix.GetLength(0);
        int m = matrix.GetLength(1);
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                matrix[i,j] = random.Next(min,max);
            }
        }
    }

    public void PrintMatrix()
    {
        int n = matrix.GetLength(0);
        int m = matrix.GetLength(1);
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Console.Write(matrix[i,j] + "\t");
            }
            Console.WriteLine();
        }
    }


}
