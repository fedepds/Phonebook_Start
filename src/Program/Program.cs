using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Contact Jorge = new Contact("Jorge", "099123456","Jorge@email.com");
            Contact Mario = new Contact("Mario", "099654321","Mario@email.com");


            Phonebook Contactos = new Phonebook(Jorge);   

            Contactos.AddContact(Mario);
            
            


            // Enviar un correo a algunos contactos

            // Enviar un WhatsApp a algunos contactos

            // Enviar un SMS a algunos contactos
        }
    }
}
