// See https://aka.ms/new-console-template for more information
using WorkingDelegate;

Console.InputEncoding = System.Text.Encoding.UTF8;
Console.OutputEncoding = System.Text.Encoding.UTF8;

Console.WriteLine("Привіт козаки і козачки!");



//int result = MyCalculator.Add(5, 10); //виклик методу
//Console.WriteLine("Result = " + result);
Console.WriteLine("Оберіть операцію ");
Console.WriteLine("1.Додавання");
Console.WriteLine("2.Віднімання");
Console.Write("->_");
int action = int.Parse(Console.ReadLine()!);
MySuperDelegate? del = null;
if(action == 1)
    del = new MySuperDelegate(MyCalculator.Add); //створення делегата
else if(action == 2)
    del = new MySuperDelegate(MyCalculator.Minus);

if(del != null)
{
    //int result = del(20, 10); //виклик методу через делегат
    int result = del.Invoke(20, 10); //виклик методу через делегат
    Console.WriteLine("Результат роботи " + result);
}

//делегат - це вказівник на метод
//Тобто делегат може вказувати на певний метод, а потім
//цей метод можна викликати через делегат
