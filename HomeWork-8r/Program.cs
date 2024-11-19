using HomeWork_8.Core.BankAccount.BankAccount;
using HomeWork_8.Interfaces.IMessageService;
using HomeWork_8.Core.Notification;
using HomeWork_8.Core.Services.SmsService;
using HomeWork_8.Core.Services.MailService;

IMessageService SmsBankService = new SmsService();
IMessageService MmailBankService = new MailService();
Notification SmsNotificationService = new(SmsBankService);
Notification MailNotificationService = new Notification(MmailBankService);


BankAccount bankAccount = new BankAccount();
bankAccount.DataChanged += SmsNotificationService.Send;
bankAccount.DataChanged += MailNotificationService.Send;

while (true)
{
    try
    {
        Console.WriteLine("Name: ");
        bankAccount.Name = Console.ReadLine()!;
        Console.WriteLine("Email: ");
        bankAccount.Email = Console.ReadLine()!;
        Console.WriteLine("Id: ");
        bankAccount.Id = Console.ReadLine()!;
        Console.WriteLine("Cash: ");
        bankAccount.Cash = Decimal.Parse(Console.ReadLine()!);
    }
    catch (Exception a)
    {
        Console.WriteLine(a.Message);
    }
    Console.ReadLine();
    Console.Clear();
}

