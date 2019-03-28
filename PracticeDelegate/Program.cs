using System;

namespace PracticeDelegate
{
    class Program
    {
        static void Main(string[] args)
        {
            iPropertychanged account = new Account(1000);
            account.Propertychanged += ChangeDetector;

            account.Put(250, "Почтальон Печкин");
        }
        static void ChangeDetector(object sender, PropertyeventArgs e)
        {
            Console.WriteLine($"{e.Message} от \"{sender}\"");
            Console.WriteLine($"Сумма транзакции: {e.Sum}");
        }
    }
}