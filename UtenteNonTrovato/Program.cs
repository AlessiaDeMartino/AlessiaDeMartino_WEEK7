using System;
using System.Collections.Generic;

namespace UtenteNonTrovato
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Benvenuto in Gestione Conto!");

            try
            {
                List<User> listaUsers = new List<User>();
                User user = new User()
                {
                    UserName = "Ale95",
                    Password = 1234
                };              
                listaUsers.Add(user);

                User user1 = new User();
                user1.UserName = "Albi35";
                user1.Password = 5678;
                listaUsers.Add(user1);

                Console.WriteLine("Inserire Username");
                string utente = Console.ReadLine();

                Console.WriteLine("Inserire Password");
                int pass = int.Parse(Console.ReadLine());


                string checkUtente=CheckUserPass(utente, pass, listaUsers);

                if (checkUtente==null)
                {
                    throw new UtenteNonTrovatoException("Utente non trovato!");
                }
                else
                {
                    Console.WriteLine($"Benvenuto {utente}");
                }

            }
            catch (UtenteNonTrovatoException uEx)
            {
                Console.WriteLine(uEx.Message);
            }
            
        }

        private static string CheckUserPass(string utente, int pass, List<User> users)
        {
            foreach (var item in users)

            if (item.UserName == utente && item.Password == pass)
                {
                    Console.WriteLine("Utente Trovato");
                    return utente;
                }
                return null;              
        }
    }
}
