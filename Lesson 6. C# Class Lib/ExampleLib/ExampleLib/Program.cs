// See https://aka.ms/new-console-template for more information
//using MyCalculator;

using Privat24;

Console.InputEncoding = System.Text.Encoding.UTF8;
Console.OutputEncoding = System.Text.Encoding.UTF8;

Console.WriteLine("Привіт козаки і козачки");
//Calculator calc = new Calculator();
//calc.PrintInfo();

PrivatService ps = new PrivatService();
//ps.PrintInfo();
ps.GetJsonValuta();
Console.WriteLine(ps.GetJsonValuta());


