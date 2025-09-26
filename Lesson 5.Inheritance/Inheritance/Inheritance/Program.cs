// See https://aka.ms/new-console-template for more information
using Inheritance;

Console.InputEncoding = System.Text.Encoding.UTF8;
Console.OutputEncoding = System.Text.Encoding.UTF8;
//Console.WriteLine("Привіт друзі :)");

Console.WriteLine("******Basic Inheritance******\n");
/*
Car car = new Car(180);
car.Speed = 50;
Console.WriteLine("Мій автомобіль їду {0} км/год", car.Speed);
*/

MiniVan miniVan = new MiniVan();
miniVan.Speed = 170;
Console.WriteLine("Мій вен їду {0} км/год", miniVan.Speed);
