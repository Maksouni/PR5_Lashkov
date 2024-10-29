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
            DbConnector db = new DbConnector();

            User user = db.GetUserById(1);
            if (user != null )
            {
                Console.WriteLine($"id: {user.Id} \nlogin: {user.Login} \npassword: {user.Password} \nrole: {user.Role}");
            }
            Console.ReadKey();
        }
    }
}
