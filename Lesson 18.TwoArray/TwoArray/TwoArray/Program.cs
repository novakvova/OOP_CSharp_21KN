// See https://aka.ms/new-console-template for more information
using TwoArray;

Console.InputEncoding = System.Text.Encoding.UTF8;
Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.WriteLine("Двох мірні масив!");

/*
int[] myArray = { 3, 8, 12, 67 };

foreach (var item in myArray)
{
    Console.Write(item + "\t");
}
Console.WriteLine();
*/


/*
int[,] myTwoArray = {
    { 23, 12, 8 },
    { 4,  8,  3 },
    { 9,  11, 8 }
};

int n = myTwoArray.GetLength(0); // рядки
int m = myTwoArray.GetLength(1); // стовпці

// myTwoArray[0,0] \t myTwoArray[0,1] \t myTwoArray[0,2] \n
// myTwoArray[1,0] \t myTwoArray[1,1] \t myTwoArray[1,2] \n
// myTwoArray[2,0] \t myTwoArray[2,1] \t myTwoArray[2,2] \n

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        Console.Write(myTwoArray[i, j] + "\t");
    }
    Console.WriteLine();
}
*/

MatrixCalculator calculator = new MatrixCalculator();

//Зробити конструктор з паретрмаи, який примає на 
//себе розмір матриці n та m

//Також зробити консруктор копіювання
//Конструктор копіювання має прийти на себе об'єкт
//того ж класу та створити новий об'єкт з такими ж

//заповняємо матрицю числами від 1 до 100
calculator.InitRandomMatrix(1, 100);
calculator.PrintMatrix();