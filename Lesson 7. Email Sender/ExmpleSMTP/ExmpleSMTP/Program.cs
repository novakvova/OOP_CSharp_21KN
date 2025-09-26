using ExmpleSMTP;
using MimeKit;
using MailKit.Net.Smtp;
using System.Text;

Console.InputEncoding = Encoding.UTF8;
Console.OutputEncoding = Encoding.UTF8;

Message msg = new Message()
{
    Subject = "Ідемо гуляти",
    Body = "Сьогодні можна піти гулять до лісу, якщо ви не в Канаді" +
        " бо останній раз мій сусід попав на ведмедя",
    To = "romasik8585@gmail.com"
};

string pathFile = @"C:\Users\novak\Desktop\images\images.jpg";

var atachment = new MimePart("image", "jpg")
{
    FileName = "Квіточка",
    Content = new MimeContent(File.OpenRead(pathFile))
};

var body = new TextPart("plain")
{
    Text = msg.Body
};

var multipart = new Multipart("mixed");
multipart.Add(body);
multipart.Add(atachment);

// Налаштування для відправки
var em = new MimeMessage();
em.From.Add(new MailboxAddress(MailCore.From)); // від кого
em.To.Add(new MailboxAddress(msg.To)); // кому
em.Subject = msg.Subject; // тема листа
em.Body = multipart; // вміст листа

// Налаштування сервера
using var client = new SmtpClient();
try
{
    //Підключаємо до сервера - ukr.net smpt
    client.Connect(MailCore.SmtpServer, MailCore.SmtpPort, true);
    //Аутенифікація на сервері
    client.Authenticate(MailCore.UserName, MailCore.Password);
    //Проводимо надсилання листа
    client.Send(em);
    //Розриваємо зєднання
    client.Disconnect(true);
    Console.WriteLine("Лист успішно відправлено!");
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

