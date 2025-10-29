// See https://aka.ms/new-console-template for more information
using ConsoleApp1;

Console.InputEncoding = System.Text.Encoding.UTF8;
Console.OutputEncoding = System.Text.Encoding.UTF8;
//Console.WriteLine("Ще не вмерла Україна");
void DisplayAutoInfo(string info) //Диплей автомобіля
{
    Console.WriteLine(info);
}
void DisplayAutoErrorInfo(string info) //Диплей автомобіля
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("-----------------");
    Console.WriteLine(info);
    Console.WriteLine("-----------------");
    Console.ForegroundColor = ConsoleColor.White;
}
//Створюємо об'єкт автомобіля
Car car = new Car("BMW", 240);
car.RegisterDisplayAuto(DisplayAutoInfo); //підключили дисплей для авто
car.RegisterDisplayProplemAuto(DisplayAutoErrorInfo); //підключили дисплей для проблем авто
car.Run(50);
car.Run(200); //збільшили швидкість на 200 км/год
