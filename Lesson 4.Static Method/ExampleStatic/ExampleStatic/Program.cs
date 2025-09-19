// See https://aka.ms/new-console-template for more information

using Bogus;
using ExampleStatic;
using System.Text;

//static - дозволяє викликати методи класу без потреба створенне
// екземпляру класу або об'єкту

Console.InputEncoding = Encoding.UTF8;
Console.OutputEncoding = Encoding.UTF8;

//Ctrl + / - там біля shift правий
//Console.WriteLine("Скільки Вам рочків?");
//int age = int.Parse(Console.ReadLine());

//Console.WriteLine($"age = {age}");

//Ми використали клас Faker з бібліотеки Bogus
Faker faker = new Faker("uk"); 
string lastName = faker.Name.LastName(); //Прізвище 
string firstName = faker.Name.FirstName(); //Ім'я
int age = faker.Random.Int(18, 60); //Вік від 18 до 60 років

Man ivan = new Man();
Man petro = new Man();
Man vova = new Man(firstName,lastName, age);

Console.WriteLine(vova);

Man.Info();
int count = Man.GetCounter();
Console.WriteLine("Counter Man = {0}", count);
