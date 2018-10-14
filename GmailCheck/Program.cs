//https://www.youtube.com/watch?v=SRGvQpQlBbU
//Switch gmail inbox for access for less secure apps
using System;

using OpenPop.Pop3;

namespace GmailCheck
{
    class Program
    {
        private static Pop3Client client = new Pop3Client();
        static void Main(string[] args)
        {
            client.Connect("pop.gmail.com", 995, true);
            client.Authenticate("recent:email@gmail.com", "password");
            for (var i = 1; i <= client.GetMessageCount(); i++)
            {
                Console.WriteLine(client.GetMessage(i).ToMailMessage().Body);
            }
            
            Console.ReadKey();
        }
    }
}