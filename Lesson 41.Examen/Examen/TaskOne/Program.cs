// See https://aka.ms/new-console-template for more information
using System.Text;
using TaskOne;

Console.InputEncoding = Encoding.UTF8;
Console.OutputEncoding = Encoding.UTF8;

Console.WriteLine("Привіт козаки!");

Dog santa = new Dog();
Console.WriteLine("Santa "+ santa.ToString());