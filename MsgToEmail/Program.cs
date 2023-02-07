using Microsoft.VisualBasic;
using System;
using System.Net;
using System.Net.Mail;
using System.Text.RegularExpressions;


public class Mail
{
    static void Main(string[] args)
    {

        Console.WriteLine("Введите логин почты:");
        string myaddress = Email();


        //нужно добавить в настройках своей почты mail.ru пароль для приложений и использовать его в качестве пароля
        Console.WriteLine("Пароль от почты:");
        string mypassword = Password();

        Console.WriteLine("Введите адрес отправки");
        string recipaddress = Email();


        Console.WriteLine("Заголовок:");
        string title = Console.ReadLine();

        Console.WriteLine("Сообщение:");
        string textmessage = Console.ReadLine();

        MailMessage mail = InitMail(myaddress, recipaddress, title, textmessage);
        SmtpClient client = InitSmtp(myaddress, mypassword);
        SendMail(client, mail);
        Console.ReadKey();

    }

    public static bool MatchEmail(string myaddress)
    {
        Regex emailRegex = new Regex(@"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");
        return emailRegex.IsMatch(myaddress);

    }

    public static string Email()
    {
        string myaddress = Console.ReadLine();

        if (MatchEmail(myaddress))
        {
            return myaddress;
        }
        else
        {
            Console.WriteLine("Некорректный ввод почты");
            return Email();
        }
    }

    public static string Password()
    {
        return Console.ReadLine();

    }

    public static MailMessage InitMail(string myaddress, string recipaddress, string title, string textmessage)
    {
        MailMessage mail = new MailMessage();
        mail.From = new MailAddress(myaddress); // Почта отправителя
        mail.To.Add(new MailAddress(recipaddress)); // Почта получателя
        mail.Subject = title;
        mail.Body = textmessage;
        return mail;
    }

    public static SmtpClient InitSmtp(string myaddress, string mypassword)
    {
        SmtpClient client = new SmtpClient();
        client.Host = "smtp.mail.ru";
        client.Port = 587;
        client.EnableSsl = true;
        client.UseDefaultCredentials = false;
        client.Credentials = new NetworkCredential(myaddress, mypassword); // Логин и пароль вашей почты
        return client;
    }

    public static void SendMail(SmtpClient client, MailMessage mail)
    {
        client.Send(mail);
        Console.WriteLine("Сообщение отправлено");
    }


}