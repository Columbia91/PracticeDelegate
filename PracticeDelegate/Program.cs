using System;

namespace PracticeDelegate
{
    class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account(1000);
            account.Propertychanged += ChangeDetector;

            account.Put(250, "Почтальон Печкин");

            Console.ReadLine();
        }
        static void ChangeDetector(object sender, PropertyeventArgs e)
        {
            Console.WriteLine($"{e.Message} от \"{sender}\"");
            Console.WriteLine($"Сумма транзакции: {e.Sum}");
        }
    }
}