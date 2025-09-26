using ExampleSMTP;
using MailKit.Net.Smtp;
using MimeKit;
using System.Text;

Console.InputEncoding = Encoding.UTF8;
Console.OutputEncoding = Encoding.UTF8;

Message msg = new Message
{
    Subject = "Ідемо гуляти",
    Body = "Сьогодні можна піти гулять до лісу, якщо ви не в Канаді," +
    "бо останій раз мій сусід попав на ведмедя",
    To = "novakvova@gmail.com"
};

string pathFile = @"C:\images\1.jpg";

var attachment = new MimePart("image", "jpg")
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
multipart.Add(attachment);

//Налаштування для відправки
var em = new MimeMessage();
em.From.Add(new MailboxAddress(MailConf.From)); //від кого
em.To.Add(new MailboxAddress(msg.To)); //кому надсилаємо
em.Subject = msg.Subject; //тема листа
//Тіло повідомлення
em.Body = multipart; //тіло повідомлення

//Налаштуванн сервера
using var client = new SmtpClient();
try
{

}
catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}

