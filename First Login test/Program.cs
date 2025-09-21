using System;
class Program
{
    static void Main()
    {
        Login();
        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
    static void Login()
    {
        Console.WriteLine("Enter username:");
        string username = Console.ReadLine();
        Thread.Sleep(2000);

        Console.WriteLine("Enter password:");
        string password = "";

        ConsoleKeyInfo key;
        do
        {
            key = Console.ReadKey(intercept: true);
            // intercept: true يعني متعرضش الحرف في الكونسول
            {
                password += key.KeyChar;
                Console.Write("*"); // عشان يطلع نجوم بدل الحروف
            }
        } while (key.Key != ConsoleKey.Enter); // Enter عشان يخرج من اللوب لما يضغط انتر

        Console.WriteLine(); // عشان ينزل سطر بعد ما يضغط انتر  
        Thread.Sleep(2000);
        Console.WriteLine($"Username: {username}, Password: {password}");

        Thread.Sleep(3000);
    }
}