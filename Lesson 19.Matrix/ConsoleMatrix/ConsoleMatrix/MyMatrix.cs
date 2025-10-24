namespace ConsoleMatrix;

public class MyMatrix
{
    // тільки для читання
    private int[,] _matrix;

    public MyMatrix()
    {
        // Ініціалізація матриці 2x2
        _matrix = new int[2, 2];
    }
    public void InitRandom(int min=1, int max=10)
    {
        Random rand = new Random();
        int n = _matrix.GetLength(0);
        int m = _matrix.GetLength(1);
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                _matrix[i, j] = rand.Next(min, max); // Заповнення випадковими числами від 1 до 9
            }
        }
    }
    // Індексатор для доступу до елементів матриці
    public int this[int row, int col]
    {
        get => _matrix[row, col];
        //set => _matrix[row, col] = value;
    }
    public MyMatrix Add(MyMatrix other)
    {
        int n = _matrix.GetLength(0);
        int m = _matrix.GetLength(1);
        //Зберігає суму двох матриць
        MyMatrix result = new MyMatrix();
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                result._matrix[i, j] = this._matrix[i, j] + other._matrix[i, j];
            }
        }
        return result;
    }

    public override string ToString()
    {
        int n = _matrix.GetLength(0); //рядочки
        int m = _matrix.GetLength(1); //стовпчики
        string result = ""; //рязультучий рядок
        for (int i = 0; i < n; i++) //фікуємо рядок
        {
            for (int j = 0; j < m; j++) //зафіксували i=0 і ідемо по стовпчиках
            {
                result += _matrix[i, j].ToString() + "\t";
            }
            result += "\n"; //у кінці кожного рядка додаємо перенос рядка
        }
        return result;
    }


}
