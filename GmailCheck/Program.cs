//https://www.youtube.com/watch?v=SRGvQpQlBbU
//Switch gmail inbox for access for less secure apps
using System;

using OpenPop.Pop3;

namespace GmailCheck
{
    internal class Program
    {
        private static readonly Pop3Client Client = new Pop3Client();
        static void Main()
        {
            Client.Connect("pop.gmail.com", 995, true);

            Client.Authenticate("recent:email@gmail.com", "password");

            for (var i = 1; i <= Client.GetMessageCount(); i++)
            {
                Console.WriteLine(Client.GetMessage(i).ToMailMessage().Body);
            }
            
            Console.ReadKey();
        }
    }
}