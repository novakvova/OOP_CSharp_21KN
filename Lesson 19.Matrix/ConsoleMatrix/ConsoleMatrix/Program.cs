// See https://aka.ms/new-console-template for more information

using ConsoleMatrix;

Console.InputEncoding = System.Text.Encoding.UTF8;
Console.OutputEncoding = System.Text.Encoding.UTF8;

Console.WriteLine("Привіт козаки і козачки :)");

MyMatrix a = new MyMatrix();
a.InitRandom();

//Console.WriteLine("a[0,0] = " + a[0,0]);
Console.WriteLine("------Наша матриця A-------");
Console.WriteLine(a.ToString());

MyMatrix b = new MyMatrix();
b.InitRandom();
Console.WriteLine("------Наша матриця B-------");
Console.WriteLine(b.ToString());

//MyMatrix c = a+b;
MyMatrix c = a.Add(b);
Console.WriteLine("------Сума матриць A + B-------");
Console.WriteLine(c.ToString());