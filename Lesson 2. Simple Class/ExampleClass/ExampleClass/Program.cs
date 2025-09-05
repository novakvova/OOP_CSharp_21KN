// See https://aka.ms/new-console-template for more information
using ExampleClass;
using System.Text;

Console.InputEncoding = Encoding.UTF8;
Console.OutputEncoding = Encoding.UTF8;

//Інформація про студента
//Клас - це механізм для створення об'єктів.
//Для створення об'єкту нам потрібно зробити клас, а потім на основі класу
//створити змінну даного класу (об'єкт)
//string name = "Йосип";
//short age = 18;
//Console.WriteLine("Привіт Запоріжжя!");

//Створюємо змінну типу Student, яка називається yosup.

int action = 0;
do
{
    Console.WriteLine("Оберіть операцію:");
    Console.WriteLine("0.Вихід");
    Console.WriteLine("1.Додати студента у файл");
    Console.WriteLine("2.Показати список студентів на навчанні");
    Console.Write("->_");
    action = int.Parse(Console.ReadLine());
    switch(action)
    {
        case 1:
            {
                //слово new - виділяємо память під об'єкт yosup
                Student yosup = new Student();
                Console.WriteLine("Як Вас звати?");
                yosup.name = Console.ReadLine(); //Змінні в середині класу називаються поля
                Console.WriteLine("Який у Вас вік?");
                yosup.age = int.Parse(Console.ReadLine()); //присвоюємо значення 18
                Console.WriteLine("Ви зараховані на навчання :)");
                Console.WriteLine($"{yosup.name} {yosup.age}");

                //Маю файл і режим роботи буде дозапис
                //Вміст файлу видаляти не буде. Завжди дописуємо
                StreamWriter sw =
                    new StreamWriter("students.txt", true);
                sw.WriteLine(yosup.name);
                sw.WriteLine(yosup.age);
                sw.Close();
                break;
            }
        case 2:
            {
                StreamReader sr = new StreamReader("students.txt");
                string str = sr.ReadLine();
                while(!string.IsNullOrEmpty(str))
                {
                    //Console.WriteLine(str);
                    if(!string.IsNullOrEmpty(str))
                    {
                        //Якщо вдалося прочитати name
                        Student temp = new Student();
                        temp.name = str;
                        temp.age = int.Parse(sr.ReadLine()); //Читаю вік студента
                        Console.WriteLine($"{temp.name} -- {temp.age}");
                    }
                    str = sr.ReadLine();
                }
                sr.Close(); //Ми зкриваємо потік читання файлу. 
                break;
            }
    }

} while (action != 0);


