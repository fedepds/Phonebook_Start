using System;
using WhatsAppApiUCU;
using TwitterUCU;

namespace PhoneBook
{
    class Program 
    {

        static void Main(string[] args)
        {
            var whatsApp = new WhatsAppApi();
            whatsApp.Send("+59897224555", "Que andas PAPA");

            var twitter = new TwitterImage();
            Console.WriteLine(twitter.PublishToTwitter("Text", @"PathToImage.png"));
            
            

            // Enviar un correo a algunos contactos

            // Enviar un WhatsApp a algunos contactos

            // Enviar un SMS a algunos contactos
        }
    }
}
