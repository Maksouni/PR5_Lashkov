using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HashPasswords;
using PR5_Lashkov.Model;

namespace PR5_Lashkov
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Add new user\n");
            bool continueAdding = true;
            while (continueAdding)
            {
                Console.Write("Enter login: ");
                string login = Console.ReadLine().Trim();
                Console.Write("Enter password: ");
                string password = Console.ReadLine().Trim();
                password = HashPassword.HashPass(password);
                Console.WriteLine(password);
                Console.Write("Enter role id: ");
                int roleId = Convert.ToInt32(Console.ReadLine());

                Users user = new Users()
                {
                    login = login,
                    password = password,
                    role_id = roleId
                };
                Helper.CreateUser(user);

                
                while (true)
                {
                    Console.WriteLine("Continue? y/n");
                    string input = Console.ReadLine();
                    if (input == "n")
                    {
                        continueAdding = false;
                        break;
                    }
                    else if (input == "y") break;
                }
                
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
