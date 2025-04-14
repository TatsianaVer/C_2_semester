using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Program
{
    public static void Main()
    {
        Console.Write("Enter chat name: ");
        var data = new ChatData(Console.ReadLine());

        var userAdder = new UserAdder();
        var messageSender = new MessageSender();
        var infoGetter = new ChatInfoGetter();
        var wordAdder = new BannedWordAdder();
        var userRemover = new UserRemover();

        while (true)
        {
            Console.WriteLine("\n1. Add user");
            Console.WriteLine("2. Send message");
            Console.WriteLine("3. Remove user");
            Console.WriteLine("4. Add banned word");
            Console.WriteLine("5. Show chat info");
            Console.WriteLine("6. Exit");
            Console.Write("Select: ");

            switch (Console.ReadLine())
            {
                case "1":
                    Console.Write("Username: ");
                    userAdder.Execute(data, Console.ReadLine());
                    break;

                case "2":
                    Console.Write("Sender: ");
                    string user = Console.ReadLine();
                    Console.Write("Message: ");
                    string msg = Console.ReadLine();
                    Console.WriteLine(messageSender.Execute(data, user, msg) ? "OK" : "Error: forbidden word or invalid user");
                    break;

                case "3":
                    Console.Write("Username to remove: ");
                    userRemover.Execute(data, Console.ReadLine());
                    break;

                case "4":
                    Console.Write("Banned word: ");
                    wordAdder.Execute(data, Console.ReadLine());
                    break;

                case "5":
                    Console.WriteLine(infoGetter.Execute(data)); // Вывод информации
                    break;

                case "6":
                    return;

                default:
                    Console.WriteLine("Invalid input");
                    break;
            }
        }
    }
}