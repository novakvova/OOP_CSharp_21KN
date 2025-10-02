using InhritanceDetails;
using System.Text;

Console.InputEncoding = Encoding.UTF8;
Console.OutputEncoding = Encoding.UTF8;

Console.WriteLine("Роман тримайся. Ми вболіваємо!");

//sealed - Забороняє наслідування
//var result = Math.Cos(12); //Усі методи і понял будуть статичні 

//Console.WriteLine("result {0}", result);

var items = Bolt.GetRoles(); //Отримує список ролей у системі
foreach (var item in items)
{
    Console.WriteLine(item);
}

//base

//partial - розділити клас на декілька файлів
