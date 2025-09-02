// See https://aka.ms/new-console-template for more information
using System.Text;

Console.InputEncoding = Encoding.UTF8;
Console.OutputEncoding = Encoding.UTF8;

string name;

Console.WriteLine("Хто ви?");

name = Console.ReadLine() ?? "Юхим"; //вводимо текст із клавіатури на консоль і записуємо у name

Console.WriteLine($"Вітаю Вас у програмі: {name}");

Console.WriteLine("Скільки у Вас оцінок?");
//Перетворорюємо рядок в int
int n = int.Parse(Console.ReadLine() ?? "0"); //вертає string - не можна перетворити в int
int[] marks; //Зберігає оцінки - він пустий
marks = new int[n]; //виділив память на масив 10 елементів

for (int i = 0; i < n; i++)
{
    Console.Write($"{i} -> ");
    marks[i] = int.Parse(Console.ReadLine() ?? "0");
}

int sum = 0;
foreach (int item in marks)
{
    sum += item; //Зберігаємо суму елементів
}
double s = sum / (double)n;
if (s>=0 && s < 5)  // Логічне І = щоб була істина - з права і зліва має бути true
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Нормальна тройка - може двійка");
}
else if (s>=5 && s < 10)
{
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("Уже добре, але можна можна краще (Вандам)");
}
else
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Ви Супер. Дуже круто.");
}
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine("Ваш середній бал: {0}", s);