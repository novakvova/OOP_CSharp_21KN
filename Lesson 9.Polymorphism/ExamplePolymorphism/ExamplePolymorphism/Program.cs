// See https://aka.ms/new-console-template for more information
using ExamplePolymorphism;
using System.Text;

Console.InputEncoding = Encoding.UTF8;
Console.OutputEncoding = Encoding.UTF8;

//Поліморфізм - 3 принцип ООП
//1 - Інкапсуляція - Приховування та захист даних
//2 - Наслідування - Створення нових на основі снуючих
//3 - Поліморфізм - використання virtual ovveride
//Використаня наслідування для перевизначення методів
//бактоківського класу
// - створення обєктів на етапі виконання програми.
// ...

Console.WriteLine("--Усіх із св'ятом. Захисника вітчизни--");

//Worker semen = new Worker();
//semen.ViewInfo();
//Teacher vova = new Teacher();
//vova.ViewInfo();

//Worker alik = new Teacher();
//alik.ViewInfo();

//Worker bibi = new Bomber();
//bibi.ViewInfo();

Worker worker;

Console.WriteLine("Хто Вам потрібен");
Console.WriteLine("1.Викладач");
Console.WriteLine("2.Бомбер");
int action = 0;

action = int.Parse(Console.ReadLine());
if (action == 1)
    worker = new Teacher();
else
    worker = new Bomber();

worker.ViewInfo();



